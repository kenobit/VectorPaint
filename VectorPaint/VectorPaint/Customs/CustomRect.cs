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
        }
        protected override void OnLostFocus(EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
