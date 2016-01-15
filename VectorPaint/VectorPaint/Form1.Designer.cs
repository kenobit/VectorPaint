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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.Save_ = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Color_btn = new System.Windows.Forms.ToolStripButton();
            this.LeftPanel_pan = new System.Windows.Forms.Panel();
            this.Type_pan = new System.Windows.Forms.Panel();
            this.Width_pan = new System.Windows.Forms.Panel();
            this.Figures_pan = new System.Windows.Forms.Panel();
            this.FigureCheck_radioRegion = new System.Windows.Forms.GroupBox();
            this.radioCurve = new System.Windows.Forms.RadioButton();
            this.radioLine = new System.Windows.Forms.RadioButton();
            this.radioRoundRect = new System.Windows.Forms.RadioButton();
            this.radioEllipse = new System.Windows.Forms.RadioButton();
            this.radioRectangle = new System.Windows.Forms.RadioButton();
            this.Color_pan = new System.Windows.Forms.Panel();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Tabs_tc = new System.Windows.Forms.TabControl();
            this.AddTab = new System.Windows.Forms.Button();
            this.FigureContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.figureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roundRectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widthToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Width_lb = new System.Windows.Forms.Label();
            this.Width_tb = new System.Windows.Forms.TextBox();
            this.MenuBar.SuspendLayout();
            this.ToolBar.SuspendLayout();
            this.LeftPanel_pan.SuspendLayout();
            this.Width_pan.SuspendLayout();
            this.Figures_pan.SuspendLayout();
            this.FigureCheck_radioRegion.SuspendLayout();
            this.Tabs_tc.SuspendLayout();
            this.FigureContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.typeToolStripMenuItem,
            this.tabsToolStripMenuItem,
            this.widthToolStripMenuItem,
            this.tabsToolStripMenuItem1});
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
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.Color_pan_Click);
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
            // tabsToolStripMenuItem1
            // 
            this.tabsToolStripMenuItem1.Name = "tabsToolStripMenuItem1";
            this.tabsToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.tabsToolStripMenuItem1.Text = "Tabs";
            // 
            // ToolBar
            // 
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save_,
            this.toolStripButton1,
            this.Color_btn});
            this.ToolBar.Location = new System.Drawing.Point(0, 24);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(995, 25);
            this.ToolBar.TabIndex = 1;
            this.ToolBar.Text = "toolStrip1";
            // 
            // Save_
            // 
            this.Save_.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Save_.Image = ((System.Drawing.Image)(resources.GetObject("Save_.Image")));
            this.Save_.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save_.Name = "Save_";
            this.Save_.Size = new System.Drawing.Size(35, 22);
            this.Save_.Text = "Save";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(37, 22);
            this.toolStripButton1.Text = "Load";
            // 
            // Color_btn
            // 
            this.Color_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Color_btn.Image = ((System.Drawing.Image)(resources.GetObject("Color_btn.Image")));
            this.Color_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Color_btn.Name = "Color_btn";
            this.Color_btn.Size = new System.Drawing.Size(40, 22);
            this.Color_btn.Text = "Color";
            this.Color_btn.Click += new System.EventHandler(this.Color_pan_Click);
            // 
            // LeftPanel_pan
            // 
            this.LeftPanel_pan.Controls.Add(this.Type_pan);
            this.LeftPanel_pan.Controls.Add(this.Width_pan);
            this.LeftPanel_pan.Controls.Add(this.Figures_pan);
            this.LeftPanel_pan.Controls.Add(this.Color_pan);
            this.LeftPanel_pan.Location = new System.Drawing.Point(4, 67);
            this.LeftPanel_pan.Name = "LeftPanel_pan";
            this.LeftPanel_pan.Size = new System.Drawing.Size(258, 618);
            this.LeftPanel_pan.TabIndex = 2;
            // 
            // Type_pan
            // 
            this.Type_pan.BackColor = System.Drawing.Color.White;
            this.Type_pan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Type_pan.Location = new System.Drawing.Point(4, 375);
            this.Type_pan.Name = "Type_pan";
            this.Type_pan.Size = new System.Drawing.Size(250, 239);
            this.Type_pan.TabIndex = 2;
            // 
            // Width_pan
            // 
            this.Width_pan.BackColor = System.Drawing.Color.White;
            this.Width_pan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Width_pan.Controls.Add(this.Width_tb);
            this.Width_pan.Controls.Add(this.Width_lb);
            this.Width_pan.Location = new System.Drawing.Point(4, 219);
            this.Width_pan.Name = "Width_pan";
            this.Width_pan.Size = new System.Drawing.Size(250, 150);
            this.Width_pan.TabIndex = 1;
            // 
            // Figures_pan
            // 
            this.Figures_pan.BackColor = System.Drawing.Color.White;
            this.Figures_pan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Figures_pan.Controls.Add(this.FigureCheck_radioRegion);
            this.Figures_pan.Location = new System.Drawing.Point(4, 63);
            this.Figures_pan.Name = "Figures_pan";
            this.Figures_pan.Size = new System.Drawing.Size(250, 150);
            this.Figures_pan.TabIndex = 1;
            // 
            // FigureCheck_radioRegion
            // 
            this.FigureCheck_radioRegion.Controls.Add(this.radioCurve);
            this.FigureCheck_radioRegion.Controls.Add(this.radioLine);
            this.FigureCheck_radioRegion.Controls.Add(this.radioRoundRect);
            this.FigureCheck_radioRegion.Controls.Add(this.radioEllipse);
            this.FigureCheck_radioRegion.Controls.Add(this.radioRectangle);
            this.FigureCheck_radioRegion.Location = new System.Drawing.Point(-1, 3);
            this.FigureCheck_radioRegion.Name = "FigureCheck_radioRegion";
            this.FigureCheck_radioRegion.Size = new System.Drawing.Size(250, 146);
            this.FigureCheck_radioRegion.TabIndex = 0;
            this.FigureCheck_radioRegion.TabStop = false;
            this.FigureCheck_radioRegion.Text = "Figures";
            // 
            // radioCurve
            // 
            this.radioCurve.AutoSize = true;
            this.radioCurve.Enabled = false;
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
            this.radioLine.Enabled = false;
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
            this.radioRoundRect.Enabled = false;
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
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(931, 50);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(59, 20);
            this.Clear_btn.TabIndex = 4;
            this.Clear_btn.Text = "Clear tab";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.tabPage1.Location = new System.Drawing.Point(4, 19);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(726, 610);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tab #1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabPage_MouseDown);
            this.tabPage1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tabPage_MouseMove);
            this.tabPage1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tabPage_MouseUp);
            // 
            // Tabs_tc
            // 
            this.Tabs_tc.Controls.Add(this.tabPage1);
            this.Tabs_tc.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Tabs_tc.ItemSize = new System.Drawing.Size(100, 15);
            this.Tabs_tc.Location = new System.Drawing.Point(260, 52);
            this.Tabs_tc.Multiline = true;
            this.Tabs_tc.Name = "Tabs_tc";
            this.Tabs_tc.SelectedIndex = 0;
            this.Tabs_tc.Size = new System.Drawing.Size(734, 633);
            this.Tabs_tc.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Tabs_tc.TabIndex = 3;
            // 
            // AddTab
            // 
            this.AddTab.Location = new System.Drawing.Point(911, 50);
            this.AddTab.Name = "AddTab";
            this.AddTab.Size = new System.Drawing.Size(20, 20);
            this.AddTab.TabIndex = 5;
            this.AddTab.Text = "+";
            this.AddTab.UseVisualStyleBackColor = true;
            this.AddTab.Click += new System.EventHandler(this.AddTab_btn_Click);
            // 
            // FigureContextMenu
            // 
            this.FigureContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figureToolStripMenuItem,
            this.widthToolStripMenuItem1,
            this.colorToolStripMenuItem1});
            this.FigureContextMenu.Name = "contextMenuStrip1";
            this.FigureContextMenu.Size = new System.Drawing.Size(108, 70);
            this.FigureContextMenu.UseWaitCursor = true;
            // 
            // figureToolStripMenuItem
            // 
            this.figureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangleToolStripMenuItem,
            this.ellipseToolStripMenuItem,
            this.roundRectToolStripMenuItem,
            this.lineToolStripMenuItem,
            this.curveToolStripMenuItem});
            this.figureToolStripMenuItem.Name = "figureToolStripMenuItem";
            this.figureToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.figureToolStripMenuItem.Text = "Figure";
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            // 
            // ellipseToolStripMenuItem
            // 
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.ellipseToolStripMenuItem.Text = "Ellipse";
            // 
            // roundRectToolStripMenuItem
            // 
            this.roundRectToolStripMenuItem.Enabled = false;
            this.roundRectToolStripMenuItem.Name = "roundRectToolStripMenuItem";
            this.roundRectToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.roundRectToolStripMenuItem.Text = "RoundRect";
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Enabled = false;
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.lineToolStripMenuItem.Text = "Line";
            // 
            // curveToolStripMenuItem
            // 
            this.curveToolStripMenuItem.Enabled = false;
            this.curveToolStripMenuItem.Name = "curveToolStripMenuItem";
            this.curveToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.curveToolStripMenuItem.Text = "Curve";
            // 
            // widthToolStripMenuItem1
            // 
            this.widthToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pxToolStripMenuItem,
            this.pxToolStripMenuItem1,
            this.pxToolStripMenuItem2,
            this.pxToolStripMenuItem3,
            this.pxToolStripMenuItem4});
            this.widthToolStripMenuItem1.Name = "widthToolStripMenuItem1";
            this.widthToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.widthToolStripMenuItem1.Text = "Width";
            // 
            // pxToolStripMenuItem
            // 
            this.pxToolStripMenuItem.Name = "pxToolStripMenuItem";
            this.pxToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.pxToolStripMenuItem.Text = "1px";
            // 
            // pxToolStripMenuItem1
            // 
            this.pxToolStripMenuItem1.Name = "pxToolStripMenuItem1";
            this.pxToolStripMenuItem1.Size = new System.Drawing.Size(92, 22);
            this.pxToolStripMenuItem1.Text = "2px";
            // 
            // pxToolStripMenuItem2
            // 
            this.pxToolStripMenuItem2.Name = "pxToolStripMenuItem2";
            this.pxToolStripMenuItem2.Size = new System.Drawing.Size(92, 22);
            this.pxToolStripMenuItem2.Text = "3px";
            // 
            // pxToolStripMenuItem3
            // 
            this.pxToolStripMenuItem3.Name = "pxToolStripMenuItem3";
            this.pxToolStripMenuItem3.Size = new System.Drawing.Size(92, 22);
            this.pxToolStripMenuItem3.Text = "4px";
            // 
            // pxToolStripMenuItem4
            // 
            this.pxToolStripMenuItem4.Name = "pxToolStripMenuItem4";
            this.pxToolStripMenuItem4.Size = new System.Drawing.Size(92, 22);
            this.pxToolStripMenuItem4.Text = "5px";
            // 
            // colorToolStripMenuItem1
            // 
            this.colorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blackToolStripMenuItem,
            this.yellowToolStripMenuItem});
            this.colorToolStripMenuItem1.Name = "colorToolStripMenuItem1";
            this.colorToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.colorToolStripMenuItem1.Text = "Color";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.redToolStripMenuItem.Text = "Red";
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.greenToolStripMenuItem.Text = "Green";
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.blackToolStripMenuItem.Text = "Black";
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.yellowToolStripMenuItem.Text = "Yellow";
            // 
            // Width_lb
            // 
            this.Width_lb.AutoSize = true;
            this.Width_lb.Location = new System.Drawing.Point(15, 12);
            this.Width_lb.Name = "Width_lb";
            this.Width_lb.Size = new System.Drawing.Size(35, 13);
            this.Width_lb.TabIndex = 1;
            this.Width_lb.Text = "Width";
            // 
            // Width_tb
            // 
            this.Width_tb.Location = new System.Drawing.Point(118, 12);
            this.Width_tb.Name = "Width_tb";
            this.Width_tb.Size = new System.Drawing.Size(100, 20);
            this.Width_tb.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 689);
            this.Controls.Add(this.AddTab);
            this.Controls.Add(this.Clear_btn);
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
            this.Width_pan.ResumeLayout(false);
            this.Width_pan.PerformLayout();
            this.Figures_pan.ResumeLayout(false);
            this.FigureCheck_radioRegion.ResumeLayout(false);
            this.FigureCheck_radioRegion.PerformLayout();
            this.Tabs_tc.ResumeLayout(false);
            this.FigureContextMenu.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabsToolStripMenuItem;
        private System.Windows.Forms.Panel Type_pan;
        private System.Windows.Forms.ToolStripMenuItem widthToolStripMenuItem;
        private System.Windows.Forms.GroupBox FigureCheck_radioRegion;
        private System.Windows.Forms.RadioButton radioCurve;
        private System.Windows.Forms.RadioButton radioLine;
        private System.Windows.Forms.RadioButton radioRoundRect;
        private System.Windows.Forms.RadioButton radioEllipse;
        private System.Windows.Forms.RadioButton radioRectangle;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.ToolStripButton Save_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl Tabs_tc;
        private System.Windows.Forms.Button AddTab;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton Color_btn;
        private System.Windows.Forms.ToolStripMenuItem tabsToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip FigureContextMenu;
        private System.Windows.Forms.ToolStripMenuItem figureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roundRectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widthToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.TextBox Width_tb;
        private System.Windows.Forms.Label Width_lb;
    }
}

