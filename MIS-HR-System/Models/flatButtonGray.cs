using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS_HR_System.Models
{
    class flatButtonGray : Button
    {
        public flatButtonGray()
        {
            BackColor = Color.DimGray;
            ForeColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.FillRectangle(new SolidBrush(this.BackColor), 0, 0, this.Width, this.Height);
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(pevent.Graphics, Text, Font, new Point(this.Width + 3, this.Height / 2), ForeColor, flags);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            BackColor = Color.FromArgb(34, 80, 129);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = Color.DimGray;
        }
        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            BackColor = Color.FromArgb(64, 64, 64);
        }
        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            BackColor = Color.DimGray;
        }

        private Color onMouseHoverBackColor = Color.FromArgb(34, 80, 129);
        public Color OnMouseHoverBackColor
        {
            get { return onMouseHoverBackColor; }
            set { onMouseHoverBackColor = value; }
        }
    }
}
