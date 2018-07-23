
// ReSharper disable once CheckNamespace
#pragma warning disable

namespace ExCSS
{
    public abstract class ConditionalRule : AggregateRule
    {
        public virtual string Condition
        {
            get { return string.Empty; }
            set { }
        }
    }
}


#pragma warning restore