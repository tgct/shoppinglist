using System;

namespace ShoppingList.Common.Attributes
{
    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    sealed class MetricAttribute : Attribute
    {
        public MetricAttribute()
        {
        }
    }
}
