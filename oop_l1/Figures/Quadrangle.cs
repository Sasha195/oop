using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab45
{
    public class Quadrangle:Section
    {
        public override LinePainter GetPainter()
        {
            return new QudranglePainter();
        }
    }
}
