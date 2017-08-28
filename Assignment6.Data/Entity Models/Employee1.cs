using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Data.Entity_Models
{
    public class Employee1
    {
        [Key]
        public int EId { get; set; }

        [Required(ErrorMessage = "Name Required")]
        [StringLength(20)]
        public string EName { get; set; }

        [Required(ErrorMessage = "Email Required")]
        [StringLength(20)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone No. Required")]
        public long Phone { get; set; }

        [Required(ErrorMessage = "Marital Status Required")]
        public bool MaritalStatus { get; set; }

        [Required(ErrorMessage = "State Required")]
        public string State { get; set; }

        [Required(ErrorMessage = "City Required")]
        public string City { get; set; }
        
    }
}
