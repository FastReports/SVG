using System.Collections.Generic;
using ExCSS.Model;

// ReSharper disable once CheckNamespace
#pragma warning disable

namespace ExCSS
{
    public abstract class AggregateRule : RuleSet, ISupportsRuleSets
    {
        protected AggregateRule()
        {
            RuleSets = new List<RuleSet>();
        }

        public List<RuleSet> RuleSets { get; private set; }
    }
}


#pragma warning restore