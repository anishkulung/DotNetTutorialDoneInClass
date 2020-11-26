using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCandy.Models {
    public class WebUser {
        [Column("UserID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        [Display(Name = "FirstName")]
        [Required]
        [StringLength(50), MinLength(3)]
        public string FirstName { get; set; }
        [Display(Name = "LastName")]
        [Required]
        [StringLength(50), MinLength(3)]
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
