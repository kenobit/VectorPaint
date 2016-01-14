using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorPaint.Customs
{
   partial class Rectangle : Control, IShape
    {
        public XData Data { get; set; }
        public Rectangle Rect { get; set; }

        public Rectangle(XData data)
        {

            this.Data = data;
            
        }
        public Rectangle(int x, int y,int width, Color color)
        {
            this.Data = new XData();
            this.Data.PointX = x;
            this.Data.PointY = y;
            this.Data.SizeX = width;
            this.Data.SizeY = width;
            this.Data.Width = width;
            this.Data.Color = color;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(new Pen(this.Data.Color, this.Data.Width), this.Data.PointX, this.Data.PointY, this.Data.SizeX, this.Data.SizeY);
        }
        
    }
}
