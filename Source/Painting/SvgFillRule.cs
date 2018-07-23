using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

#pragma warning disable

namespace Svg
{
	[TypeConverter(typeof(SvgFillRuleConverter))]
    public enum SvgFillRule
    {
        NonZero,
        EvenOdd,
        Inherit
    }
}

#pragma warning restore