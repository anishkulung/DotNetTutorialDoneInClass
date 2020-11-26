using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplicationCandy.Models {
    public class model1 {
        [Required(ErrorMessage = "Name should be minimum 3 characters and a maximum of 50 characters")]
        [Display(Name = "FullName")]
        [StringLength(50), MinLength(3)]
        public string FullName { get; set; }
        [Required]
        [Display(Name = "Salary")]
        public double Salary { get; set; }
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
