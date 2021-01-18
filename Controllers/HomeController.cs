using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Prueba_Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Session;

using Prueba_Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Prueba_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly PruebaContext _db;

        public HomeController(PruebaContext pruebaContext)
        {
            _db = pruebaContext;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Login(string carnet, string pwd)
        {
            try
            {
                var usuarios = _db.Usuarios.Include(s => s.Tbl_Tipos_Usuarios).Where(t => t.Estado == true).ToList();
                foreach(var usuario in usuarios)
                {
                    if(usuario.Carnet == carnet && usuario.Pass == pwd)
                    {
                        if(usuario.Tbl_Tipos_Usuarios.Nombre == "Administrador")
                        {
                            
                            return RedirectToAction(nameof(PanelAdmin));
                        }
                        else if(usuario.Tbl_Tipos_Usuarios.Nombre == "Normal")
                        {
                            
                            return RedirectToAction(nameof(Panel));
                        }
                    }
                }
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }

        }

        public IActionResult Panel()
        {
            return View();
        }

        public IActionResult PanelAdmin()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
