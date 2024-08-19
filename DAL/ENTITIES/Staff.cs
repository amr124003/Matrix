using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ENTITIES
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int? MangerId { get; set; }
        public List<Sections>? sections { get; set; }
        public List<SectionStaff>? staffs { get; set; }
    }
}
