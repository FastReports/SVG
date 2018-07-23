using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

#pragma warning disable

namespace Svg
{
    public interface IGraphicsProvider
    {
        Graphics GetGraphics();
    }
}


#pragma warning restore