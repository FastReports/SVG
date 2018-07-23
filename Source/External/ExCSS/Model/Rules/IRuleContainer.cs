using System.Collections.Generic;

// ReSharper disable once CheckNamespace
#pragma warning disable

namespace ExCSS
{
    public interface IRuleContainer
    {
        List<RuleSet> Declarations { get; }
    }
}

#pragma warning restore