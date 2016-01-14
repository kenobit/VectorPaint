namespace VectorPaint
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.Save_ = new System.Windows.Forms.ToolStripButton();
            this.LeftPanel_pan = new System.Windows.Forms.Panel();
            this.Type_pan = new System.Windows.Forms.Panel();
            this.Width_pan = new System.Windows.Forms.Panel();
            this.Figures_pan = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCurve = new System.Windows.Forms.RadioButton();
            this.radioLine = new System.Windows.Forms.RadioButton();
            this.radioRoundRect = new System.Windows.Forms.RadioButton();
            this.radioEllipse = new System.Windows.Forms.RadioButton();
            this.radioRectangle = new System.Windows.Forms.RadioButton();
            this.Color_pan = new System.Windows.Forms.Panel();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Tabs_tc = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuBar.SuspendLayout();
            this.ToolBar.SuspendLayout();
            this.LeftPanel_pan.SuspendLayout();
            this.Figures_pan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Tabs_tc.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.positionToolStripMenuItem,
            this.typeToolStripMenuItem,
            this.tabsToolStripMenuItem,
            this.widthToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(995, 24);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // positionToolStripMenuItem
            // 
            this.positionToolStripMenuItem.Name = "positionToolStripMenuItem";
            this.positionToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.positionToolStripMenuItem.Text = "Position";
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.typeToolStripMenuItem.Text = "Type";
            // 
            // tabsToolStripMenuItem
            // 
            this.tabsToolStripMenuItem.Name = "tabsToolStripMenuItem";
            this.tabsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.tabsToolStripMenuItem.Text = "Tabs";
            // 
            // widthToolStripMenuItem
            // 
            this.widthToolStripMenuItem.Name = "widthToolStripMenuItem";
            this.widthToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.widthToolStripMenuItem.Text = "Width";
            // 
            // ToolBar
            // 
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save_});
            this.ToolBar.Location = new System.Drawing.Point(0, 24);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(995, 25);
            this.ToolBar.TabIndex = 1;
            this.ToolBar.Text = "toolStrip1";
            // 
            // Save_
            // 
            this.Save_.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save_.Image = ((System.Drawing.Image)(resources.GetObject("Save_.Image")));
            this.Save_.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save_.Name = "Save_";
            this.Save_.Size = new System.Drawing.Size(23, 22);
            this.Save_.Text = "Save";
            // 
            // LeftPanel_pan
            // 
            this.LeftPanel_pan.Controls.Add(this.Type_pan);
            this.LeftPanel_pan.Controls.Add(this.Width_pan);
            this.LeftPanel_pan.Controls.Add(this.Figures_pan);
            this.LeftPanel_pan.Controls.Add(this.Color_pan);
            this.LeftPanel_pan.Location = new System.Drawing.Point(4, 67);
            this.LeftPanel_pan.Name = "LeftPanel_pan";
            this.LeftPanel_pan.Size = new System.Drawing.Size(258, 628);
            this.LeftPanel_pan.TabIndex = 2;
            // 
            // Type_pan
            // 
            this.Type_pan.BackColor = System.Drawing.Color.White;
            this.Type_pan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Type_pan.Location = new System.Drawing.Point(4, 465);
            this.Type_pan.Name = "Type_pan";
            this.Type_pan.Size = new System.Drawing.Size(250, 150);
            this.Type_pan.TabIndex = 2;
            // 
            // Width_pan
            // 
            this.Width_pan.BackColor = System.Drawing.Color.White;
            this.Width_pan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Width_pan.Location = new System.Drawing.Point(4, 313);
            this.Width_pan.Name = "Width_pan";
            this.Width_pan.Size = new System.Drawing.Size(250, 150);
            this.Width_pan.TabIndex = 1;
            // 
            // Figures_pan
            // 
            this.Figures_pan.BackColor = System.Drawing.Color.White;
            this.Figures_pan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Figures_pan.Controls.Add(this.groupBox1);
            this.Figures_pan.Location = new System.Drawing.Point(4, 63);
            this.Figures_pan.Name = "Figures_pan";
            this.Figures_pan.Size = new System.Drawing.Size(250, 150);
            this.Figures_pan.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCurve);
            this.groupBox1.Controls.Add(this.radioLine);
            this.groupBox1.Controls.Add(this.radioRoundRect);
            this.groupBox1.Controls.Add(this.radioEllipse);
            this.groupBox1.Controls.Add(this.radioRectangle);
            this.groupBox1.Location = new System.Drawing.Point(-1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Figures";
            // 
            // radioCurve
            // 
            this.radioCurve.AutoSize = true;
            this.radioCurve.Location = new System.Drawing.Point(5, 116);
            this.radioCurve.Name = "radioCurve";
            this.radioCurve.Size = new System.Drawing.Size(53, 17);
            this.radioCurve.TabIndex = 4;
            this.radioCurve.Text = "Curve";
            this.radioCurve.UseVisualStyleBackColor = true;
            // 
            // radioLine
            // 
            this.radioLine.AutoSize = true;
            this.radioLine.Location = new System.Drawing.Point(7, 92);
            this.radioLine.Name = "radioLine";
            this.radioLine.Size = new System.Drawing.Size(45, 17);
            this.radioLine.TabIndex = 3;
            this.radioLine.Text = "Line";
            this.radioLine.UseVisualStyleBackColor = true;
            // 
            // radioRoundRect
            // 
            this.radioRoundRect.AutoSize = true;
            this.radioRoundRect.Location = new System.Drawing.Point(7, 68);
            this.radioRoundRect.Name = "radioRoundRect";
            this.radioRoundRect.Size = new System.Drawing.Size(80, 17);
            this.radioRoundRect.TabIndex = 2;
            this.radioRoundRect.Text = "RoundRect";
            this.radioRoundRect.UseVisualStyleBackColor = true;
            // 
            // radioEllipse
            // 
            this.radioEllipse.AutoSize = true;
            this.radioEllipse.Location = new System.Drawing.Point(7, 44);
            this.radioEllipse.Name = "radioEllipse";
            this.radioEllipse.Size = new System.Drawing.Size(55, 17);
            this.radioEllipse.TabIndex = 1;
            this.radioEllipse.Text = "Ellipse";
            this.radioEllipse.UseVisualStyleBackColor = true;
            // 
            // radioRectangle
            // 
            this.radioRectangle.AutoSize = true;
            this.radioRectangle.Checked = true;
            this.radioRectangle.Location = new System.Drawing.Point(7, 20);
            this.radioRectangle.Name = "radioRectangle";
            this.radioRectangle.Size = new System.Drawing.Size(74, 17);
            this.radioRectangle.TabIndex = 0;
            this.radioRectangle.TabStop = true;
            this.radioRectangle.Text = "Rectangle";
            this.radioRectangle.UseVisualStyleBackColor = true;
            // 
            // Color_pan
            // 
            this.Color_pan.BackColor = System.Drawing.Color.Black;
            this.Color_pan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Color_pan.Location = new System.Drawing.Point(4, 7);
            this.Color_pan.Name = "Color_pan";
            this.Color_pan.Size = new System.Drawing.Size(250, 50);
            this.Color_pan.TabIndex = 0;
            this.Color_pan.Click += new System.EventHandler(this.Color_pan_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(726, 607);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(726, 607);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabPage1_MouseClick);
            // 
            // Tabs_tc
            // 
            this.Tabs_tc.Controls.Add(this.tabPage1);
            this.Tabs_tc.Controls.Add(this.tabPage2);
            this.Tabs_tc.Location = new System.Drawing.Point(260, 52);
            this.Tabs_tc.Name = "Tabs_tc";
            this.Tabs_tc.SelectedIndex = 0;
            this.Tabs_tc.Size = new System.Drawing.Size(734, 633);
            this.Tabs_tc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COLOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 689);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tabs_tc);
            this.Controls.Add(this.LeftPanel_pan);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.MenuBar);
            this.MainMenuStrip = this.MenuBar;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vector paint";
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.LeftPanel_pan.ResumeLayout(false);
            this.Figures_pan.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Tabs_tc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.Panel LeftPanel_pan;
        private System.Windows.Forms.Panel Width_pan;
        private System.Windows.Forms.Panel Figures_pan;
        private System.Windows.Forms.Panel Color_pan;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem positionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabsToolStripMenuItem;
        private System.Windows.Forms.Panel Type_pan;
        private System.Windows.Forms.ToolStripMenuItem widthToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioCurve;
        private System.Windows.Forms.RadioButton radioLine;
        private System.Windows.Forms.RadioButton radioRoundRect;
        private System.Windows.Forms.RadioButton radioEllipse;
        private System.Windows.Forms.RadioButton radioRectangle;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.ToolStripButton Save_;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl Tabs_tc;
        private System.Windows.Forms.Label label1;
    }
}

