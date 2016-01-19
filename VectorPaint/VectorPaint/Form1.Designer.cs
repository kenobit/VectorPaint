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
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.roundRectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.curveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.Save_ = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Color_btn = new System.Windows.Forms.ToolStripButton();
            this.LeftPanel_pan = new System.Windows.Forms.Panel();
            this.Type_pan = new System.Windows.Forms.Panel();
            this.Width_pan = new System.Windows.Forms.Panel();
            this.SizeY_tb = new System.Windows.Forms.TextBox();
            this.SizeY_lb = new System.Windows.Forms.Label();
            this.SizeX_tb = new System.Windows.Forms.TextBox();
            this.SizeX_lb = new System.Windows.Forms.Label();
            this.PointY_tb = new System.Windows.Forms.TextBox();
            this.PointY_lb = new System.Windows.Forms.Label();
            this.PointX_tb = new System.Windows.Forms.TextBox();
            this.PointX_lb = new System.Windows.Forms.Label();
            this.Width_tb = new System.Windows.Forms.TextBox();
            this.Width_lb = new System.Windows.Forms.Label();
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
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
            resources.ApplyResources(this.MenuBar, "MenuBar");
            this.MenuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.typeToolStripMenuItem,
            this.tabsToolStripMenuItem,
            this.widthToolStripMenuItem});
            this.MenuBar.Name = "MenuBar";
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // saveToolStripMenuItem
            // 
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // loadToolStripMenuItem
            // 
            resources.ApplyResources(this.loadToolStripMenuItem, "loadToolStripMenuItem");
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // settingsToolStripMenuItem
            // 
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            resources.ApplyResources(this.colorToolStripMenuItem, "colorToolStripMenuItem");
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.Color_pan_Click);
            // 
            // typeToolStripMenuItem
            // 
            resources.ApplyResources(this.typeToolStripMenuItem, "typeToolStripMenuItem");
            this.typeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangleToolStripMenuItem1,
            this.ellipseToolStripMenuItem1,
            this.roundRectToolStripMenuItem1,
            this.lineToolStripMenuItem1,
            this.curveToolStripMenuItem1});
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            // 
            // rectangleToolStripMenuItem1
            // 
            resources.ApplyResources(this.rectangleToolStripMenuItem1, "rectangleToolStripMenuItem1");
            this.rectangleToolStripMenuItem1.Name = "rectangleToolStripMenuItem1";
            // 
            // ellipseToolStripMenuItem1
            // 
            resources.ApplyResources(this.ellipseToolStripMenuItem1, "ellipseToolStripMenuItem1");
            this.ellipseToolStripMenuItem1.Name = "ellipseToolStripMenuItem1";
            // 
            // roundRectToolStripMenuItem1
            // 
            resources.ApplyResources(this.roundRectToolStripMenuItem1, "roundRectToolStripMenuItem1");
            this.roundRectToolStripMenuItem1.Name = "roundRectToolStripMenuItem1";
            // 
            // lineToolStripMenuItem1
            // 
            resources.ApplyResources(this.lineToolStripMenuItem1, "lineToolStripMenuItem1");
            this.lineToolStripMenuItem1.Name = "lineToolStripMenuItem1";
            // 
            // curveToolStripMenuItem1
            // 
            resources.ApplyResources(this.curveToolStripMenuItem1, "curveToolStripMenuItem1");
            this.curveToolStripMenuItem1.Name = "curveToolStripMenuItem1";
            // 
            // tabsToolStripMenuItem
            // 
            resources.ApplyResources(this.tabsToolStripMenuItem, "tabsToolStripMenuItem");
            this.tabsToolStripMenuItem.Name = "tabsToolStripMenuItem";
            this.tabsToolStripMenuItem.Click += new System.EventHandler(this.tabsToolStripMenuItem_Click);
            // 
            // widthToolStripMenuItem
            // 
            resources.ApplyResources(this.widthToolStripMenuItem, "widthToolStripMenuItem");
            this.widthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.widthToolStripMenuItem.Name = "widthToolStripMenuItem";
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            // 
            // toolStripMenuItem4
            // 
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            // 
            // toolStripMenuItem5
            // 
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            // 
            // toolStripMenuItem6
            // 
            resources.ApplyResources(this.toolStripMenuItem6, "toolStripMenuItem6");
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            // 
            // ToolBar
            // 
            resources.ApplyResources(this.ToolBar, "ToolBar");
            this.ToolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save_,
            this.toolStripButton1,
            this.Color_btn});
            this.ToolBar.Name = "ToolBar";
            // 
            // Save_
            // 
            resources.ApplyResources(this.Save_, "Save_");
            this.Save_.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Save_.Name = "Save_";
            this.Save_.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // toolStripButton1
            // 
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // Color_btn
            // 
            resources.ApplyResources(this.Color_btn, "Color_btn");
            this.Color_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Color_btn.Name = "Color_btn";
            this.Color_btn.Click += new System.EventHandler(this.Color_pan_Click);
            // 
            // LeftPanel_pan
            // 
            resources.ApplyResources(this.LeftPanel_pan, "LeftPanel_pan");
            this.LeftPanel_pan.Controls.Add(this.Type_pan);
            this.LeftPanel_pan.Controls.Add(this.Width_pan);
            this.LeftPanel_pan.Controls.Add(this.Figures_pan);
            this.LeftPanel_pan.Controls.Add(this.Color_pan);
            this.LeftPanel_pan.Name = "LeftPanel_pan";
            // 
            // Type_pan
            // 
            resources.ApplyResources(this.Type_pan, "Type_pan");
            this.Type_pan.BackColor = System.Drawing.Color.White;
            this.Type_pan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Type_pan.Name = "Type_pan";
            // 
            // Width_pan
            // 
            resources.ApplyResources(this.Width_pan, "Width_pan");
            this.Width_pan.BackColor = System.Drawing.Color.White;
            this.Width_pan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Width_pan.Controls.Add(this.SizeY_tb);
            this.Width_pan.Controls.Add(this.SizeY_lb);
            this.Width_pan.Controls.Add(this.SizeX_tb);
            this.Width_pan.Controls.Add(this.SizeX_lb);
            this.Width_pan.Controls.Add(this.PointY_tb);
            this.Width_pan.Controls.Add(this.PointY_lb);
            this.Width_pan.Controls.Add(this.PointX_tb);
            this.Width_pan.Controls.Add(this.PointX_lb);
            this.Width_pan.Controls.Add(this.Width_tb);
            this.Width_pan.Controls.Add(this.Width_lb);
            this.Width_pan.Name = "Width_pan";
            // 
            // SizeY_tb
            // 
            resources.ApplyResources(this.SizeY_tb, "SizeY_tb");
            this.SizeY_tb.Name = "SizeY_tb";
            // 
            // SizeY_lb
            // 
            resources.ApplyResources(this.SizeY_lb, "SizeY_lb");
            this.SizeY_lb.Name = "SizeY_lb";
            // 
            // SizeX_tb
            // 
            resources.ApplyResources(this.SizeX_tb, "SizeX_tb");
            this.SizeX_tb.Name = "SizeX_tb";
            // 
            // SizeX_lb
            // 
            resources.ApplyResources(this.SizeX_lb, "SizeX_lb");
            this.SizeX_lb.Name = "SizeX_lb";
            // 
            // PointY_tb
            // 
            resources.ApplyResources(this.PointY_tb, "PointY_tb");
            this.PointY_tb.Name = "PointY_tb";
            // 
            // PointY_lb
            // 
            resources.ApplyResources(this.PointY_lb, "PointY_lb");
            this.PointY_lb.Name = "PointY_lb";
            // 
            // PointX_tb
            // 
            resources.ApplyResources(this.PointX_tb, "PointX_tb");
            this.PointX_tb.Name = "PointX_tb";
            // 
            // PointX_lb
            // 
            resources.ApplyResources(this.PointX_lb, "PointX_lb");
            this.PointX_lb.Name = "PointX_lb";
            // 
            // Width_tb
            // 
            resources.ApplyResources(this.Width_tb, "Width_tb");
            this.Width_tb.Name = "Width_tb";
            // 
            // Width_lb
            // 
            resources.ApplyResources(this.Width_lb, "Width_lb");
            this.Width_lb.Name = "Width_lb";
            // 
            // Figures_pan
            // 
            resources.ApplyResources(this.Figures_pan, "Figures_pan");
            this.Figures_pan.BackColor = System.Drawing.Color.White;
            this.Figures_pan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Figures_pan.Controls.Add(this.FigureCheck_radioRegion);
            this.Figures_pan.Name = "Figures_pan";
            // 
            // FigureCheck_radioRegion
            // 
            resources.ApplyResources(this.FigureCheck_radioRegion, "FigureCheck_radioRegion");
            this.FigureCheck_radioRegion.Controls.Add(this.radioCurve);
            this.FigureCheck_radioRegion.Controls.Add(this.radioLine);
            this.FigureCheck_radioRegion.Controls.Add(this.radioRoundRect);
            this.FigureCheck_radioRegion.Controls.Add(this.radioEllipse);
            this.FigureCheck_radioRegion.Controls.Add(this.radioRectangle);
            this.FigureCheck_radioRegion.Name = "FigureCheck_radioRegion";
            this.FigureCheck_radioRegion.TabStop = false;
            // 
            // radioCurve
            // 
            resources.ApplyResources(this.radioCurve, "radioCurve");
            this.radioCurve.Name = "radioCurve";
            this.radioCurve.Tag = "Curve";
            this.radioCurve.UseVisualStyleBackColor = true;
            // 
            // radioLine
            // 
            resources.ApplyResources(this.radioLine, "radioLine");
            this.radioLine.Name = "radioLine";
            this.radioLine.Tag = "Line";
            this.radioLine.UseVisualStyleBackColor = true;
            // 
            // radioRoundRect
            // 
            resources.ApplyResources(this.radioRoundRect, "radioRoundRect");
            this.radioRoundRect.Name = "radioRoundRect";
            this.radioRoundRect.Tag = "RoundRect";
            this.radioRoundRect.UseVisualStyleBackColor = true;
            // 
            // radioEllipse
            // 
            resources.ApplyResources(this.radioEllipse, "radioEllipse");
            this.radioEllipse.Name = "radioEllipse";
            this.radioEllipse.Tag = "Ellipse";
            this.radioEllipse.UseVisualStyleBackColor = true;
            // 
            // radioRectangle
            // 
            resources.ApplyResources(this.radioRectangle, "radioRectangle");
            this.radioRectangle.Checked = true;
            this.radioRectangle.Name = "radioRectangle";
            this.radioRectangle.TabStop = true;
            this.radioRectangle.Tag = "Rectangle";
            this.radioRectangle.UseVisualStyleBackColor = true;
            // 
            // Color_pan
            // 
            resources.ApplyResources(this.Color_pan, "Color_pan");
            this.Color_pan.BackColor = System.Drawing.Color.Black;
            this.Color_pan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Color_pan.Name = "Color_pan";
            this.Color_pan.Click += new System.EventHandler(this.Color_pan_Click);
            // 
            // ColorDialog
            // 
            this.ColorDialog.AnyColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Clear_btn
            // 
            resources.ApplyResources(this.Clear_btn, "Clear_btn");
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabPage_MouseDown);
            this.tabPage1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tabPage_MouseMove);
            this.tabPage1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tabPage_MouseUp);
            // 
            // Tabs_tc
            // 
            resources.ApplyResources(this.Tabs_tc, "Tabs_tc");
            this.Tabs_tc.Controls.Add(this.tabPage1);
            this.Tabs_tc.Multiline = true;
            this.Tabs_tc.Name = "Tabs_tc";
            this.Tabs_tc.SelectedIndex = 0;
            this.Tabs_tc.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            // 
            // AddTab
            // 
            resources.ApplyResources(this.AddTab, "AddTab");
            this.AddTab.Name = "AddTab";
            this.AddTab.UseVisualStyleBackColor = true;
            this.AddTab.Click += new System.EventHandler(this.AddTab_btn_Click);
            // 
            // FigureContextMenu
            // 
            resources.ApplyResources(this.FigureContextMenu, "FigureContextMenu");
            this.FigureContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.FigureContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figureToolStripMenuItem,
            this.widthToolStripMenuItem1,
            this.colorToolStripMenuItem1});
            this.FigureContextMenu.Name = "contextMenuStrip1";
            this.FigureContextMenu.UseWaitCursor = true;
            // 
            // figureToolStripMenuItem
            // 
            resources.ApplyResources(this.figureToolStripMenuItem, "figureToolStripMenuItem");
            this.figureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangleToolStripMenuItem,
            this.ellipseToolStripMenuItem,
            this.roundRectToolStripMenuItem,
            this.lineToolStripMenuItem,
            this.curveToolStripMenuItem});
            this.figureToolStripMenuItem.Name = "figureToolStripMenuItem";
            this.figureToolStripMenuItem.Click += new System.EventHandler(this.figureToolStripMenuItem_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            resources.ApplyResources(this.rectangleToolStripMenuItem, "rectangleToolStripMenuItem");
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Tag = "Rectangle";
            // 
            // ellipseToolStripMenuItem
            // 
            resources.ApplyResources(this.ellipseToolStripMenuItem, "ellipseToolStripMenuItem");
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.Tag = "Ellipse";
            // 
            // roundRectToolStripMenuItem
            // 
            resources.ApplyResources(this.roundRectToolStripMenuItem, "roundRectToolStripMenuItem");
            this.roundRectToolStripMenuItem.Name = "roundRectToolStripMenuItem";
            this.roundRectToolStripMenuItem.Tag = "RoundRect";
            // 
            // lineToolStripMenuItem
            // 
            resources.ApplyResources(this.lineToolStripMenuItem, "lineToolStripMenuItem");
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Tag = "Line";
            // 
            // curveToolStripMenuItem
            // 
            resources.ApplyResources(this.curveToolStripMenuItem, "curveToolStripMenuItem");
            this.curveToolStripMenuItem.Name = "curveToolStripMenuItem";
            this.curveToolStripMenuItem.Tag = "Curve";
            // 
            // widthToolStripMenuItem1
            // 
            resources.ApplyResources(this.widthToolStripMenuItem1, "widthToolStripMenuItem1");
            this.widthToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pxToolStripMenuItem,
            this.pxToolStripMenuItem1,
            this.pxToolStripMenuItem2,
            this.pxToolStripMenuItem3,
            this.pxToolStripMenuItem4});
            this.widthToolStripMenuItem1.Name = "widthToolStripMenuItem1";
            // 
            // pxToolStripMenuItem
            // 
            resources.ApplyResources(this.pxToolStripMenuItem, "pxToolStripMenuItem");
            this.pxToolStripMenuItem.Name = "pxToolStripMenuItem";
            this.pxToolStripMenuItem.Click += new System.EventHandler(this.ContextMenuWidthClickEvent);
            // 
            // pxToolStripMenuItem1
            // 
            resources.ApplyResources(this.pxToolStripMenuItem1, "pxToolStripMenuItem1");
            this.pxToolStripMenuItem1.Name = "pxToolStripMenuItem1";
            this.pxToolStripMenuItem1.Click += new System.EventHandler(this.ContextMenuWidthClickEvent);
            // 
            // pxToolStripMenuItem2
            // 
            resources.ApplyResources(this.pxToolStripMenuItem2, "pxToolStripMenuItem2");
            this.pxToolStripMenuItem2.Name = "pxToolStripMenuItem2";
            this.pxToolStripMenuItem2.Click += new System.EventHandler(this.ContextMenuWidthClickEvent);
            // 
            // pxToolStripMenuItem3
            // 
            resources.ApplyResources(this.pxToolStripMenuItem3, "pxToolStripMenuItem3");
            this.pxToolStripMenuItem3.Name = "pxToolStripMenuItem3";
            this.pxToolStripMenuItem3.Click += new System.EventHandler(this.ContextMenuWidthClickEvent);
            // 
            // pxToolStripMenuItem4
            // 
            resources.ApplyResources(this.pxToolStripMenuItem4, "pxToolStripMenuItem4");
            this.pxToolStripMenuItem4.Name = "pxToolStripMenuItem4";
            this.pxToolStripMenuItem4.Click += new System.EventHandler(this.ContextMenuWidthClickEvent);
            // 
            // colorToolStripMenuItem1
            // 
            resources.ApplyResources(this.colorToolStripMenuItem1, "colorToolStripMenuItem1");
            this.colorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blackToolStripMenuItem,
            this.yellowToolStripMenuItem});
            this.colorToolStripMenuItem1.Name = "colorToolStripMenuItem1";
            // 
            // redToolStripMenuItem
            // 
            resources.ApplyResources(this.redToolStripMenuItem, "redToolStripMenuItem");
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Tag = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.ColorClickContextMenuEvent);
            // 
            // blueToolStripMenuItem
            // 
            resources.ApplyResources(this.blueToolStripMenuItem, "blueToolStripMenuItem");
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Tag = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.ColorClickContextMenuEvent);
            // 
            // greenToolStripMenuItem
            // 
            resources.ApplyResources(this.greenToolStripMenuItem, "greenToolStripMenuItem");
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Tag = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.ColorClickContextMenuEvent);
            // 
            // blackToolStripMenuItem
            // 
            resources.ApplyResources(this.blackToolStripMenuItem, "blackToolStripMenuItem");
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Tag = "Black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.ColorClickContextMenuEvent);
            // 
            // yellowToolStripMenuItem
            // 
            resources.ApplyResources(this.yellowToolStripMenuItem, "yellowToolStripMenuItem");
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Tag = "Yellow";
            this.yellowToolStripMenuItem.Click += new System.EventHandler(this.ColorClickContextMenuEvent);
            // 
            // buttonSave
            // 
            resources.ApplyResources(this.buttonSave, "buttonSave");
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            resources.ApplyResources(this.buttonLoad, "buttonLoad");
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
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
        private System.Windows.Forms.TextBox SizeY_tb;
        private System.Windows.Forms.Label SizeY_lb;
        private System.Windows.Forms.TextBox SizeX_tb;
        private System.Windows.Forms.Label SizeX_lb;
        private System.Windows.Forms.TextBox PointY_tb;
        private System.Windows.Forms.Label PointY_lb;
        private System.Windows.Forms.TextBox PointX_tb;
        private System.Windows.Forms.Label PointX_lb;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem roundRectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem curveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

