using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSIMS_Model.Models
{
    public class Teacher
    {
        [Key] // Primary key annotation
        public int TeacherId { get; set; }

        [Required]
        [StringLength(100)]
        public string TeacherName { get; set; }

        [StringLength(100)]
        public string TeacherDesig { get; set; }

        [DataType(DataType.Date)]
        public DateTime TeacherDob { get; set; }

        public int DeptId { get; set; }

        [StringLength(50)]
        public string TeacherReligion { get; set; }

        [StringLength(100)]
        public string TeacherFatherName { get; set; }

        [StringLength(100)]
        public string TeacherMotherName { get; set; }

        [StringLength(100)]
        public string TeacherWifeName { get; set; }

        [StringLength(100)]
        public string TeacherSubject { get; set; }

        [StringLength(100)]
        public string TeacherQualification { get; set; }

        [StringLength(20)]
        public string TeacherAdhar { get; set; }

        [StringLength(20)]
        public string TeacherPanNumber { get; set; }

        [StringLength(20)]
        public string TeacherMobileNo1 { get; set; }

        [StringLength(20)]
        public string TeacherMobileNo2 { get; set; }

        [StringLength(100)]
        [EmailAddress]
        public string TeacherEmail { get; set; }

        [StringLength(200)]
        public string TeacherAddress1 { get; set; }

        [StringLength(200)]
        public string TeacherAddress2 { get; set; }

        [StringLength(10)]
        public string TeacherGender { get; set; }

        [DataType(DataType.Date)]
        public DateTime TeacherDoj { get; set; }

        [DataType(DataType.Date)]
        public DateTime? TeacherDoLeaving { get; set; }

        [StringLength(50)]
        public string TeacherClass { get; set; }

        public int TeacherNoofChildren { get; set; }
    }
}
