using ShoppingList.Common.Attributes;

namespace ShoppingList.Common.Enums
{
    public enum EUnit : byte
    {
        [Metric]
        Kilo = 1,
        Piece = 2,
        [Metric]
        Liter = 3
        // add more here
    }
}