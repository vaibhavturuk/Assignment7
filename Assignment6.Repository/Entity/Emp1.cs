using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6.Repository.Entity
{
    public class Emp1
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name Required")]
        [StringLength(20)]
        public string Name { get; set; }
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
