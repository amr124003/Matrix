using DAL.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.INTERFACES
{
    public interface IEMP
    {
        List<SectionStaff> GetAll();
        void AddEmp(SectionStaff record);
        void DeleteEmp(int id);
        SectionStaff GetEmp(int id);
        void SaveChanges(SectionStaff SST);
        List<Sections> GetAllSections();
        void AddSection(Sections secvm);
        void DeleteSection(string Name);
        public List<SectionStaff> GetEmpsInSection(string Name);

    }
}
