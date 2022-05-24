using ConsultasMVC;
using EnerSave.Views.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
namespace EnerSave.Controllers
{
    public class LoginController : Controller
    {

        private readonly IUsuarioStore _model;

        public LoginController(IUsuarioStore model)
        {
            _model = model;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UsuarioViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_model.LoginAsync(model.Login, model.Senha).Result)
                {
                    var token = TokenService.GenerateToken(model);

                    HttpContext.Request.Headers.Add("Bearer", token);

                    return Redirect("/");
                }
            }
            return View();
        }
    }
}
