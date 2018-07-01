using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
  // this is the Adaptee when m_cbUseOriginalShapeDrawing is 
  // checked in the New Shape Drawing panel but is just a plain old 
  // class when using it in the original shape drawing panel

  public class OriginalShapeDrawing
  {
    public static void DrawRectangle(int x, int y, int width, int height, Graphics g)
    {
      g.DrawRectangle(Pens.Black, x, y, width, height);
    }

    public static void DrawCircle(int x, int y, int radius, Graphics g)
    {
      g.DrawEllipse(Pens.Black, x, y, radius, radius);
    }
  }
}
