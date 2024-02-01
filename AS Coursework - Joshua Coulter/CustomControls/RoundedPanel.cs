using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace AS_Coursework___Joshua_Coulter.CustomControls;

[Designer(typeof(ParentControlDesigner))]
public partial class RoundedPanel : Control
{
    private int radius = 40;
    public RoundedPanel()
    {
        InitializeComponent();
        Size = new(300, 200);
    }

    private GraphicsPath GetRoundedPath(RectangleF rect, float radius)
    {
        GraphicsPath path = new();
        path.StartFigure();
        path.AddArc(rect.Left, rect.Top, radius, radius, 180, 90);
        path.AddArc(rect.Right - radius, rect.Top, radius, radius, 270, 90);
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
        path.AddArc(rect.Left, rect.Bottom - radius, radius, radius, 90, 90);
        path.CloseFigure();
        return path;
    }

    protected override void OnPaint(PaintEventArgs pe)
    {
        base.OnPaint(pe);
        pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        RectangleF rectangleSurface = new(0, 0, Width, Height);

        rectangleSurface = DisplayRectangle;

        Region = new(rectangleSurface);

        using (GraphicsPath pathSurface = GetRoundedPath(rectangleSurface, radius))
        using (Pen penSurface = new(Parent.BackColor, 2))
        {
            Region = new(pathSurface);
            pe.Graphics.DrawPath(penSurface, pathSurface);
        }
    }
}
