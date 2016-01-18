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
    public partial class Settings_form : Form
    {
        public Settings_form()
        {
            InitializeComponent();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            ((sender as Button).Parent as Form).Close();
        }
    }
}
