using System.Drawing;

namespace VectorPaint.Customs
{
    public class XData
    {
        public int PointX { get; set; }
        public int PointY { get; set; }
        public int Width { get; set; }
        public int SizeX { get; set; }
        public int SizeY { get; set; }
        public Color Color { get; set; }

        public XData()
        {

        }
        public XData(int pointX,int pointY,int sizeX,int sizeY,int width,Color color)
        {
            this.PointX = pointX;
            this.PointY = PointY;
            this.SizeX = sizeX;
            this.SizeY = sizeY;
            this.Width = width;
            this.Color = color;
        }
    }
}