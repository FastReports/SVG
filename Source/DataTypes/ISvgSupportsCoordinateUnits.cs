using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#pragma warning disable

namespace Svg
{
    internal interface ISvgSupportsCoordinateUnits
    {
        SvgCoordinateUnits GetUnits();
    }
}


#pragma warning restore