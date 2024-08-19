using BLL.INTERFACES;
using DAL.CONTEXT;
using DAL.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.REPOSITORY
{
    public  class EmpRepo : IEMP
    {
        ApplicationDBcontext _context;
        public EmpRepo(ApplicationDBcontext context)
        {
            _context = context;
        }

        public void AddEmp(SectionStaff record)
        {
            Staff Staff = new Staff();
            Staff.Name = record.EmpName;
            _context.staffs.Add(Staff);
            SectionStaff sectionStaff = new();
            sectionStaff.EmpName = record.EmpName;
            sectionStaff.SectionName = record.SectionName;
            _context.sectionStaffs.Add(sectionStaff);
            _context.SaveChanges();
        }

        public void AddSection(Sections secvm)
        {
            Sections sections = new();
            sections.Name = secvm.Name;
            _context.sections.Add(sections);
            _context.SaveChanges();
        }

        public void DeleteEmp(int id)
        {
            var Deleted = _context.sectionStaffs.FirstOrDefault(x => x.Id == id);
            var res = _context.sectionStaffs.Remove(Deleted);
            _context.SaveChanges();
        }

        public void DeleteSection(string Name)
        {
            var deleted = _context.sections.FirstOrDefault(x => x.Name == Name);
            _context.sections.Remove(deleted);
            _context.SaveChanges();
        }

        public List<SectionStaff> GetAll()
        {
            return _context.sectionStaffs.ToList();
        }

        public List<Sections> GetAllSections()
        {
            return _context.sections.Where(x => x.Name != "Phones").ToList();
        }

        public SectionStaff GetEmp(int id)
        {
            return _context.sectionStaffs.FirstOrDefault(x => x.Id == id);
        }

        public List<SectionStaff> GetEmpsInSection(string Name)
        {
            var StaffInsection = _context.sectionStaffs.Where(x => x.SectionName == Name).ToList();
            return StaffInsection;
        }

        public void SaveChanges(SectionStaff SST)
        {
            var SecStaff = _context.sectionStaffs.FirstOrDefault(x => x.Id == SST.Id);
            SecStaff.EmpName = SST.EmpName;
            SecStaff.SectionName = SST.SectionName;
            _context.SaveChanges();
        }


    }
}
