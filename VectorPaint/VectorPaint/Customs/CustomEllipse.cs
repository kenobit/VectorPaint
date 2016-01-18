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
    public partial class CustomEllipse : IShape
    {

        public override string Type { get { return "ellipse"; } }
        public int Thick { get; set; }
        public override Form MainFormLink { get; set; }
        public override XData Data { get; set; }
        public override ContextMenuStrip MenuContext { get; set; }
        private bool isMoving = false;
        private bool isResizing = false;
        private Color resizeRectColor = Color.Transparent;

        int mX = 0,
            mY = 0;

        public CustomEllipse(int x, int y, Color color, int width, int height, int thick)
        {
            OpacityInit();
            Data = new XData();
            Data.PointX = x;
            Data.PointY = y;
            Data.ColorR = color.R;
            Data.ColorG = color.G;
            Data.ColorB = color.B;
            Data.SizeX = width;
            Data.SizeY = height;
            Data.Width = thick;
            Data.Type = "ellipse";

            this.Location = new Point(this.Data.PointX, this.Data.PointY);
            this.BackColor = Color.White;
            this.ForeColor = Color.FromArgb(this.Data.ColorR, this.Data.ColorG, this.Data.ColorB);
            this.Thick = this.Data.Width;
            this.Width = this.Data.SizeX;
            this.Height = this.Data.SizeY;
        }

        public CustomEllipse(XData Data)
        {
            OpacityInit();
            this.Data = Data;
            this.Location = new Point(Data.PointX, Data.PointY);
            this.BackColor = Color.White;
            this.ForeColor = Color.FromArgb(Data.ColorR, Data.ColorG, Data.ColorB);
            this.Thick = Data.Width;
            this.Width = Data.SizeX;
            this.Height = Data.SizeY;
        }

        public CustomEllipse(XData Data, Form form)
        {
            OpacityInit();
            this.Data = Data;
            this.MainFormLink = form;
            this.Location = new Point(Data.PointX, Data.PointY);
            this.BackColor = Color.White;
            this.ForeColor = Color.FromArgb(Data.ColorR, Data.ColorG, Data.ColorB);
            this.Thick = Data.Width;
            this.Width = Data.SizeX;
            this.Height = Data.SizeY;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawEllipse(new Pen(this.ForeColor, Thick),  this.Thick,  this.Thick, this.Width - this.Thick * 2, this.Height - this.Thick * 2);
            g.DrawRectangle(new Pen(this.resizeRectColor, 5), this.Width - 15 * 1, this.Height - 15 * 1, 10, 10);

            if (this.Focused)
            {
                this.BackColor = Color.Azure;
            }
        }

        public override void DrowDrag(int mouseX, int mouseY, int tabX, int tabY)
        {
            int locationX = 0,
                locationY = 0;
            if (tabX < mouseX)
            {
                locationX = tabX;
                this.Width = mouseX - tabX;
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
            this.Data.PointX = locationX;
            this.Data.PointY = locationY;
            this.Data.SizeY = this.Height;
            this.Data.SizeX = this.Width;
        }

        protected override void OnClick(EventArgs e)
        {
            this.Focus();
        }
        protected override void OnGotFocus(EventArgs e)
        {
            (this.MainFormLink as IDataTransfer).FromFigureToBars(this as object);

            this.BackColor = Color.Red;
        }
        protected override void OnLostFocus(EventArgs e)
        {
            this.BackColor = Color.White;

        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MenuContext.Show(this, new Point(e.X, e.Y));
            }
            else
            {
                if (e.X >= this.Width - 20 && e.Y >= this.Height - 20)
                {
                    isResizing = true;
                }
                else
                {
                    isMoving = true;

                }
                mX = e.X;
                mY = e.Y;
            }
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (isMoving)
            {
                this.Location = new Point(Location.X + (e.X - mX), Location.Y + (e.Y - mY));
                this.Data.PointX = this.Location.X;
                this.Data.PointY = this.Location.Y;
                (this.MainFormLink as IDataTransfer).FromFigureToBars(this as object);
            this.Parent.Refresh();
            }
            if (isResizing)
            {
                this.Width = e.X;
                this.Height = e.Y;
                this.Refresh();
                this.Data.SizeX = this.Width;
                this.Data.SizeY = this.Height;
                (this.MainFormLink as IDataTransfer).FromFigureToBars(this as object);
            }
        }

        protected override void OnMouseHover(EventArgs e)
        {
            this.resizeRectColor = Color.Gray;
        }
        protected override void OnLeave(EventArgs e)
        {
            this.resizeRectColor = Color.Transparent;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            this.isMoving = false;
            this.isResizing = false;
            this.Refresh();
        }
        
    }
}
