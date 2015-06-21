using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab45
{
    public class Triangle:Section
    {
        public override LinePainter GetPainter()
        {
            return new TrianglePainter();
        }
    }
}
