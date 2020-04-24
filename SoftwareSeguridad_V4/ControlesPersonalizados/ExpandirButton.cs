using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareSeguridad_V4
{
    class ExpandirButton: Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            Point[] myPointArray =
            {
                new Point(0, ClientSize.Height),
                new Point(ClientRectangle.Width/2, -ClientRectangle.Y),
                new Point(ClientRectangle.Width, ClientSize.Height)
            };
            graphicsPath.AddCurve(myPointArray, 1f);
            //graphicsPath.AddArc(0, -ClientSize.Height/2, ClientSize.Width,ClientSize.Height,0, 180);

            this.Region = new Region(graphicsPath);
            base.OnPaint(pevent);
        }
    }
}
