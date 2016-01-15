using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorPaint.Customs
{
    public abstract class IShape : Control
    {
        public virtual Form MainFormLink { get; set; }
        public virtual string Type { get; }
        public virtual XData Data { get; set; }
        public virtual void DrowDrag(int mouseX, int mouseY, int tabX, int tabY)
        {

        }
        public virtual ContextMenuStrip MenuContext { get; set; }
    }
}
