using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingList.Common.Enums
{
    public enum EAccountRole : byte
    {
        Guest = 1,
        User = 2,
        Moderator = 10,
        Admin = 63
    }
}
