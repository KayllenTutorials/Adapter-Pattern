using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{

  // Adapter -- converts requests specified by the Target class (the "new" interface) to the format 
  //            known by the by the adaptee class (the "old" interface).

  public class Adapter : Target
  {
    // The Class OriginalShapeDrawing is the adaptee class.  Notice that the interface
    // accepts the same parameters as the NewShapeDrawing class but that the Pen argument
    // is ignored when calling the adaptee.  This is typical of adapter patterns.
    
    public override void DrawRectangle(Pen p, int x, int y, int width, int height, Graphics g)
    {
      OriginalShapeDrawing.DrawRectangle(x, y, width, height, g);
    }

    public override void DrawCircle(Pen p, int x, int y, int radius, Graphics g)
    {
      OriginalShapeDrawing.DrawCircle(x, y, radius, g); 
    }
  }
}
