using BLL.INTERFACES;
using DAL.ENTITIES;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Matrix.Controllers
{
    [Authorize(Roles = "Admin")]
    public class EmpsController : Controller
    {
        IEMP EmpService;
        public EmpsController(IEMP empser)
        {
            EmpService = empser;
        }
        [Authorize(Roles = "Admin")]
        public IActionResult GetAllEmps()
        {
            var AllEmps = EmpService.GetAll();
            return View(AllEmps);
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult AddEmp()
        {
            return View(new SectionStaff());
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult AddEmp(SectionStaff EmpVM)
        {
            if (ModelState.IsValid)
            {
                EmpService.AddEmp(EmpVM);
                return RedirectToAction("GetAllEmps");
            }
            return View(EmpVM);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Deletebutton()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DeleteEmp(int id)
        {
            EmpService.DeleteEmp(id);
            return RedirectToAction("GetAllEmps");
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Profilebutton()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Profile(int id)
        {
            var res = EmpService.GetEmp(id);
            return View(res);
        }
        [HttpPost]
        public IActionResult Savechanges(SectionStaff SST)
        {
            EmpService.SaveChanges(SST);
            return RedirectToAction("GetAllEmps");
        }
        public IActionResult GetAllSection()
        {
            var res = EmpService.GetAllSections();
            return View(res);
        }
        [HttpGet]
        public IActionResult AddSection()
        {
            return View(new Sections());
        }
        [HttpPost]
        public IActionResult AddSection(Sections secVM)
        {
            if (ModelState.IsValid)
            {
                EmpService.AddSection(secVM);
                return RedirectToAction("GetAllSection");
            }
            return View(secVM);
        }
        public IActionResult DeleteSecButton()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DeleteSection(string Name)
        {
            EmpService.DeleteSection(Name);
            return RedirectToAction("GetAllSection");
        }
        public IActionResult GetEmpsInSection(string Name)
        {
            var res = EmpService.GetEmpsInSection(Name);
            return View("GetAllEmps", res);
        }
    }
}
