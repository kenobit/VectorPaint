using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorPaint.skins
{
    interface ISkin
    {
        Color ButtonBGColor { get; }
        Color WindowBGColor { get; }
        Color TabBGColor { get; }
        Color BoxBGColor { get; }
        Color MenuBGColor { get; }
        Color ToolStripBGColor { get; }
        Font Font { get; }
        Color FontColor { get;  }
        float FontSize { get; }
    }
}
