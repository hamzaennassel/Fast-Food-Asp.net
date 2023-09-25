using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using AuthProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Plat1.Controllers
{
    public class AccessController : Controller
    {
        public IActionResult Login()
        {
            ClaimsPrincipal claimUser = HttpContext.User;
            if (claimUser.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Admin");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>  Login(VMLogin modelLogin)
        {
            if (modelLogin.Email == "hamza@exemple.com" && modelLogin.Password == "123")
            {
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier, modelLogin.Email),
                    new Claim("OtherPropreties", "Exemple Role")
                };
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
                               CookieAuthenticationDefaults.AuthenticationScheme);

                AuthenticationProperties properties = new AuthenticationProperties()
                {
                    AllowRefresh = true,
                    IsPersistent = modelLogin.KeepLoggedIn
                };
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), properties);
                return RedirectToAction("Index", "Admin");
            }
            ViewData["ValidateMessage"] = "User Not Found";
            return View();
        }
    }
}
