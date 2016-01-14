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
        public override string GetType { get { return "rect"; } }
        public int Thick { get; set; }

        public CustomRect(int x, int y, Color color, int width,int height,int thick)
        {
            this.Location = new Point(x, y);
            this.BackColor = Color.White;
            this.ForeColor = color;
            this.Thick = thick;
            this.Width = width;
            this.Height = height;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(new Pen(this.ForeColor,Thick), 1,1, this.Width - 2 * 1, this.Width - 2 * 1);
        }

        public override void DrowDrag(int widthX, int heightY)
        {
            this.Width = widthX;
            this.Height = heightY;
        }

    }
}
