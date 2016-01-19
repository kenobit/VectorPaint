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
        public string Language
        {
            get
            {
                return Lang_cb.SelectedItem.ToString();
            }
        }
        public string Theme
        {
            get
            {
                return Theme_cb.SelectedItem.ToString();
            }
        }

        public Settings_form()
        {
            InitializeComponent();
            Lang_cb.SelectedIndex = 0;
            Theme_cb.SelectedIndex = 0;
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            ((sender as Button).Parent as Form).Close();
        }
    }
}
