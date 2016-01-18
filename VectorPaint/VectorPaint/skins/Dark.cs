using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorPaint.skins
{
    class Dark : ISkin
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
                Color ButtonBGColor = Color.Brown;
                return ButtonBGColor;
            }
        }

        public string Font
        {
            get
            {
               string Font = "Times New Roman";
               return Font;
            }
        }

        public int FontSize
        {
            get
            {
               int FontSize = 15;
                return FontSize;
            }
        }

        public Color TabBGColor
        {
            get
            {
                Color TabBGColor = Color.Black;
                return TabBGColor;
            }
        }

        public Color WindowBGColor
        {
            get
            {
                Color TabBGColor = Color.Black;
                return TabBGColor;
            }
        }
    }
}
