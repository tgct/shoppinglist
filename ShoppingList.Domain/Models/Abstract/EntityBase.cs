using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingList.Domain.Models.Abstract
{
    public abstract class EntityBase<T> : IEntity
    {
        public T Id { get; set; }
    }
}
