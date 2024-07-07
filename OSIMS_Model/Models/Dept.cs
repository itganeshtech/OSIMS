using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSIMS_Model.Models
{
    public class Dept
    {
        [Key] // Primary key annotation
        public int DeptId { get; set; }

        [Required]
        [StringLength(100)]
        public string DeptName { get; set; }

        [StringLength(100)]
        public string DeptHead { get; set; }

        [StringLength(100)]
        public string DeptLocation { get; set; }

    }
}
