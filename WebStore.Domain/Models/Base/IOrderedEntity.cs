using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.Domain.Models.Base
{
    public interface IOrderedEntity : INamedEntity
    {
        //Порядок
        int Order { get; set; }
    }
}
