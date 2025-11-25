using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SezenElifCaba_BlogSitesi.Models.Context;
using SezenElifCaba_BlogSitesi.Models.Entities;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace SezenElifCaba_BlogSitesi.Controllers
{
    [AllowAnonymous]
    public class SecurityController : Controller
    {

        private readonly ProjectContext db;

        public SecurityController(ProjectContext db)
        {
            this.db = db;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string userName,string Password)
        {

            User girisYapanKullanici = db.Users.FirstOrDefault(x => x.UserName == userName && x.Password == Password);

            if (girisYapanKullanici != null)
            {

                var claim = new List<Claim>()
                {

                    new Claim("ID",girisYapanKullanici.UserID.ToString()),
                    new Claim(ClaimTypes.Name,girisYapanKullanici.Name),
                    new Claim(ClaimTypes.Surname,girisYapanKullanici.Surname),
                    new Claim("UserName",girisYapanKullanici.UserName),
                    new Claim(ClaimTypes.Role,girisYapanKullanici.Role),

                }; 

                var userIdentity = new ClaimsIdentity(claim, CookieAuthenticationDefaults.AuthenticationScheme); 

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal); 

                return RedirectToAction("Index", "Admin");

            }

            else
            {

                ViewBag.Mesaj = "Kullanıcı adı veya şifre hatalıdır! Tekrar deneyiniz.";
                return View();

            }

        }

        public async Task<IActionResult> LogOut()
        {

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return View("Login");

        }

        public IActionResult ErisimEngellendi()
        {
            return View();
        }

    }
}
