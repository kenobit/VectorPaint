using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorPaint.Customs
{
    public partial class CustomRect : Control,IShape
    {

        public XData Data { get; set; }
        public CustomRect()
        {
            InitializeComponent();
        }
        public CustomRect(int x, int y, int width, Color color)
        {
            InitializeComponent();
            this.Data = new XData();
            this.Data.PointX = x;
            this.Data.PointY = y;
            this.Data.SizeX = width;
            this.Data.SizeY = width;
            this.Data.Width = width;
            this.Data.Color = color;

            System.Drawing.Drawing2D.GraphicsPath Button_Path = new System.Drawing.Drawing2D.GraphicsPath();
            Button_Path.AddRectangle(new System.Drawing.Rectangle(this.Data.PointX, this.Data.PointY, this.Data.SizeX, this.Data.SizeY));
            Region Button_Region = new Region(Button_Path);
            this.Region = Button_Region;
            Graphics g = this.CreateGraphics();
            OnPaint(new PaintEventArgs(g, new System.Drawing.Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height)));
        }
        public CustomRect(XData data)
        {
            InitializeComponent();
            this.Data = data;

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics g = pe.Graphics;
            g.DrawRectangle(new Pen(this.Data.Color, this.Data.Width), this.Data.PointX, this.Data.PointY, this.Data.SizeX, this.Data.SizeY);
        }
    }
}
