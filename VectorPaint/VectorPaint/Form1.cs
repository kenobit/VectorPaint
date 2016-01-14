using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorPaint
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Color_pan_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                (sender as Control).BackColor = ColorDialog.Color;
            }
        }

        private void Tabs_PaintEvent(object sender, PaintEventArgs e)
        {
        }

        private void Tabs_MouseDownEvent(object sender, MouseEventArgs e)
        {
            Controls.Add(new Customs.CustomRect(50, 50, 20, Color.Green));
        }

        private void Tabs_MouseMoveEvent(object sender, MouseEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
