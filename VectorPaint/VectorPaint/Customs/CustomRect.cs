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
        public override string Type { get { return "rectangle"; } }
        public int Thick { get; set; }

        public CustomRect(int x, int y, Color color, int width, int height, int thick)
        {
            this.Data.PointX = x;
            this.Data.PointY = y;
            this.Data.ColorR = color.R;
            this.Data.ColorG = color.G;
            this.Data.ColorB = color.B;
            this.Data.SizeX = width;
            this.Data.SizeY = height;

            this.Location = new Point(this.Data.PointX, this.Data.PointY);
            this.BackColor = Color.White;
            this.ForeColor = Color.FromArgb(this.Data.ColorR, this.Data.ColorG, this.Data.ColorB);
            this.Thick = this.Data.Width;
            this.Width = this.Data.SizeX;
            this.Height = this.Data.SizeY;
        }

        public CustomRect(XData Data)
        {
            this.Location = new Point(Data.PointX, Data.PointY);
            this.BackColor = Color.White;
            this.ForeColor = Color.FromArgb(Data.ColorR, Data.ColorG, Data.ColorB);
            this.Thick = Data.Width;
            this.Width = Data.SizeX;
            this.Height = Data.SizeY;
        }

        public XData Data;

        public bool isFocused = false;

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(new Pen(this.ForeColor, Thick), 1, 1, this.Width - 2 * 1, this.Height - 2 * 1);

            if (this.Focused)
            {
                
                this.BackColor = Color.Green;
            }
        }

        public override void DrowDrag(int mouseX, int mouseY, int tabX, int tabY)
        {
            int locationX = 0,
                locationY = 0;
            if (tabX < mouseX)
            {
                locationX = tabX;
                this.Width = mouseX-tabX;
            }
            else
            {
                locationX = mouseX;
                this.Width = tabX - mouseX;
            }
            if (tabY < mouseY)
            {
                locationY = tabY;
                this.Height = mouseY - tabY;
            }
            else
            {
                locationY = mouseY;
                this.Height = tabY - mouseY;
            }

            this.Location = new Point(locationX, locationY);
        }

        protected override void OnClick(EventArgs e)
        {
            this.Focus();
        }
        protected override void OnGotFocus(EventArgs e)
        {
            this.BackColor = Color.Red;
            this.isFocused = true;
            //Graphics g = e.Graphics;
            //DrawBorder();
        }
        protected override void OnLostFocus(EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private bool isResizingNow = false;
        private bool isDragingNow = false;
        private int beginDragX = 0;
        private int beginDragY = 0;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            
            if (e.X > (this.Width - 20) && e.Y > (this.Height - 20))
            {
                this.isResizingNow = true;
            }
            else
            {
                this.isDragingNow = true;
                this.beginDragX = e.X;
                this.beginDragY = e.Y;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (this.isResizingNow)
            {
                this.Width = this.Location.X - e.X;
                this.Height = this.Location.Y- e.Y;
            }
            if (this.isDragingNow)
            {
                int distanceX = this.beginDragX - e.X + this.Location.X;
                int distanceY = this.beginDragY - e.Y + this.Location.Y;

                this.Location = new Point(distanceX, distanceY);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            this.isDragingNow = false;
            this.isResizingNow = false;
        }

        protected void DrawBorder()
        {
            


            //this.BackColor = Color.Red;
            //Pen pen = new Pen(Color.Red, 4);
            //pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            //float[] dashValues = { 4, 2 };
            //pen.DashPattern = dashValues;
            //g.DrawRectangle(pen, 5, 5, this.Width - 2 * 1, this.Height - 2 * 1);
        }
    }
}
