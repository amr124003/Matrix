using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ENTITIES
{
    public class Sections
    {
        [Key]
        [Required]
        [MaxLength(20)]
        [MinLength(5)]
        public string Name { get; set; }

        public virtual List<Staff>? Staffs { get; set; }
        public virtual List<SectionStaff>? secstaff { get; set; }
    }
}
