using System.ComponentModel.DataAnnotations;

namespace TestApp.Models
{
    public class Emp
    {
           
        
        [Required(ErrorMessage ="Field is required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [StringLength(10,ErrorMessage ="only 10 characters allowed")]
        public string? Name { get; set; }

        [Required(ErrorMessage ="Field is required")]
        [Range(minimum:10000,maximum:100000,ErrorMessage ="hyERHFJ")]
        public double salary { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [EmailAddress]
        public string email {  get; set; }

        [Required(ErrorMessage = "Field is required")]
        [Phone]
        public string contactNumber { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [RegularExpression(pattern: "[A-Z]{5}[0-9]{4}[A-Z]{1}")]
        public string panCard {  get; set; }

        [Url]
        public string URL {  get; set; }

        [CreditCard]
        public string creditCard { get; set; }

    }
}

