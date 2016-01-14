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

        private void tabPage1_Click(object sender, EventArgs e)
        {
            //Rectangle R = new Rectangle(100, 100, 10, 10);
            
        }

        private void tabPage1_MouseClick(object sender, MouseEventArgs e)
        {
            IShape shape = new CustomRect(e.X, e.Y, c, 50);

            (sender as TabPage).Controls.Add(shape);
        }
    }
}
