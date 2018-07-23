using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#pragma warning disable

namespace Svg
{
    [SvgElement("font-face-src")]
    public class SvgFontFaceSrc : SvgElement
    {
        public override SvgElement DeepCopy()
        {
            return base.DeepCopy<SvgFontFaceSrc>();
        }
    }
}


#pragma warning restore