using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSIMS_Model.Models
{
    public class Student
    {
        [Key] // Primary key annotation
        public int StudentId { get; set; }

        [Required]
        [StringLength(100)]
        public string StudentName { get; set; }

        [StringLength(100)]
        public string FatherName { get; set; }

        [StringLength(20)]
        public string FatherMobile { get; set; }

        [StringLength(100)]
        public string FatherDesig { get; set; }

        public decimal FatherSalary { get; set; }

        [StringLength(100)]
        public string MotherName { get; set; }

        [StringLength(20)]
        public string MotherMobile { get; set; }

        [StringLength(50)]
        public string StudentClass { get; set; }

        [StringLength(10)]
        public string StudentSection { get; set; }

        public DateTime StudentDob { get; set; }

        public DateTime StudentDoj { get; set; }

        public int StudentSchoolLeavingYear { get; set; }

        [StringLength(200)]
        public string StudentAddress { get; set; }

        [StringLength(50)]
        public string StudentReligion { get; set; }

        [StringLength(50)]
        public string StudentCast { get; set; }

        [StringLength(10)]
        public string StudentGender { get; set; }

        [StringLength(50)]
        public string StudentNationality { get; set; }

        [StringLength(100)]
        [EmailAddress]
        public string StudentEmail { get; set; }

        [StringLength(50)]
        public string StudentHouse { get; set; }

        [StringLength(20)]
        public string StudentAdharNumber { get; set; }

        [StringLength(20)]
        public string StudentPenNumber { get; set; }

    }
}
