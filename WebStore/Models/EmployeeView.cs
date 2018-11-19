using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class EmployeeView
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Имя является обязательным")]
        [Display(Name = "Имя")]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = "В имени должно быть не менее двух символов")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Отчество является обязательным")]
        [Display(Name = "Отчество")]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = "В отчестве должно быть не менее двух символов")]
        public string Patronymic { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Фамилия является обязательным")]
        [Display(Name = "Фамилия")]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = "В фамилии должно быть не менее двух символов")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Возраст является обязательным")]
        [Display(Name = "Возраст")]
        public int Age { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Должность является обязательным")]
        [Display(Name = "Должность")]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = "В названии должности должно быть не менее двух символов")]
        public string Position { get; set; }
    }
}
