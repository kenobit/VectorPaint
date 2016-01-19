using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorPaint.skins
{
    class SkinnsFactory
    {
        public void AcceptSkin(string skinName, Form form)
        {
            ISkin skin = SkinFactory(skinName);
            MakeItBeautiful(skin, form);
        }

        public ISkin SkinFactory(string skinName)
        {
            ISkin skin = null;
            switch (skinName)
            {
                case "Dark":
                    {
                        skin = new Dark();
                        return skin;
                    }
                case "Blue":
                    {
                        skin = new Blue();
                        return skin;
                    }
                case "Pink":
                    {
                        skin = new Pink();
                        return skin;
                    }
                default:
                    return null;
            }
        }

        private void MakeItBeautiful(ISkin skin, Form form)
        {
            FormBeautiful(skin, form);
            foreach(var item in form.Controls)
            {
                if(item is Button)
                {
                    ButtonsBeautiful(skin, (item as Button));
                }
                else if(item is MenuStrip)
                {
                    MenuBeautiful(skin, (item as MenuStrip));
                }
                else if(item is ToolStrip)
                {
                    ToolBoxBeautiful(skin, (item as ToolStrip));
                }
                else if (item is Panel)
                {
                    PanelsBeautiful(skin, (item as Panel));
                }
            }
        }

        private void FormBeautiful(ISkin skin, Form form)
        {
            form.BackColor = skin.WindowBGColor;
            form.Font = skin.Font;
            form.ForeColor = skin.FontColor;
        }

        private void PanelsBeautiful(ISkin skin, Panel panel)
        {
            panel.ForeColor = skin.FontColor;
            foreach(var item in panel.Controls)
            {
                if(item is GroupBox)
                {
                    (item as GroupBox).ForeColor = skin.FontColor;
                }
                else if(item is Panel)
                {
                    PanelsBeautiful(skin, (item as Panel));
                }
            }
        }

        private void ButtonsBeautiful(ISkin skin, Button button)
        {
           
            button.BackColor = skin.ButtonBGColor;
            button.FlatStyle = FlatStyle.Flat;
            button.ForeColor = skin.FontColor;
        }

        private void MenuBeautiful(ISkin skin, MenuStrip menu)
        {
            menu.BackColor = skin.MenuBGColor;
            menu.Font = skin.Font;
            menu.ForeColor = skin.FontColor;
            foreach (var cb in menu.Items)
            {
                (cb as ToolStripDropDownItem).BackColor = skin.MenuBGColor;
                (cb as ToolStripMenuItem).Font = skin.Font;
                (cb as ToolStripMenuItem).ForeColor = skin.FontColor;
                foreach(var c in (cb as ToolStripDropDownItem).DropDownItems)
                {
                    (c as ToolStripDropDownItem).BackColor = skin.MenuBGColor;
                    (c as ToolStripDropDownItem).ForeColor = skin.FontColor;
                }
            }
        }

        private void ToolBoxBeautiful(ISkin skin, ToolStrip toolStrip)
        {
            toolStrip.BackColor = skin.ToolStripBGColor;
            toolStrip.Font = skin.Font;
            toolStrip.ForeColor = System.Drawing.Color.Black;
        }

    }
}
