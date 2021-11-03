using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamApiSBA.Models
{
    public class Department
    {
        [Key]
        public int Dept_Id { get; set; }
        [Required]
        [Display(Name = "Department Name cannot be empty")]
        public string Dept_Name { get; set; }
    }
}