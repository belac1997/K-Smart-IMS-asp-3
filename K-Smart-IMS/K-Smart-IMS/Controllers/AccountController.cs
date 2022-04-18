using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using K_Smart_IMS.Models;

/*Effectively a login controller that leverages the aspnetcore identity class to create and utilize user authorization
 * Contributed by Cody Tran
 */

namespace K_Smart_IMS.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> userManager;
        private SignInManager<User> signInManager;

        public AccountController(UserManager<User> userMngr,
            SignInManager<User> signInMngr)
        {
            userManager = userMngr;
            signInManager = signInMngr;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {

            if (ModelState.IsValid)
            {
                //creation of user account here should have password hashing if you can check on this Will
                var user = new K_Smart_IMS.Models.User { UserName = model.Username };
                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent : false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors) 
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(
                    model.Username, model.Password, isPersistent: model.RememberMe,
                    lockoutOnFailure: true);

                if (result.Succeeded)//succesfull log in
                {
                    if (!string.IsNullOrEmpty(model.ReturnUrl) &&
                        Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                if (result.IsLockedOut)//Lock out test.
                {
                    ModelState.AddModelError("", "Account is Locked out.");
                }
                else//wrong password test
                {
                    ModelState.AddModelError("", "Invalid username/password.");
                }
            }
            return View(model);
        }

        //we should add an access denied to some pages just in case to handle edge cases where pages are navigated to without user access
        public ViewResult AccessDenied()
        {
            return View();
        }
    }
}
