using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DFA_CORE.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter the Trainee Name")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Name must consist of minimum 3 characters")]
        [RegularExpression(@"^([A-Za-z]+)$")]
        public string? Name { get; set; }
        [Required]
        public string? Designation { get; set; }
    }
}
