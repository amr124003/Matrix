using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ENTITIES
{
    public class SectionStaff
    {
        public int Id { get; set; }
        public string EmpName { get; set; }

        [RegularExpression("(Laptops|Camreras|Phones|HeadPhones)")]
        public string SectionName { get; set; }
        public virtual Staff? Staff { get; set; }
        public virtual Sections? Sections { get; set; }

        public List<string>? Mangers { get; set; }
    }
}
