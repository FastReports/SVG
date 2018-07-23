using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable

namespace Svg
{
    public class SvgMask : SvgElement
    {


		public override SvgElement DeepCopy()
		{
			return DeepCopy<SvgMask>();
		}

    }
}

#pragma warning restore