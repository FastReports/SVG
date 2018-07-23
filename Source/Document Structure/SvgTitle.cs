using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

#pragma warning disable

namespace Svg
{
    [SvgElement("title")]
    public class SvgTitle : SvgElement, ISvgDescriptiveElement
    {
        public override string ToString()
        {
            return this.Content;
        }

        public override SvgElement DeepCopy()
        {
            return DeepCopy<SvgTitle>();
        }

        public override SvgElement DeepCopy<T>()
        {
            var newObj = base.DeepCopy<T>() as SvgTitle;
            return newObj;
        }

    }
}

#pragma warning restore