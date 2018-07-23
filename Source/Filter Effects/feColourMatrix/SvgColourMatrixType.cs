using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

#pragma warning disable

namespace Svg.FilterEffects
{
    [TypeConverter(typeof(EnumBaseConverter<SvgColourMatrixType>))]
	public enum SvgColourMatrixType
	{
		Matrix,
		Saturate,
		HueRotate,
		LuminanceToAlpha
	}
}


#pragma warning restore