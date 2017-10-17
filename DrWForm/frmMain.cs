using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DrWForm
{
    public partial class frmMain : FormBase
    {

        public struct DataLineStruct
        {
            public int iLineType;
            public float fX1Pos;
            public float fY1Pos;
            public float fZ1Pos;
            public float fX2Pos;
            public float fY2Pos;
            public float fZ2Pos;
        };

        public struct DataPolyLineStruct
        {
            public int iLineType;
            public int iNum;
            public float fX1Pos;
            public float fY1Pos;
            public float fX2Pos;
            public float fY2Pos;

        };

        public struct DataArcStruct
        {
            public float fXPos;
            public float fYPos;
            public float fX1Pos;
            public float fY1Pos;
            public float fRPos;
            public float fptXPos;
            public float fptYPos;
            public float fAngle1Pos;
            public float fAngle2Pos;
            public float fIPos;
            public float fJPos;
        };

        public struct DataCircleStruct
        {
            public float fXPos;
            public float fYPos;
            public float fZPos;
            public float fRPos;
        };

        public struct DataTypeStruct
        {

            public int iCutNum;
            public bool xIsMoveDown;
            public int iLineType;
            public float fXPos;
            public float fYPos;
            public float fIPos;
            public float fJPos;
        };


        List<DataPolyLineStruct> stuPolyLineArray = new List<DataPolyLineStruct>();
        List<DataTypeStruct> stuDataArray = new List<DataTypeStruct>();
        List<DataLineStruct> stuLineArray = new List<DataLineStruct>();
        List<DataArcStruct> stuArcArray = new List<DataArcStruct>();
        List<DataCircleStruct> stuCircleArray = new List<DataCircleStruct>();
        private string path = "";
        DataTypeStruct stuActPoint, stuOldPoint;
        private FileInfo theSourceFile;
        private double XMax, XMin;
        private double YMax, YMin;
        private double ZMax, ZMin;
        int xStrat, xEnd, yStart, yEnd;
        bool xIsRead = false;

        float m_fradio;
        float m11, m12, m13, m21, m22, m23;

        public frmMain()
        {
            InitializeComponent();
            LoadData();
            m_fradio = 1;
            m11 = m22 = 1;
            m12 = m21 = 0;
            m13 = 0;
            m23 = 0;
            xStrat = xEnd = yStart = yEnd = 0;
            path = System.Environment.CurrentDirectory;
            path = path + "\\DxfFile";
            DirectoryInfo TheFolder = new DirectoryInfo(path);
            //遍历文件
            foreach (FileInfo NextFile in TheFolder.GetFiles())
                this.treeView1.Nodes.Add(NextFile.Name);
           
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "当前时间：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }
        private void LoadData()
        {
            this.WindowState = FormWindowState.Maximized;
            timerDate.Start();
            rbtUserName.Text = "您好：" + base.PersonName;
            menu.PersonID = base.PersonID;
            //menu.Execute();
            //deskTop1.ExSort();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void rbtUserName_Click(object sender, EventArgs e)
        {

        }

        private void deskTopItem2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdPassWord_Click(object sender, EventArgs e)
        {

        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string filename;
            string line1, line2;							//these line1 and line2 is used for getting the a/m data groups...

            line1 = "0";									//line1 and line2 are are initialized here...
            line2 = "0";

            filename = path + "\\" + e.Node.Text;
            //richTextBox1.Clear();
            stuLineArray.Clear();
            stuCircleArray.Clear();
       

     
            stuArcArray.Clear();
            stuPolyLineArray.Clear();
            theSourceFile = new FileInfo(filename);		//the sourceFile is set.

//            StreamReader reader = new StreamReader(filename, Encoding.Default);
            StreamReader reader;
            reader = theSourceFile.OpenText();			//the reader is set ...
            do
            {
                ////////////////////////////////////////////////////////////////////
                //This part interpretes the drawing objects found in the DXF file...
                ////////////////////////////////////////////////////////////////////

                if (line1 == "2" && line2 == "ENTITIES")
                {
                    xIsRead = true;
                }

                if (line2 == "ENDSEC")
                {
                    xIsRead = false;
                }


                if (xIsRead)
                {


                    if (line1 == "0" && line2 == "LINE")
                        LineModule(reader);


                    else if (line1 == "0" && line2 == "LWPOLYLINE")
                        PolylineModule(reader);


                    else if (line1 == "0" && line2 == "CIRCLE")
                        CircleModule(reader);


                    else if (line1 == "0" && line2 == "ARC")
                        ArcModule(reader);


                    else if (line1 == "0" && line2 == "POLYLINE")
                        PolylineModule(reader);
                    ////////////////////////////////////////////////////////////////////
                    ////////////////////////////////////////////////////////////////////
                }

                    GetLineCouple(reader, out line1, out line2);		//the related method is called for iterating through the text file and assigning values to line1 and line2...
                
            }
            while (line2 != "EOF");

            reader.DiscardBufferedData();							//reader is cleared...
            theSourceFile = null;
            reader.Close();

            PaintBack();
            //Compare();
        }

        private void GetLineCouple(StreamReader theReader, out string line1, out string line2)		//this method is used to iterate through the text file and assign values to line1 and line2
        {
            System.Globalization.CultureInfo ci = System.Threading.Thread.CurrentThread.CurrentCulture;
            string decimalSeparator = ci.NumberFormat.CurrencyDecimalSeparator;

            line1 = line2 = "";

            if (theReader == null)
                return;

            line1 = theReader.ReadLine();
            if (line1 != null)
            {
                line1 = line1.Trim();
                line1 = line1.Replace('.', decimalSeparator[0]);

            }
            line2 = theReader.ReadLine();
            if (line2 != null)
            {
                line2 = line2.Trim();
                line2 = line2.Replace('.', decimalSeparator[0]);
            }
        }

        private void LineModule(StreamReader reader)		//Interpretes line objects in the DXF file
        {
            string line1, line2;
            line1 = "0";
            line2 = "0";

            float x1 = 0;
            float y1 = 0;
            float z1 = 0;
            float x2 = 0;
            float y2 = 0;
            float z2 = 0;

            DataLineStruct stu1 = new DataLineStruct();


            do
            {
                GetLineCouple(reader, out line1, out line2);

                if (line1 == "10")
                {
                    x1 = (float)Convert.ToDouble(line2);

                    if (x1 > XMax)
                        XMax = x1;

                    if (x1 < XMin)
                        XMin = x1;
                }

                if (line1 == "20")
                {
                    y1 = (float)Convert.ToDouble(line2);
                    if (y1 > YMax)
                        YMax = y1;

                    if (y1 < YMin)
                        YMin = y1;
                }

                if (line1 == "30")
                {
                    z1 = (float)Convert.ToDouble(line2);
                    if (z1 > ZMax)
                        ZMax = y1;

                    if (z1 < ZMin)
                        ZMin = y1;
                }

                if (line1 == "11")
                {
                    x2 = (float)Convert.ToDouble(line2);

                    if (x2 > XMax)
                        XMax = x2;

                    if (x2 < XMin)
                        XMin = x2;
                }

                if (line1 == "21")
                {
                    y2 = (float)Convert.ToDouble(line2);

                    if (y2 > YMax)
                        YMax = y2;

                    if (y2 < YMin)
                        YMin = y2;
                }

                if (line1 == "31")
                {
                    z2 = (float)Convert.ToDouble(line2);
                    if (z2 > ZMax)
                        ZMax = y1;

                    if (z2 < ZMin)
                        ZMin = y1;
                }


            }
            while (line1 != "31");

            stu1.fX1Pos = x1;
            stu1.fX2Pos = x2;
            stu1.fZ1Pos = z1;
            stu1.fZ2Pos = z2;
            stu1.fY1Pos = y1;
            stu1.fY2Pos = y2;

            stuLineArray.Add(stu1);
   

        }



        private void CircleModule(StreamReader reader)		//Interpretes circle objects in the DXF file
        {
            string line1, line2;
            line1 = "0";
            line2 = "0";

            float x1 = 0;
            float y1 = 0;
            float z1 = 0;
            float radius = 0;

            DataCircleStruct stu1;

            do
            {
                GetLineCouple(reader, out line1, out line2);

                if (line1 == "10")
                {
                    x1 = (float)Convert.ToDouble(line2);

                }


                if (line1 == "20")
                {
                    y1 = (float)Convert.ToDouble(line2);

                }

                if (line1 == "30")
                {
                    z1 = (float)Convert.ToDouble(line2);

                }


                if (line1 == "40")
                {
                    radius = (float)Convert.ToDouble(line2);

                    if ((x1 + radius) > XMax)
                        XMax = x1 + radius;

                    if ((x1 - radius) < XMin)
                        XMin = x1 - radius;

                    if (y1 + radius > YMax)
                        YMax = y1 + radius;

                    if ((y1 - radius) < YMin)
                        YMin = y1 - radius;

                }



            }
            while (line1 != "40");

            stu1.fXPos = x1;
            stu1.fYPos = y1;
            stu1.fZPos = z1;
            stu1.fRPos = radius;

            stuCircleArray.Add(stu1);

     

        }

        private void ArcModule(StreamReader reader)		//Interpretes arc objects in the DXF file
        {
            string line1, line2;
            line1 = "0";
            line2 = "0";
            float ptx = 0;
            float pty = 0;
            float x1 = 0;
            float y1 = 0;
            float x2 = 0;
            float y2 = 0;
            float radius = 0;
            float angle1 = 0;
            float angle2 = 0;
            float i = 0;
            float j = 0;

            DataArcStruct stu1;

            do
            {
                GetLineCouple(reader, out line1, out line2);

                if (line1 == "10")
                {
                    ptx = (float)Convert.ToDouble(line2);
                    if (ptx > XMax)
                        XMax = ptx;
                    if (ptx < XMin)
                        XMin = ptx;

                }


                if (line1 == "20")
                {
                    pty = (float)Convert.ToDouble(line2);
                    if (pty > YMax)
                        YMax = pty;
                    if (pty < YMin)
                        YMin = pty;
                }



                if (line1 == "40")
                {
                    radius = (float)Convert.ToDouble(line2);

                    if ((ptx + radius) > XMax)
                        XMax = ptx + radius;

                    if ((ptx - radius) < XMin)
                        XMin = ptx - radius;

                    if (pty + radius > YMax)
                        YMax = pty + radius;

                    if ((pty - radius) < YMin)
                        YMin = pty - radius;
                }

                if (line1 == "50")
                    angle1 = (float)Convert.ToDouble(line2);

                if (line1 == "51")
                    angle2 = (float)Convert.ToDouble(line2);


            }
            while (line1 != "51");

            x1 = ptx + (float)Math.Cos(angle1 / 180.0 * Math.PI) * radius;
            y1 = pty + (float)Math.Sin(angle1 / 180.0 * Math.PI) * radius;
            x2 = ptx + (float)Math.Cos(angle2 / 180.0 * Math.PI) * radius;
            y2 = pty + (float)Math.Sin(angle2 / 180.0 * Math.PI) * radius;
            i = ptx - x1;
            j = pty - y1;
            stu1.fXPos = x1;
            stu1.fYPos = y1;
            stu1.fX1Pos = x2;
            stu1.fY1Pos = y2;
            stu1.fIPos = i;
            stu1.fJPos = j;
            stu1.fRPos = radius;
            stu1.fptXPos = ptx;
            stu1.fptYPos = pty;
            stu1.fAngle1Pos = angle1;
            stu1.fAngle2Pos = angle2;

            
            stuArcArray.Add(stu1);


        }

        private void PolylineModule(StreamReader reader)
        {
            string line1, line2;
            line1 = "0";
            line2 = "0";

            float x1 = 0;
            float y1 = 0;
            float x2 = 0;
            float y2 = 0;
            int count = 0;
            int num = 1;
            DataPolyLineStruct stu1 = new DataPolyLineStruct();
            do
            {
                GetLineCouple(reader, out line1, out line2);

                if (line1 == "10")
                {
                    if (count <= 1)
                    {
                        x1 = (float)Convert.ToDouble(line2);
                    }
                    else
                    {
                        x2 = (float)Convert.ToDouble(line2);
                    }
                    

                }

                if (line1 == "20")
                {
                    if (count <= 1)
                    {
                        y1 = (float)Convert.ToDouble(line2);
                    } 
                    else
                    {
                        y2 = (float)Convert.ToDouble(line2);
                    }
                    

                }

                if (line1 == "0" && line2 == "VERTEX" )
                {
                    if (count > 1)
                    {
                        stu1.fX1Pos = x1;
                        stu1.fX2Pos = x2;
                        stu1.fY1Pos = y1;
                        stu1.fY2Pos = y2;
                        stu1.iNum = num;
                        stuPolyLineArray.Add(stu1);
                        x1 = x2;
                        y1 = y2;
                        num++;
                    }


                    count += 1;
                }

            }
            while (line2 != "SEQEND");

        }

        private void PaintBack()
        {
            Rectangle newRect = pictureBox1.DisplayRectangle;
            Bitmap bmp = new Bitmap(newRect.Width, newRect.Height);
            Graphics g = Graphics.FromImage(bmp);
            Graphics g1 = pictureBox1.CreateGraphics();
            SolidBrush mysbrush1 = new SolidBrush(Color.Black);
            g.FillRectangle(mysbrush1, newRect);
            Pen p = new Pen(Color.Blue, 2);
            Pen p1 = new Pen(Color.FromArgb(50, 50, 50), 1);
            PointF ptStart, ptEnd, ptRect, ptAngle, ptPt;
            float r, angle;
            RectangleF rect1 = new RectangleF();
            ptStart = new PointF();
            ptEnd = new PointF();
            ptRect = new PointF();
            ptAngle = new PointF();
            ptPt = new PointF();


            int n = 1;
            while (n * 40 < newRect.Height)
            {
                g.DrawLine(p1, 0, 40 * n, newRect.Width, 40 * n);
                n++;
            }
            n = 1;
            while (n * 40 < (newRect.Width))
            {
                g.DrawLine(p1, 40 * n, 0, 40 * n, newRect.Height);
                n++;
            }


            n = 0;

            for (int i = 0; i < stuLineArray.Count; i++)
            {
                ptStart.X = stuLineArray[i].fX1Pos;
                ptStart.Y = stuLineArray[i].fY1Pos;
                ptEnd.X = stuLineArray[i].fX2Pos;
                ptEnd.Y = stuLineArray[i].fY2Pos;
                ptStart.X = ptStart.X * m_fradio;
                ptStart.Y = ptStart.Y * m_fradio;
                ptEnd.X = ptEnd.X * m_fradio;
                ptEnd.Y = ptEnd.Y * m_fradio;

                ptStart.X = ptStart.X * m11 + ptStart.Y * m12 + m13;
                ptStart.Y = ptStart.X * m21 + ptStart.Y * m22 + m23;

                ptEnd.X = ptEnd.X * m11 + ptEnd.Y * m12 + m13;
                ptEnd.Y = ptEnd.X * m21 + ptEnd.Y * m22 + m23;

                g.DrawLine(p, ptStart, ptEnd);
            }

            for (int i = 0; i < stuPolyLineArray.Count; i++)
            {
                ptStart.X = stuPolyLineArray[i].fX1Pos;
                ptStart.Y = stuPolyLineArray[i].fY1Pos;
                ptEnd.X = stuPolyLineArray[i].fX2Pos;
                ptEnd.Y = stuPolyLineArray[i].fY2Pos;

                ptStart.X = ptStart.X * m_fradio;
                ptStart.Y = ptStart.Y * m_fradio;
                ptEnd.X = ptEnd.X * m_fradio;
                ptEnd.Y = ptEnd.Y * m_fradio;

                ptStart.X = ptStart.X * m11 + ptStart.Y * m12 + m13;
                ptStart.Y = ptStart.X * m21 + ptStart.Y * m22 + m23;

                ptEnd.X = ptEnd.X * m11 + ptEnd.Y * m12 + m13;
                ptEnd.Y = ptEnd.X * m21 + ptEnd.Y * m22 + m23;

                g.DrawLine(p, ptStart, ptEnd);
            }



            for (int i = 0; i < stuCircleArray.Count; i++)
            {
                r = stuCircleArray[i].fRPos * m_fradio;
                ptStart.X = stuCircleArray[i].fXPos;
                ptStart.Y = stuCircleArray[i].fYPos;
                ptStart.X = ptStart.X * m_fradio;
                ptStart.Y = ptStart.Y * m_fradio;
                ptStart.X = ptStart.X * m11 + ptStart.Y * m12 + m13;
                ptStart.Y = ptStart.X * m21 + ptStart.Y * m22 + m23;
                rect1.X = ptStart.X - r;
                rect1.Y = ptStart.Y - r;
                rect1.Width = 2 * r;
                rect1.Height = 2 * r;
                //                 rect1.X = stuCircleArray[i].fXPos - stuCircleArray[i].fRPos;
                //                 rect1.Y = stuCircleArray[i].fYPos - stuCircleArray[i].fRPos;
                //                 rect1.Height = 2 *  stuCircleArray[i].fRPos;
                //                 rect1.Width = 2 * stuCircleArray[i].fRPos;
                g.DrawEllipse(p, rect1);
            }

            for (int i = 0; i < stuArcArray.Count; i++)
            {
                RectangleF rect = new RectangleF();
                ptStart.X = stuArcArray[i].fXPos;
                ptStart.Y = stuArcArray[i].fYPos;
                ptEnd.X = stuArcArray[i].fX1Pos;
                ptEnd.Y = stuArcArray[i].fY1Pos;
                ptRect.X = stuArcArray[i].fIPos;
                ptRect.Y = stuArcArray[i].fJPos;
                ptPt.X = stuArcArray[i].fptXPos;
                ptPt.Y = stuArcArray[i].fptYPos;
                ptStart.X = ptStart.X * m_fradio;
                ptStart.Y = ptStart.Y * m_fradio;
                ptEnd.X = ptEnd.X * m_fradio;
                ptEnd.Y = ptEnd.Y * m_fradio;
                ptRect.X = ptRect.X * m_fradio;
                ptRect.Y = ptRect.Y * m_fradio;

                ptStart.X = ptStart.X * m11 + ptStart.Y * m12 + m13;
                ptStart.Y = ptStart.X * m21 + ptStart.Y * m22 + m23;

                ptEnd.X = ptEnd.X * m11 + ptEnd.Y * m12 + m13;
                ptEnd.Y = ptEnd.X * m21 + ptEnd.Y * m22 + m23;
                //                 r = stuArcArray[i].fRPos;
                //                 ptAngle.X = stuArcArray[i].fAngle1Pos;
                //                 ptAngle.Y = stuArcArray[i].fAngle2Pos;
                //                 rect.X = ptPt.X - r;
                //                 rect.Y = ptPt.Y - r;
                //                 rect.Width = 2 * r;
                //                 rect.Height = 2 * r;
                //                 ptAngle.X = (float)(Math.Atan2(Convert.ToDouble(ptStart.Y - ptPt.Y), Convert.ToDouble(ptStart.X - ptPt.X)) / Math.PI * 180);
                //                 ptAngle.Y = (float)(Math.Atan2(Convert.ToDouble(ptEnd.Y - ptPt.Y), Convert.ToDouble(ptEnd.X) - ptPt.X) / Math.PI * 180);
                r = (float)Math.Pow((ptRect.X * ptRect.X + ptRect.Y * ptRect.Y), 0.5);
                rect.X = ptStart.X + ptRect.X - r;
                rect.Y = ptStart.Y + ptRect.Y - r;
                rect.Height = 2 * r;
                rect.Width = 2 * r;

                ptAngle.X = (float)(Math.Atan2(Convert.ToDouble(-ptRect.Y), Convert.ToDouble(-ptRect.X)) / 3.14 * 180);
                ptAngle.Y = (float)(Math.Atan2(Convert.ToDouble(ptEnd.Y - ptRect.Y - ptStart.Y), Convert.ToDouble(ptEnd.X - ptRect.X - ptStart.X)) / 3.14 * 180);

                if (ptAngle.X < 0)
                {
                    ptAngle.X = 360 + ptAngle.X;
                }
                if (ptAngle.Y < 0)
                {
                    ptAngle.Y = 360 + ptAngle.Y;
                }
                angle = ptAngle.Y - ptAngle.X;
                if (angle < 0)
                {
                    angle += 360;
                }

                g.DrawArc(p, rect, ptAngle.X, angle);
            }


            Matrix M = new Matrix(1, 0, 0, -1, 0, 0);
            g1.Transform = M;
            g1.TranslateTransform(0, -newRect.Height);
            g1.DrawImage(bmp, 0, 0);

            M.Dispose();
            g.Dispose();
            g1.Dispose();
            mysbrush1.Dispose();
            p.Dispose();
            p1.Dispose();

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Focus();
        }
        public void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
                m_fradio -= 0.1f;
            else
                m_fradio += 0.1f;
            if (m_fradio >= 10)
                m_fradio = 10;
            if (m_fradio <= 0.1)
                m_fradio = 0.1f;

            PaintBack();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            xEnd = e.X;
            yEnd = e.Y;
            m13 += xEnd - xStrat;
            m23 += yStart - yEnd;
            PaintBack();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            xStrat = e.X;
            yStart = e.Y;
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        }

    
}
