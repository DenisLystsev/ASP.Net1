using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.Domain.Models.Base
{
    interface IOrderedEntity : INamedEntity
    {
        //Порядок
        int Order { get; set; }
    }
}
