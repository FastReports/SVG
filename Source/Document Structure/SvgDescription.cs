using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

#pragma warning disable

namespace Svg
{
    [DefaultProperty("Text")]
    [SvgElement("desc")]
    public class SvgDescription : SvgElement, ISvgDescriptiveElement
    {
        public override string ToString()
        {
            return this.Content;
        }

        public override SvgElement DeepCopy()
        {
            return DeepCopy<SvgDescription>();
        }

        public override SvgElement DeepCopy<T>()
        {
            var newObj = base.DeepCopy<T>() as SvgDescription;
            return newObj;
        }
    }
}

#pragma warning restore