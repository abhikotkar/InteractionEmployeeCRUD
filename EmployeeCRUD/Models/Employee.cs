using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCRUD.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Employee first name is required")]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public string Fname { get; set; }

        [Required(ErrorMessage = "Employee middle name is required")]
        [DataType(DataType.Text)]
        [Display(Name = "Middle Name")]
        public string Mname { get; set; }

        [Required(ErrorMessage = "Employee last name is required")]
        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        public string Lname { get; set; }

        [Required(ErrorMessage = "Employee gender is required")]
        [DataType(DataType.Text)]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Employee DOB is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Date Of Birth")]
        public string DOB { get; set; }

        [Required(ErrorMessage = "Employee address is required")]
        [DataType(DataType.Text)]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Employee city is required")]
        [DataType(DataType.Text)]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Employee pincode is required")]
        [DataType(DataType.Text)]
        [Display(Name = "Pincode")]
        public string Pincode { get; set; }

        [Required(ErrorMessage = "Employee mobile number is required")]
        [DataType(DataType.Text)]
        [Display(Name = "Mobile Number")]
        public string Mobile { get; set; }
    }
}
