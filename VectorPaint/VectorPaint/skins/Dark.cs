﻿using System;
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
                Color ButtonBGColor = Color.FromArgb(14, 14, 45);
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
                Color color = Color.FromArgb(177, 166, 134);
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
                Color TabBGColor = Color.FromArgb(37, 37, 52);
                return TabBGColor;
            }
        }

        public Color WindowBGColor
        {
            get
            {
                Color TabBGColor = Color.FromArgb(37, 37, 52);
                return TabBGColor;
            }
        }

        public Color MenuBGColor
        {
            get
            {
                Color TabBGColor = Color.FromArgb(99, 88, 55);
                return TabBGColor;
            }
        }

        public Color ToolStripBGColor
        {
            get
            {
                Color TabBGColor = Color.FromArgb(177, 162, 118);
                return TabBGColor;
            }
        }
    }
}
