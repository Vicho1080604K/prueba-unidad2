using prueba.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace prueba.Controllers
{
    public class CuentaController : Controller
    {
        private readonly MercyDeveloperContext db;

        public CuentaController(MercyDeveloperContext context)
        {
            db = context;
        }

        // GET: /Cuenta/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Cuenta/Login
        [HttpPost]
        public IActionResult Login(string correo, string password)
        {
            var usuario = db.Usuarios.FirstOrDefault(c => c.Correo == correo && c.Password == password);

            if (usuario != null)
            {
                HttpContext.Session.SetString("UsuarioCorreo", usuario.Correo);
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Mensaje = "Correo o contraseña incorrecto";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
