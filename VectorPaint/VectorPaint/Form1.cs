using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VectorPaint.Customs;
using System.Reflection;


namespace VectorPaint
{
    public partial class MainWindow : Form, IDataTransfer
    {
        public Color c = Color.Black;
        public int Thick = 1;
        IShape currentShape = null;
        public IShape FocusedFigure { get; set; }
        List<IShape> figures = new List<IShape>();
        int tabX = 0,
            tabY = 0;
        bool f = false;
        TabPage.ControlCollection CurrentTabControls = null;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Color_pan_Click(object sender, EventArgs e)
        {
            ColorDialogInvoker();
        }

        private void ColorDialogInvoker()
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                Color_pan.BackColor = ColorDialog.Color;
                c = ColorDialog.Color;
            }
        }

        private void tabPage_MouseDown(object sender, MouseEventArgs e)
        {
            TabMouseDown(sender, e);
        }

        private void tabPage_MouseMove(object sender, MouseEventArgs e)
        {
            TabMouseMove(sender, e);
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Tabs_tc.SelectedTab.Controls.Clear();
        }

        private void AddTab_btn_Click(object sender, EventArgs e)
        {
            TabPage tp = new TabPage("Tab #" + (Tabs_tc.TabCount + 1).ToString());
            tp.BackColor = Color.White;
            tp.MouseMove += TabMouseMove;
            tp.MouseUp += TabMouseUp;
            tp.MouseDown += TabMouseDown;
            Tabs_tc.TabPages.Add(tp);
            Tabs_tc.SelectedTab = tp;
        }

        private void tabPage_MouseUp(object sender, MouseEventArgs e)
        {
            TabMouseUp(sender, e);
        }

        private void TabMouseDown(object sender, MouseEventArgs e)
        {
            this.Focus();
            this.tabX = e.X;
            this.tabY = e.Y;
            IShape shape = SelectedFigureCheck(e);
            shape.MenuContext = FigureContextMenu;
            this.currentShape = shape;
            (sender as TabPage).Controls.Add(shape);
            CurrentTabControls = (sender as TabPage).Controls;
            buttonSave.Enabled = true;
            f = true;
        }
        private void TabMouseUp(object sender, MouseEventArgs e)
        {
            f = false;
        }

        private void TabMouseMove(object sender, MouseEventArgs e)
        {
            if (f)
            {
                this.currentShape.DrowDrag(e.X, e.Y, tabX, tabY);
                currentShape.Refresh();
            }
        }

        private IShape SelectedFigureCheck(MouseEventArgs e)
        {
            IShape shape = null;
            string sw = "";
            foreach (RadioButton radio in FigureCheck_radioRegion.Controls)
            {
                if (radio.Checked == true)
                {
                    sw = radio.Text;
                }
            }
            Thick = Width_tb.Text == "" ? 1 : Convert.ToInt32(Width_tb.Text);
            switch (sw.ToLower())
            {
                case "rectangle":
                    {
                        shape = new CustomRect(e.X, e.Y, c, 15, 15, Thick);
                        shape.MainFormLink = this;
                    }
                    break;
                case "ellipse":
                    {
                        shape = new CustomEllipse(e.X, e.Y, c, 15, 15, Thick);
                        shape.MainFormLink = this;
                    }
                    break;
                case "line":
                    {
                        shape = new CustomLine(e.X, e.Y, c, 15, 15, Thick);
                        shape.MainFormLink = this;
                    }
                    break;
                default:
                    shape = new CustomRect(e.X, e.Y, c, 15, 15, Thick);
                    break;
            }

            return shape;
        }

        private void figureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, feature does not implemented yet");

        }

        private void ColorClickContextMenuEvent(object sender, EventArgs e)
        {
            this.currentShape.ForeColor = Color.FromName((sender as ToolStripMenuItem).Text);
        }

        private void ContextMenuWidthClickEvent(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, feature does not implemented yet");

        }

        public void FromFigureToBars(object obj)
        {
            IShape figure = (obj as IShape);
            Color_pan.BackColor = figure.ForeColor;

            #region switch
            switch (figure.Type.ToLower())
            {
                case "rectangle":
                    {
                        foreach (RadioButton item in FigureCheck_radioRegion.Controls)
                        {
                            if (item.Text.ToLower() == figure.Type.ToLower())
                            {
                                item.Checked = true;
                            }
                            else
                            {
                                item.Checked = false;
                            }
                        }
                    }
                    break;
                case "ellipse":
                    {
                        foreach (RadioButton item in FigureCheck_radioRegion.Controls)
                        {
                            if (item.Text.ToLower() == figure.Type.ToLower())
                            {
                                item.Checked = true;
                            }
                            else
                            {
                                item.Checked = false;
                            }
                        }
                    }
                    break;
                case "line":
                    {
                        foreach (RadioButton item in FigureCheck_radioRegion.Controls)
                        {
                            if (item.Text.ToLower() == figure.Type.ToLower())
                            {
                                item.Checked = true;
                            }
                            else
                            {
                                item.Checked = false;
                            }
                        }
                    }
                    break;

                default:
                    break;
            }
            #endregion

            SizeX_tb.Text = figure.Data.SizeX.ToString();
            SizeY_tb.Text = figure.Data.SizeY.ToString();
            PointX_tb.Text = figure.Data.PointX.ToString();
            PointY_tb.Text = figure.Data.PointY.ToString();
            Width_tb.Text = figure.Data.Width.ToString();
        }



        Memento mem;

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Tabs_tc.SelectedTab.Controls.Count == 0)
            {
                MessageBox.Show("You have not figures in selected tab.");
                return;
            }
            else
                SaveDialog();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadDialog();
        }

        public void SaveDialog()
        {
            SaveState();
            saveFileDialog1.Filter = "XML files|*.xml|Binary|*.dat|JSON files|*.json|YAML files|*.yaml";

            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            string ext = saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.LastIndexOf('.') + 1);

            Factory cr = new Factory();
            cr.Format(ext.ToUpper());
            cr.To(mem.GetState, saveFileDialog1.FileName);
        }
        public void LoadDialog()
        {
            try
            {
                openFileDialog1.Filter = "XML files|*.xml|Binary|*.dat|JSON files|*.json|YAML files |*.yaml";
                if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
                string ext = openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf('.') + 1);

                Factory cr = new Factory();
                cr.Format(ext.ToUpper());

                mem = new Memento(cr.From(openFileDialog1.FileName));
                LoadState();
            }
            catch
            {
                MessageBox.Show("Load Error");
                return;
            }
        }


        public void SaveState()
        {
            var list = new List<XData>();
            foreach (IShape item in CurrentTabControls)
            {
                list.Add(item.Data);
            }

            mem = new Memento(list);
        }

        public void LoadState()
        {
            List<XData> list = new List<XData>();
            Tabs_tc.SelectedTab.Controls.Clear();
            foreach (var item in mem.GetState)
            {
                CreateFigure(item);
            }
        }

        private void tabsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tabsItem = (sender as ToolStripMenuItem);
            tabsItem.DropDownItems.Clear();
            foreach (TabPage tab in Tabs_tc.TabPages)
            {
                ToolStripMenuItem tmi = new ToolStripMenuItem(tab.Text);
                tmi.Click += tabChangerInToolstrip_Click;
                if (tab == Tabs_tc.SelectedTab)
                {
                    tmi.BackColor = Color.IndianRed;
                }
                if (!tabsItem.DropDownItems.Contains(tmi))
                {
                    tabsItem.DropDownItems.Add(tmi);
                }

            }
        }

        private void tabChangerInToolstrip_Click(object sender,EventArgs e)
        {
           // ToolStripMenuItem tab_tollstrip = (sender as ToolStripMenuItem);
            MessageBox.Show("Sorry, feature does not implemented yet");
           // Tabs_tc.SelectedIndex = Tabs_tc.TabPages //[(tab_tollstrip.OwnerItem as ToolStripMenuItem).DropDownItems.IndexOf(tab_tollstrip)];

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings_form settings = new Settings_form();
            if (settings.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("form");
            }
        }

        public void CreateFigure(XData Data)
        {

            string type = Data.Type;
            switch (type)
            {
                case "rectangle":
                    Tabs_tc.SelectedTab.Controls.Add(new CustomRect(Data, this));
                    break;
                case "ellipse":
                    Tabs_tc.SelectedTab.Controls.Add(new CustomEllipse(Data, this));
                    break;
                case "line":
                    Tabs_tc.SelectedTab.Controls.Add(new CustomLine(Data, this));
                    break;
                default:
                    Tabs_tc.SelectedTab.Controls.Add(new CustomRect(Data, this));
                    break;
            }
        }
    }
}
