using System.Collections.Generic;

#pragma warning disable

namespace ExCSS.Model
{
    interface ISupportsRuleSets
    {
        List<RuleSet> RuleSets { get; }
    }
}

#pragma warning restore