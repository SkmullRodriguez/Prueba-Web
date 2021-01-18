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
    public class AgendasAdminController : Controller
    {
        private readonly PruebaContext _db;

        public AgendasAdminController(PruebaContext pruebaContext)
        {
            _db = pruebaContext;
        }

        public IActionResult Index()
        {
            var usuario = _db.Usuarios.Where(t=> t.Estado == true);

            return View(usuario.ToList());
        }

        public IActionResult Revision(int Id)
        {
            /* comentario
             
            en esta seccion se revisaria la actividad de cada usuario desde la vista se mandaria el id
            este serviria para buscar las actividades del mismo y poder mostrarlas en una tabla
            ademas se lleva el listado de los permisos para validar las fechas y saber si el usuario a tenido algun permiso o no
            y asi poder mostrarlo en la tabla
             */
            
            var actividades = from act in _db.Control_Actividades where act.Id_usuario == Id select act;

            ViewBag.permisos = (from per in _db.Permisos where per.Id_usuario == Id && per.Estado==true select per).ToList();
            return View(actividades.ToList());
        }
    }
}
