using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Resources;

namespace LocalTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Lang_cb.Items.Add("English");
            Lang_cb.Items.Add("Russian");
            Lang_cb.Items.Add("German");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CultureInfo.CurrentUICulture.DisplayName);
        }

        private void Lang_cb_SelectedIndexChanged(object sender, EventArgs e)
        { string sw = (sender as ComboBox).SelectedItem.ToString();
            switch (sw)
            {
                case "Russian":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");
                    ChangeLanguage();
                    break;
                case "German":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
                    ChangeLanguage();
                    break;
                default:
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    ChangeLanguage();
                    break;
            }
            
        }
        private static void ChangeLanguage()
        {
            foreach (Form frm in Application.OpenForms)
            {
                LocalizeForm(frm);
            }
        }

        private static void LocalizeForm(Form frm)
        {
            var manager = new ComponentResourceManager(frm.GetType());
            manager.ApplyResources(frm, "$this");
            ApplyResources(manager, frm.Controls);
        }

        private static void ApplyResources(ComponentResourceManager manager, Control.ControlCollection ctls)
        {
            foreach (Control ctl in ctls)
            {
                manager.ApplyResources(ctl, ctl.Name);
                ApplyResources(manager, ctl.Controls);
            }
        }
    }
}
