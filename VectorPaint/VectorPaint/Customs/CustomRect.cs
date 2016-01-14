using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorPaint.Customs
{
    public class CustomRect : IShape
    {
        public override string GetType { get; }

        public CustomRect(int x, int y, Color color, int width)
        {
            this.Location = new Point(x, y);
            this.BackColor = Color.White;
            this.ForeColor = color;
            
            this.Width = width;
            this.Height = width;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(new Pen(this.ForeColor), 1, 1, this.Width - 2 * 1, this.Width - 2 * 1);
        }

    }
}
