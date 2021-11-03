using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamApiSBA.Models
{
    
    public class Employee
    {
        [Key]
        public int? Id { get; set; }
        [Required]
        [Display(Name = "Employee Name cannot be empty")]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }
        [Required(ErrorMessage ="Salary cannot be empty")]
        public float Salary { get; set; }
        [Required(ErrorMessage = "Department ID cannot be empty")]
        public int DID { get; set; }
        [ForeignKey("DID")]
        public virtual Department departments { get; set; }

    }
}