using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PagingAndSorting.Entities
{
    public class EmployeeMaster
    {
        [Required(ErrorMessage = "Please Enter Email")]
        public string Email { get; set; }

        [Key]
        public string ID { get; set; }

        [Required(ErrorMessage = "Please Enter Employee Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please Enter Salary")]
        public decimal Salary { get; set; }
    }
}