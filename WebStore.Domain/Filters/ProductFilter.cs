using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.Domain.Filters
{
    public class ProductFilter
    {
        // Секция, к которой принадлежит товар
        public int? SectionId { get; set; }
        // Бренд товара
        public int? BrandId { get; set; }
    }
}
