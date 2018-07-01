using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adapter
{
  public partial class Form1 : Form
  {
    Color PenColor = Color.Black;

    public Form1()
    {
      InitializeComponent();
    }

    private void m_pnlOrigShapeDrawing_MouseClick(object sender, MouseEventArgs e)
    {
      Graphics g = m_pnlOrigShapeDrawing.CreateGraphics();

      if (e.Button == System.Windows.Forms.MouseButtons.Left)
        OriginalShapeDrawing.DrawRectangle(e.X, e.Y, 30, 45, g);
      else
        OriginalShapeDrawing.DrawCircle(e.X, e.Y, 30, g);
    }

    private void m_pnlNewShapeDrawing_MouseClick(object sender, MouseEventArgs e)
    {
      Adapter adapter = new Adapter();
      Graphics g = m_pnlNewShapeDrawing.CreateGraphics();
      Pen p = new Pen(new SolidBrush(PenColor));
      p.Width = (float)m_nudPenWidth.Value;
      NewShapeDrawing nsd = new NewShapeDrawing();
      Target t = new Adapter();

      if (!m_cbUseOriginalShapeDrawing.Checked)
      {
        // This code is executed without using the adapter -- direct calls to the new code
        if (e.Button == System.Windows.Forms.MouseButtons.Left)
          NewShapeDrawing.DrawRectangle(p, e.X, e.Y, 30, 45, g);
        else
          NewShapeDrawing.DrawCircle(p, e.X, e.Y, 30, g);
      }
      else
      {
        // This code causes drawing to occur using the legacy drawing code in the adapter.
        if (e.Button == System.Windows.Forms.MouseButtons.Left)
          adapter.DrawRectangle(p, e.X, e.Y, 30, 45, g);
        else
          adapter.DrawCircle(p, e.X, e.Y, 30, g);
      }
    }

    private void m_btnPenColor_Click(object sender, EventArgs e)
    {
      ColorDialog cd = new ColorDialog();
      if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        PenColor = cd.Color;
    }


  }
}
