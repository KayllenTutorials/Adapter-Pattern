using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
  // class Terget defines the interface that is expected by clients.  

  public abstract class Target
  {
    public abstract void DrawRectangle(Pen p, int x, int y, int width, int height, Graphics g);
    public abstract void DrawCircle(Pen p, int x, int y, int radius, Graphics g);
  }

}
