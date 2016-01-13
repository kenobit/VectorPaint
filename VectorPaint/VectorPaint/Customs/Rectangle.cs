using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorPaint.Customs
{
    class Rectangle : Control, IShape
    {
        public XData Data { get; set; }

        public Rectangle(XData data)
        {
            this.Data = data;
        }
        public Rectangle(int x, int y,int sizeX,int sizeY,int width, Color color)
        {
            this.Data.PointX = x;
            this.Data.PointY = y;
            this.Data.SizeX = sizeX;
            this.Data.SizeY = sizeY;
            this.Data.Width = width;
            this.Data.Color = color;
        }
    }
}
