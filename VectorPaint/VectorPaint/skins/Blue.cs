using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorPaint.skins
{
    class Blue : ISkin
    {
        public Color BoxBGColor
        {
            get
            {
                Color BoxBGColor = Color.Brown;
                return BoxBGColor;
            }
        }

        public Color ButtonBGColor
        {
            get
            {
                Color ButtonBGColor = Color.FromArgb(3, 52, 74);
                return ButtonBGColor;
            }
        }

        public Font Font
        {
            get
            {
                Font font = new Font("Segoe Print", 7.0f);
                return font;
            }
        }

        public Color FontColor
        {
            get
            {
                Color color = Color.FromArgb(254, 228, 199);
                return color;
            }
        }

        public float FontSize
        {
            get
            {
                float FontSize = 10.0f;
                return FontSize;
            }
        }

        public Color TabBGColor
        {
            get
            {
                Color TabBGColor = Color.FromArgb(58, 146, 184);
                return TabBGColor;
            }
        }

        public Color WindowBGColor
        {
            get
            {
                Color TabBGColor = Color.FromArgb(58, 146, 184);
                return TabBGColor;
            }
        }

        public Color MenuBGColor
        {
            get
            {
                Color TabBGColor = Color.FromArgb(17, 76, 101); 
                return TabBGColor;
            }
        }

        public Color ToolStripBGColor
        {
            get
            {
                Color TabBGColor = Color.FromArgb(58, 99, 117); 
                return TabBGColor;
            }
        }
    }
}
