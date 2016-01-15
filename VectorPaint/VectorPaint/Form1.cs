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

namespace VectorPaint
{
    public partial class MainWindow : Form
    {
        public Color c = Color.Black;
        IShape currentShape = null;
        int tabX = 0, 
            tabY = 0;
        bool f = false;
        TabPage.ControlCollection CurrentTabControls;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Color_pan_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                (sender as Control).BackColor = ColorDialog.Color;
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
            TabPage tp = new TabPage("new page");
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
            this.tabX = e.X;
            this.tabY = e.Y;
            IShape shape = SelectedFigureCheck(e);
            
             this.currentShape = shape;
            (sender as TabPage).Controls.Add(shape);
            CurrentTabControls = (sender as TabPage).Controls;
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveState();
            saveFileDialog1.Filter = "XML files | *.xml | JSON files | *.json | CSV files | *.csv | YAML files | *.yaml ";

            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            string ext = saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.LastIndexOf('.') + 1);

            Factory cr = new Factory();
            cr.Format(ext.ToUpper());
            cr.To(mem.GetState, saveFileDialog1.FileName);
        }

        Memento mem;

        public void SaveState()
        {
            var list = new List<XData>();
            foreach (var item in currentShape.Controls)
            {
                list.Add(item.XData() { dx = item.dx, dy = item.dy, radius = item.radius, x = item.X, y = item.Y });
            }

            mem = new Memento(list);
        }

        public void LoadState()
        {
            Balls = new List<BouncingBallClass>();

            foreach (var item in mem.GetState)
            {
                Balls.Add(new BouncingBallClass() { dx = item.dx, dy = item.dy, radius = item.radius, X = item.x, Y = item.y });
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
            switch (sw.ToLower())
            {
                case "rectangle":
                    {
                        shape = new CustomRect(e.X, e.Y, c, 15, 15, 5);
                    }
                    break;
                case "ellipse":
                    {
                        shape = new CustomEllipse(e.X, e.Y, c, 15, 15, 1);
                    }
                    break;
                default:
                    shape = new CustomRect(e.X, e.Y, c, 15, 15, 1);
                    break;
            }

            return shape;
        }
    }
}
