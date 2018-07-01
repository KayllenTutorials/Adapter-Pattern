using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
  public class NewShapeDrawing
  {
    public static void DrawRectangle(Pen p, int x, int y, int width, int height, Graphics g)
    {
      g.DrawRectangle(p, x, y, width, height);
    }

    public static void DrawCircle(Pen p, int x, int y, int radius, Graphics g)
    {
      g.DrawEllipse(p, x, y, radius, radius);
    }
  }
}
