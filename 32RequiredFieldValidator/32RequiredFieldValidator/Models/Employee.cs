using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _32RequiredFieldValidator.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        //[Required ( ErrorMessage="First Name can not be blank.")]
        //[Required(ErrorMessageResourceName="RequiredFieldMessage",ErrorMessageResourceType=typeof(Resource1))]
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
    }
}