using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project_08.Models;

namespace Project_08.Controllers
{
    public class AccountController : Controller
    {
        SignInManager<ApplicationUser> _signInManager;
        UserManager<ApplicationUser> _userManager;
        RoleManager<ApplicationRole> _rollManager;
        ApplicationDbContext _applicationDbContext;

        public AccountController(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> rollManager, ApplicationDbContext applicationDbContext, SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _rollManager = rollManager;
            _applicationDbContext = applicationDbContext;
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult RollMappingToUserList()
        {


            List<DropDownListValue> ddlv = _userManager.Users.ToList().Select(s => new DropDownListValue { Id = s.Email, Name = s.Email }).ToList();

            var ViewDropDown = new ViewDropDown()
            {
                DropDownListValues = ddlv,
                DropdownName = "MyDropDownl"
            };


            return View(ViewDropDown);
        }

        [HttpPost]
        public IActionResult RollMappingToUserList(string UserName)
        {
            string url = "RollMappingToUser?UserName=" + UserName;

            return Redirect(url);

        }

        public IActionResult RollMappingToUser(string UserName)
        {
            ViewData["UserName"] = UserName;
            List<UserRollMapping> RollList = new List<UserRollMapping>();
            foreach (var r in _rollManager.Roles.ToList())
            {
                RollList.Add(new UserRollMapping() { Role = r, IsChecked = true });
            }


            return View(RollList);
        }


        [HttpPost]
        public async Task<IActionResult> RollMappingToUser(IList<UserRollMapping> applicationRoles, string UserName)
        {

            try
            {
                var user = _userManager.Users.Where(w => w.Email == UserName).FirstOrDefault();

                foreach (var k in applicationRoles)
                {
                    if (k.IsChecked == true)
                    {
                        await _userManager.AddToRoleAsync(user, k.Role.Name);
                    }

                }
                return RedirectToAction("Index", "Home");

            }
            catch (Exception ex)
            {
                return View();
            }




        }


        public IActionResult Roll()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Roll(string RollName)
        {

            ApplicationRole role = new ApplicationRole()
            {
                Name = RollName,
                NormalizedName = RollName
            };

            IdentityResult result = await _rollManager.CreateAsync(role);

            if (result.Succeeded)
            {

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }


        }


        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(string FirstName, string LastName, string Email, string Password, int registerId)
        {

           

            ApplicationUser user = new ApplicationUser()
            {
                Email = Email,
                UserName = Email,
                FirstName = FirstName,
                LastName = LastName
            };
            IdentityResult result = await _userManager.CreateAsync(user, Password);

            if (result.Succeeded)
            {
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }


        }


        [HttpPost]

        public async Task<IActionResult> Login(string userName, string password, string ReturnUrl)
        {
            var userAll = _userManager.Users.ToList();

            if (!string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(password))
            {
                return RedirectToAction("Login");

            }
            try
            {
                var UserInstance = _userManager.Users.Where(w => w.Email == userName).FirstOrDefault();

                var userRole = _applicationDbContext.UserRoles.Where(w => w.UserId == UserInstance.Id).ToList();
                var roleList = _applicationDbContext.Roles.Join(userRole, a => a.Id, b => b.RoleId, (a, b) => new { roleName = a.Name }).ToList();
               

                IList<string> rolesList = new List<string>();
                foreach(var ro in roleList)
                {
                    rolesList.Add(ro.roleName.ToString());
                }

                bool yesFound = await _userManager.CheckPasswordAsync(UserInstance, password);

                if (!yesFound)
                {
                    return RedirectToAction("Index", "Home");
                }


                var customClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, UserInstance.UserName)
            };

                foreach (string s in rolesList)
                {
                    customClaims.Add(new Claim(ClaimTypes.Role, s));
                }

                var claimsIdentity = new ClaimsIdentity(customClaims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);



                await _signInManager.Context.SignInAsync(IdentityConstants.ApplicationScheme,
                    claimsPrincipal, new AuthenticationProperties { IsPersistent = false, RedirectUri = "/Home/Index" });



            }
            catch (Exception e)
            {
                return RedirectToAction("Login");
            }

            return View();


        }

        public IActionResult Denied()
        {

            return RedirectToAction("Login");
        }

        [HttpPost]

        public async Task<IActionResult> Logout()
        {
            await _signInManager.Context.SignOutAsync();


            return RedirectToAction("Login");
        }

        [HttpGet]

        [ActionName("Logout")]
        public async Task<IActionResult> LogoutGet()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            await _signInManager.SignOutAsync();
            HttpContext.Response.Cookies.Delete("YourAppCookieName");

            return RedirectToAction("Login");
        }
    }
}