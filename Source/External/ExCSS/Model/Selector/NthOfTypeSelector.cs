
// ReSharper disable once CheckNamespace
#pragma warning disable

namespace ExCSS
{
    internal sealed class NthOfTypeSelector : NthChildSelector, IToString
    {
        public override string ToString(bool friendlyFormat, int indentation = 0)
        {
            return FormatSelector(PseudoSelectorPrefix.PseudoFunctionNthOfType);
        }
    }
}

#pragma warning restore