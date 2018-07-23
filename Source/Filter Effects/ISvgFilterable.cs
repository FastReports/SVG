using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable

namespace Svg.FilterEffects
{
    public interface ISvgFilterable
    {
        SvgFilter Filter { get; set; }
    }
}


#pragma warning restore