using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Aprendendo_MVC
{
    class PictureBoxCircle : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath Grpath = new GraphicsPath();
            Grpath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(Grpath);
            base.OnPaint(pe);
        }
    }
}
