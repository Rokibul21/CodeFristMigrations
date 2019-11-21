using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFastMigration2.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string RegNo { get; set; }
        [Required]
        public string Passoward{ get; set; }
        [Required]
        public string ConfrumPassoward { get; set; }
        [Required]
        public int DepartmentId { get; set; }
        public virtual Departments Departments { get; set; }

    }
}