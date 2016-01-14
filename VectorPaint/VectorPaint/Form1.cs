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
        int tabX = 0, tabY = 0;
        bool f = false;
        TabPage currentPage;
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
                string sdsdsdsd = ColorDialog.Color.ToArgb().ToString();

                MessageBox.Show(c.R + " " + c.G+" "+c.B+" "+c.A);
                MessageBox.Show(c.Name);
            }
        }

        private void tabPage1_MouseDown(object sender, MouseEventArgs e)
        {
            this.tabX = e.X;
            
            this.tabY = e.Y;
            IShape shape = new CustomRect(e.X, e.Y, c, 15,15,1);
            this.currentShape = shape;
            (sender as TabPage).Controls.Add(shape);
            
            CurrentTabControls = (sender as TabPage).Controls;
            f = true;
        }

        private void tabPage1_MouseMove(object sender, MouseEventArgs e)
        {
            if (f)
            {
                this.currentShape.DrowDrag(e.X, e.Y, tabX, tabY);
                currentShape.Refresh();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tabs_tc.SelectedTab.Controls.Clear();
        }

        private void tabPage1_MouseUp(object sender, MouseEventArgs e)
        {
            f = false;
        }
    }
}
