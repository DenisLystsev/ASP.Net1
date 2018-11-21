using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Models.Base;

namespace WebStore.Domain.Models
{
    public class Product : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
        // Секция, к которой принадлежит товар
        public int SectionId { get; set; }
        // Бренд товара
        public int? BrandId { get; set; }
        // Ссылка на картинку
        public string ImageUrl { get; set; }
        // Цена
        public decimal Price { get; set; }
    }
}
