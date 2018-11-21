using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Models;
using WebStore.Domain.Filters;

namespace WebStore.Infrastructure.Interfaces
{
    public interface IProductData
    {
        //Список секций
        IEnumerable<Section> GetSections();

        //Список брендов
        IEnumerable<Brand> GetBrands();

        //Список товаров
        IEnumerable<Product> GetProducts(ProductFilter filter);
    }
}
