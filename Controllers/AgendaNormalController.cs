using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Prueba_Web.Data;
using Prueba_Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Prueba_Web.Controllers
{
    public class AgendaNormalController : Controller
    {
        private readonly PruebaContext _db;

        public AgendaNormalController(PruebaContext pruebaContext)
        {
            _db = pruebaContext;
        }

        public IActionResult Index()
        {
            ViewBag.actividades = _db.Control_Actividades.Include(t => t._Usuarios).ToList();

            return View();
        }

        public IActionResult Marcacion(int? usuario)
        {

            var marcaciones = (from marca in _db.Marcaciones where marca.Id_usuario == (int)usuario select marca).LastOrDefault();

            if (marcaciones.Fecha_marcacion == DateTime.Now.Date)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                tbl_Marcaciones marcar = new tbl_Marcaciones();
                marcar.Fecha_marcacion = DateTime.Now.Date;
                marcar.Id_usuario = (int)usuario;

                tbl_Control_actividades control_Actividades = new tbl_Control_actividades();
                control_Actividades.Actividades = 1;
                control_Actividades.Id_usuario = (int)usuario;
                control_Actividades.Fecha_actividad = DateTime.Now.Date;

                _db.Marcaciones.Add(marcar);
                _db.Control_Actividades.Add(control_Actividades);
                _db.SaveChanges();
            }         
            
            return RedirectToAction(nameof(Index));
        }
    }
}
