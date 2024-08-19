using Matrix.VM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Matrix.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        RoleManager<IdentityRole> roleManager;
        public RoleController(RoleManager<IdentityRole> _roleManger)
        {
            roleManager = _roleManger;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult New()
        {
            return View(new RoleVM());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> New(RoleVM RoleVM)
        {
            if (ModelState.IsValid)
            {
                IdentityRole idRole = new();
                idRole.Name = RoleVM.Name;
                var res = await roleManager.CreateAsync(idRole);
                if (res.Succeeded)
                {
                    return RedirectToAction("GetAll", "Product");
                }
                else
                {
                    foreach (var error in res.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(RoleVM);
        }
    }
}
