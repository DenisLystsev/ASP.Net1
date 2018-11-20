using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Models.Base;

namespace WebStore.Models
{
    public class SectionViewModel : INamedEntity, IOrderedEntity
    {
        public SectionViewModel()
        {
            ChieldSections = new List<SectionViewModel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }

        //Дочерние секции
        public List<SectionViewModel> ChieldSections { get; set; }

        //Родительская секция
        public SectionViewModel ParentSection { get; set; }
    }
}
