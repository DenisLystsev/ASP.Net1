using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Models.Base;

namespace WebStore.Domain.Models
{
    public class Section : OrderedEntity
    {
        //Родительская секция
        public int? ParentId { get; set; }
    }
}
