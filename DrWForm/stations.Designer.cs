﻿namespace DrWForm
{
    partial class stations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stations));
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.menu = new Dr.WForm.UI.RControl.Framework.MenuR();
            this.menuFresh = new DevComponents.DotNetBar.ButtonItem();
            this.rbtUserName = new DevComponents.DotNetBar.RibbonTabItem();
            this.lblTime = new DevComponents.DotNetBar.LabelItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabDeskTop = new DevComponents.DotNetBar.TabControl();
            this.pageDesk = new DevComponents.DotNetBar.TabControlPanel();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.deskTop1 = new Dr.WForm.UI.RControl.button.DeskTop();
            this.deskTopItem2 = new Dr.WForm.UI.RControl.button.DeskTopItem();
            this.deskTopItem1 = new Dr.WForm.UI.RControl.button.DeskTopItem();
            this.deskTopItem3 = new Dr.WForm.UI.RControl.button.DeskTopItem();
            this.deskTopItem4 = new Dr.WForm.UI.RControl.button.DeskTopItem();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdPassWord = new DevComponents.DotNetBar.ButtonX();
            this.tabItemDesk = new DevComponents.DotNetBar.TabItem(this.components);
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabDeskTop)).BeginInit();
            this.tabDeskTop.SuspendLayout();
            this.pageDesk.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.deskTop1.SuspendLayout();
            this.expandablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.rbtUserName,
            this.lblTime});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ribbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1});
            this.ribbonControl1.Size = new System.Drawing.Size(921, 84);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "";
            this.ribbonControl1.SystemText.QatAddItemText = "";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "";
            this.ribbonControl1.SystemText.QatCustomizeText = "";
            this.ribbonControl1.SystemText.QatDialogAddButton = "";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 3;
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.menu);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 0);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(921, 81);
            // 
            // 
            // 
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 2;
            // 
            // menu
            // 
            this.menu.AntiAlias = true;
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.DataSource = null;
            this.menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.menu.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.menu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.menuFresh});
            this.menu.Location = new System.Drawing.Point(3, 0);
            this.menu.Name = "menu";
            this.menu.PersonID = null;
            this.menu.Size = new System.Drawing.Size(915, 25);
            this.menu.Sql = "CS_spMenuLoadInfo";
            this.menu.Stretch = true;
            this.menu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.menu.TabIndex = 0;
            this.menu.TabStop = false;
            this.menu.Text = "menuR1";
            // 
            // menuFresh
            // 
            this.menuFresh.Icon = ((System.Drawing.Icon)(resources.GetObject("menuFresh.Icon")));
            this.menuFresh.Name = "menuFresh";
            this.menuFresh.Tooltip = "刷新菜单";
            // 
            // rbtUserName
            // 
            this.rbtUserName.Checked = true;
            this.rbtUserName.Name = "rbtUserName";
            this.rbtUserName.Text = "上午好:xxx";
            this.rbtUserName.Click += new System.EventHandler(this.rbtUserName_Click);
            // 
            // lblTime
            // 
            this.lblTime.Icon = ((System.Drawing.Icon)(resources.GetObject("lblTime.Icon")));
            this.lblTime.Name = "lblTime";
            this.lblTime.Text = "当前时间：";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            // 
            // timerDate
            // 
            this.timerDate.Tick += new System.EventHandler(this.timerDate_Tick);
            // 
            // tabItem1
            // 
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "管理桌面";
            // 
            // tabDeskTop
            // 
            this.tabDeskTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabDeskTop.CanReorderTabs = true;
            this.tabDeskTop.Controls.Add(this.pageDesk);
            this.tabDeskTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDeskTop.Location = new System.Drawing.Point(0, 84);
            this.tabDeskTop.Name = "tabDeskTop";
            this.tabDeskTop.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.tabDeskTop.SelectedTabIndex = 0;
            this.tabDeskTop.Size = new System.Drawing.Size(921, 419);
            this.tabDeskTop.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.tabDeskTop.TabIndex = 5;
            this.tabDeskTop.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabDeskTop.Tabs.Add(this.tabItemDesk);
            this.tabDeskTop.Text = "tabControl1";
            // 
            // pageDesk
            // 
            this.pageDesk.Controls.Add(this.panelEx1);
            this.pageDesk.DisabledBackColor = System.Drawing.Color.Empty;
            this.pageDesk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageDesk.Location = new System.Drawing.Point(0, 25);
            this.pageDesk.Name = "pageDesk";
            this.pageDesk.Padding = new System.Windows.Forms.Padding(1);
            this.pageDesk.Size = new System.Drawing.Size(921, 394);
            this.pageDesk.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.pageDesk.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.pageDesk.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pageDesk.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.pageDesk.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.pageDesk.Style.GradientAngle = 90;
            this.pageDesk.TabIndex = 1;
            this.pageDesk.TabItem = this.tabItemDesk;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.deskTop1);
            this.panelEx1.Controls.Add(this.expandablePanel1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(1, 1);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(919, 392);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // deskTop1
            // 
            this.deskTop1.AllowDrop = true;
            this.deskTop1.Controls.Add(this.deskTopItem2);
            this.deskTop1.Controls.Add(this.deskTopItem1);
            this.deskTop1.Controls.Add(this.deskTopItem3);
            this.deskTop1.Controls.Add(this.deskTopItem4);
            this.deskTop1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deskTop1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.deskTop1.Location = new System.Drawing.Point(200, 0);
            this.deskTop1.Name = "deskTop1";
            this.deskTop1.Padding = new System.Windows.Forms.Padding(3);
            this.deskTop1.Size = new System.Drawing.Size(719, 392);
            this.deskTop1.TabIndex = 1;
            // 
            // deskTopItem2
            // 
            this.deskTopItem2.BackColor = System.Drawing.Color.Transparent;
            this.deskTopItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deskTopItem2.FlatAppearance.BorderSize = 0;
            this.deskTopItem2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.deskTopItem2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.deskTopItem2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deskTopItem2.ForeColor = System.Drawing.Color.Black;
            this.deskTopItem2.Location = new System.Drawing.Point(6, 6);
            this.deskTopItem2.Name = "deskTopItem2";
            this.deskTopItem2.Padding = new System.Windows.Forms.Padding(2);
            this.deskTopItem2.Size = new System.Drawing.Size(87, 87);
            this.deskTopItem2.TabIndex = 1;
            this.deskTopItem2.Text = "deskTopItem2";
            this.deskTopItem2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deskTopItem2.UseVisualStyleBackColor = false;
            this.deskTopItem2.Click += new System.EventHandler(this.deskTopItem2_Click);
            // 
            // deskTopItem1
            // 
            this.deskTopItem1.BackColor = System.Drawing.Color.Transparent;
            this.deskTopItem1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deskTopItem1.BackgroundImage")));
            this.deskTopItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deskTopItem1.FlatAppearance.BorderSize = 0;
            this.deskTopItem1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.deskTopItem1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.deskTopItem1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deskTopItem1.ForeColor = System.Drawing.Color.Black;
            this.deskTopItem1.Location = new System.Drawing.Point(6, 99);
            this.deskTopItem1.Name = "deskTopItem1";
            this.deskTopItem1.Padding = new System.Windows.Forms.Padding(2);
            this.deskTopItem1.Size = new System.Drawing.Size(87, 87);
            this.deskTopItem1.TabIndex = 0;
            this.deskTopItem1.Text = "deskTopItem1";
            this.deskTopItem1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deskTopItem1.UseVisualStyleBackColor = false;
            // 
            // deskTopItem3
            // 
            this.deskTopItem3.BackColor = System.Drawing.Color.Transparent;
            this.deskTopItem3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deskTopItem3.FlatAppearance.BorderSize = 0;
            this.deskTopItem3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.deskTopItem3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.deskTopItem3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deskTopItem3.ForeColor = System.Drawing.Color.Black;
            this.deskTopItem3.Location = new System.Drawing.Point(6, 192);
            this.deskTopItem3.Name = "deskTopItem3";
            this.deskTopItem3.Padding = new System.Windows.Forms.Padding(2);
            this.deskTopItem3.Size = new System.Drawing.Size(87, 87);
            this.deskTopItem3.TabIndex = 2;
            this.deskTopItem3.Text = "deskTopItem3";
            this.deskTopItem3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deskTopItem3.UseVisualStyleBackColor = false;
            // 
            // deskTopItem4
            // 
            this.deskTopItem4.BackColor = System.Drawing.Color.Transparent;
            this.deskTopItem4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deskTopItem4.FlatAppearance.BorderSize = 0;
            this.deskTopItem4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.deskTopItem4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.deskTopItem4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deskTopItem4.ForeColor = System.Drawing.Color.Black;
            this.deskTopItem4.Location = new System.Drawing.Point(6, 285);
            this.deskTopItem4.Name = "deskTopItem4";
            this.deskTopItem4.Padding = new System.Windows.Forms.Padding(2);
            this.deskTopItem4.Size = new System.Drawing.Size(87, 87);
            this.deskTopItem4.TabIndex = 3;
            this.deskTopItem4.Text = "deskTopItem4";
            this.deskTopItem4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deskTopItem4.UseVisualStyleBackColor = false;
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel1.Controls.Add(this.buttonX1);
            this.expandablePanel1.Controls.Add(this.btnExit);
            this.expandablePanel1.Controls.Add(this.buttonX2);
            this.expandablePanel1.Controls.Add(this.btnUpdPassWord);
            this.expandablePanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.expandablePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.expandablePanel1.HideControlsWhenCollapsed = true;
            this.expandablePanel1.Location = new System.Drawing.Point(0, 0);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(200, 392);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 0;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "我的快捷";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonX1.Location = new System.Drawing.Point(0, 167);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(200, 47);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 3;
            this.buttonX1.Text = "数据报表";
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.Location = new System.Drawing.Point(0, 120);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 47);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "退出系统";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonX2.Location = new System.Drawing.Point(0, 73);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(200, 47);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 2;
            this.buttonX2.Text = "实时路径";
            // 
            // btnUpdPassWord
            // 
            this.btnUpdPassWord.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdPassWord.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdPassWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdPassWord.Location = new System.Drawing.Point(0, 26);
            this.btnUpdPassWord.Name = "btnUpdPassWord";
            this.btnUpdPassWord.Size = new System.Drawing.Size(200, 47);
            this.btnUpdPassWord.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdPassWord.TabIndex = 1;
            this.btnUpdPassWord.Text = "站点管理";
            // 
            // tabItemDesk
            // 
            this.tabItemDesk.AttachedControl = this.pageDesk;
            this.tabItemDesk.Name = "tabItemDesk";
            this.tabItemDesk.Text = "桌面管理";
            // 
            // stations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(921, 503);
            this.Controls.Add(this.tabDeskTop);
            this.Controls.Add(this.ribbonControl1);
            this.DoubleBuffered = true;
            this.EnableGlass = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "stations";
            this.Text = "AGV系统概览";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabDeskTop)).EndInit();
            this.tabDeskTop.ResumeLayout(false);
            this.pageDesk.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.deskTop1.ResumeLayout(false);
            this.expandablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonTabItem rbtUserName;
        private DevComponents.DotNetBar.LabelItem lblTime;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private Dr.WForm.UI.RControl.Framework.MenuR menu;
        private DevComponents.DotNetBar.ButtonItem menuFresh;
        private System.Windows.Forms.Timer timerDate;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.TabControl tabDeskTop;
        private DevComponents.DotNetBar.TabControlPanel pageDesk;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private Dr.WForm.UI.RControl.button.DeskTop deskTop1;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX btnUpdPassWord;
        private DevComponents.DotNetBar.TabItem tabItemDesk;
        private Dr.WForm.UI.RControl.button.DeskTopItem deskTopItem1;
        private Dr.WForm.UI.RControl.button.DeskTopItem deskTopItem2;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private Dr.WForm.UI.RControl.button.DeskTopItem deskTopItem3;
        private Dr.WForm.UI.RControl.button.DeskTopItem deskTopItem4;
        private DevComponents.DotNetBar.ButtonX buttonX1;

    }
}