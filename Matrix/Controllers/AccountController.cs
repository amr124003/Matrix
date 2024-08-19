using BLL.INTERFACES;
using DAL.ENTITIES;
using Matrix.VM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Matrix.Controllers
{
    public class AccountController : Controller
    {
        UserManager<ApplicationUser> userManager;
        SignInManager<ApplicationUser> signInManager;
        IAccount Accountservice;
        public AccountController(UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> _signInManager, IAccount Accservice)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            Accountservice = Accservice;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View(new UserVM());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserVM UserVM)
        {
            if (ModelState.IsValid && UserVM.Agree)
            {
                ApplicationUser applcationUser = new();
                applcationUser.UserName = UserVM.Name;
                applcationUser.Email = UserVM.Email;
                applcationUser.Address = UserVM.Address;
                applcationUser.PasswordHash = UserVM.Password;
                applcationUser.PhoneNumber = UserVM.PhoneNumber;
                applcationUser.Country = UserVM.Country;
                var newuser = await userManager.CreateAsync(applcationUser, UserVM.Password);
                if (newuser.Succeeded)
                {
                    await userManager.AddToRoleAsync(applcationUser, "User");
                    await signInManager.SignInAsync(applcationUser, false);
                    return RedirectToAction("GetAll", "Product");
                }
                else
                {
                    foreach (var error in newuser.Errors)
                    {
                        ModelState.AddModelError("Password", error.Description);
                    }

                }

            }
            if (!UserVM.Agree)
            {
                ModelState.AddModelError("Agree", "You Must Agree With Terms");
            }
            return View(UserVM);


        }
        [Authorize]
        public IActionResult Logout()
        {
            signInManager.SignOutAsync();
            return RedirectToAction("GetAll", "Product");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new UserLogin());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UserLogin user)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser userapp = await userManager.FindByNameAsync(user.Name);
                if (userapp != null)
                {
                    bool Passcorrect = await userManager.CheckPasswordAsync(userapp, user.Password);
                    if (Passcorrect)
                    {
                        await signInManager.SignInAsync(userapp, user.RemeberMe);
                        return RedirectToAction("GetAll", "Product");
                    }
                    else if (!Passcorrect)
                    {
                        ModelState.AddModelError("Password", "Incorrect Password");
                        return View(user);
                    }
                    else
                    {
                        ModelState.AddModelError("Email", "Incorrect Eamil");
                    }
                }
                else
                {
                    ModelState.AddModelError("UserName", "The User Name Not Found");
                }
            }
            return View(user);
        }
        [HttpGet]
        //[Authorize(Roles ="Admin")]
        public IActionResult AddAdmin()
        {
            return View(new UserVM());
        }
        //[Authorize(Roles ="Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddAdmin(UserVM userVm)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser userapp = new();
                userapp.UserName = userVm.Name;
                userapp.Email = userVm.Email;
                userapp.PhoneNumber = userVm.PhoneNumber;
                userapp.Country = userVm.Country;
                userapp.Address = userVm.Address;
                userapp.PasswordHash = userVm.Password;
                var res = await userManager.CreateAsync(userapp, userVm.Password);

                if (res.Succeeded)
                {
                    await userManager.AddToRoleAsync(userapp, "Admin");
                    await signInManager.SignInAsync(userapp, false);
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
            return View(userVm);
        }
        public IActionResult Profile(string UserId)
        {
            ApplicationUser User = Accountservice.Profile(UserId);
            return View(User);
        }
        public IActionResult SavingChanges(ApplicationUser user)
        {
            Accountservice.SaveChanges(user);
            return RedirectToAction("GetAll", "Product");
        }


    }
}
