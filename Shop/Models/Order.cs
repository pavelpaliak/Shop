using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Shop.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Wpisz swoje imie")]
        [StringLength(10)]
        [Required(ErrorMessage = "Maksymalnie można wprowadzić 10 symboli")]
        public string name { get; set; }

        [Display(Name = "Wpisz swoje nazwisko ")]
        [StringLength(20)]
        [Required(ErrorMessage = "Maksymalnie można wprowadzić 20 symboli")]
        public string surname { get; set; }

        [Display(Name = "Wpisz swów adres")]
        [StringLength(40)]
        [Required(ErrorMessage = "Maksymalnie można wprowadzić 40 symboli")]
        public string adress { get; set; }

        [Display(Name = "Wpisz swój telefon")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10)]
        [Required(ErrorMessage = "Maksymalnie można wprowadzić 10 symboli")]
        public string phone { get; set; }

        [Display(Name = "Wpisz swój email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(30)]
        [Required(ErrorMessage = "Maksymalnie można wprowadzić 30 symboli")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}
