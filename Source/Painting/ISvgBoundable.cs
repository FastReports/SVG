using System.Drawing;

#pragma warning disable

namespace Svg
{
    public interface ISvgBoundable
    {
        PointF Location
        {
            get;
        }

        SizeF Size
        {
            get;
        }

        RectangleF Bounds
        {
            get;
        } 
    }
}

#pragma warning restore