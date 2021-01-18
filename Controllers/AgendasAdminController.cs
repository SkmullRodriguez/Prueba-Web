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
            ViewBag.actividades = _db.Usuarios.Where(t=> t.Estado == true).ToList();

            return View();
        }

        public IActionResult Revision(int Id)
        {
            /* comentario
             
            en esta seccion se revisaria la actividad de cada usuario desdfe la vista se mandaria el id que es con el que el usuario se ha registrado
            este serviria para buscar las actividades del mismo y poder mostrarlas en una tabla
            ademas se lleva el listado de los permisos para validar las fechas y saber si el usuario a tenido algun permiso o no
            y asi poder mostrarlo en la tabla
             */
            
            //var usuarios = (from usuario in _db.Usuarios where usuario.Id_usuario == Id select usuario.Id_usuario);
            //var actividades = from act in _db.Control_Actividades where act.Id_usuario == usuarios select act;

            //ViewBag.permisos = _db.Permisos;


            return View();
        }
    }
}
