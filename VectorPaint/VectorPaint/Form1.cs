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
        IShape currentShape = null;
        public IShape FocusedFigure { get; set; }
        public ContextMenuStrip FigureContMenu;

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
                        shape = new CustomRect(e.X, e.Y, c, 15, 15, 1);
                        shape.MainFormLink = this;
                    }
                    break;
                case "ellipse":
                    {
                        shape = new CustomEllipse(e.X, e.Y, c, 15, 15, 1);
                        shape.MainFormLink = this;
                    }
                    break;
                default:
                    shape = new CustomRect(e.X, e.Y, c, 15, 15, 1);
                    break;
            }

            return shape;
        }

        public void FromFigureToBars(object obj)
        {
            IShape figure = (obj as IShape);
            Color_pan.BackColor = figure.ForeColor;
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
                //case "roundrect":
                //    {
                //        foreach (RadioButton item in FigureCheck_radioRegion.Controls)
                //        {
                //            if (item.Text == figure.Type.ToLower())
                //            {
                //                item.Checked = true;
                //            }
                //        }
                //    }
                //    break;
                //case "line":
                //    {
                //        foreach (RadioButton item in FigureCheck_radioRegion.Controls)
                //        {
                //            if (item.Text == figure.Type.ToLower())
                //            {
                //                item.Checked = true;
                //            }
                //        }
                //    }
                //    break;
                //case "curve":
                //    {
                //        foreach (RadioButton item in FigureCheck_radioRegion.Controls)
                //        {
                //            if (item.Text == figure.Type.ToLower())
                //            {
                //                item.Checked = true;
                //            }
                //        }
                //    }
                //    break;
                default:
                    break;
            }


            Width_tb.Text = figure.ForeColor.ToString();
        }
    }
}
