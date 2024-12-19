﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CfirstApproach.Models
{
    public class Employeee
    {
        [Key]
        public int Id { get; set; }

        [Column("EmployeeName", TypeName = "varchar(100)")]
        [Required]
        public string Name { get; set; }

        [Column("EmployeeGender", TypeName = "varchar(10)")]
        [Required]
        public string Gender { get; set; }

        [Required]
        public int Age { get; set; }

        [Column("EmployeeCity", TypeName = "varchar(10)")]
        [Required]
        public string City { get; set; }

    }
}
