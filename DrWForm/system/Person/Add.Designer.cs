namespace DrWForm.system.Person
{
    partial class Add
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
            this.panelER1 = new Dr.WForm.UI.RControl.TContainer.PanelER();
            this.panelER2 = new Dr.WForm.UI.RControl.TContainer.PanelER();
            this.buttonSave1 = new Dr.WForm.UI.RControl.button.ButtonSave();
            this.panelER1.SuspendLayout();
            this.panelER2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelER1
            // 
            this.panelER1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelER1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelER1.Controls.Add(this.panelER2);
            this.panelER1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelER1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelER1.Location = new System.Drawing.Point(0, 0);
            this.panelER1.Name = "panelER1";
            this.panelER1.Size = new System.Drawing.Size(828, 419);
            this.panelER1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelER1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelER1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelER1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelER1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelER1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelER1.Style.GradientAngle = 90;
            this.panelER1.TabIndex = 1;
            // 
            // panelER2
            // 
            this.panelER2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelER2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelER2.Controls.Add(this.buttonSave1);
            this.panelER2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelER2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelER2.Location = new System.Drawing.Point(0, 0);
            this.panelER2.Name = "panelER2";
            this.panelER2.Size = new System.Drawing.Size(828, 33);
            this.panelER2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelER2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelER2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelER2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelER2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelER2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelER2.Style.GradientAngle = 90;
            this.panelER2.TabIndex = 0;
            // 
            // buttonSave1
            // 
            this.buttonSave1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonSave1.ArgumentValue = "Save";
            this.buttonSave1.BackSaveWorker = null;
            this.buttonSave1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonSave1.ConfirmMessage = null;
            this.buttonSave1.DataSource = null;
            this.buttonSave1.Location = new System.Drawing.Point(669, 7);
            this.buttonSave1.Name = "buttonSave1";
            this.buttonSave1.Sign = "ForSave";
            this.buttonSave1.Size = new System.Drawing.Size(75, 23);
            this.buttonSave1.Sql = null;
            this.buttonSave1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonSave1.TabIndex = 0;
            this.buttonSave1.Text = "保存";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 419);
            this.Controls.Add(this.panelER1);
            this.DoubleBuffered = true;
            this.Name = "Add";
            this.Text = "Add";
            this.panelER1.ResumeLayout(false);
            this.panelER2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Dr.WForm.UI.RControl.TContainer.PanelER panelER1;
        private Dr.WForm.UI.RControl.TContainer.PanelER panelER2;
        private Dr.WForm.UI.RControl.button.ButtonSave buttonSave1;
    }
}