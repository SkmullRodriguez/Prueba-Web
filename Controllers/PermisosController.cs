using Microsoft.AspNetCore.Http;
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
    public class PermisosController : Controller
    {
        private readonly PruebaContext _db;

        public PermisosController(PruebaContext pruebaContext)
        {
            _db = pruebaContext;
        }

        // GET: PermisosController
        public ActionResult Index()
        {
            var permisos = _db.Permisos.Include(t => t._Usuarios);
            return View(permisos.Where(s=>s._Usuarios.Estado == true && s.Estado == true).ToList());
        }

        // GET: PermisosController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Index));
            }

            tbl_Permisos permisos = _db.Permisos.Find(id);

            if (permisos == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(permisos);
        }

        // GET: PermisosController/Create
        public ActionResult Create()
        {
            ViewBag.Id_usuario = new SelectList(_db.Usuarios.Where(s => s.Estado == true), "Id_usuario", "Nombre");
            return View();
        }

        // POST: PermisosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(tbl_Permisos permisos)
        {
            try
            {
                permisos.Estado = true;

                _db.Permisos.Add(permisos);
                _db.SaveChanges();                

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewBag.Id_usuario = new SelectList(_db.Usuarios.Where(s => s.Estado == true), "Id_usuario", "Nombre");
                return View(permisos);
            }
        }

        // GET: PermisosController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Index));
            }

            tbl_Permisos permisos = _db.Permisos.Find(id);

            if (permisos == null)
            {
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Id_usuario = new SelectList(_db.Usuarios.Where(s => s.Estado == true), "Id_usuario", "Nombre");
            return View(permisos);
        }

        // POST: PermisosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(tbl_Permisos permisos)
        {
            try
            {
                permisos.Estado = true;

                _db.Entry(permisos).State = EntityState.Modified;
                _db.SaveChanges();
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewBag.Id_usuario = new SelectList(_db.Usuarios.Where(s => s.Estado == true), "Id_usuario", "Nombre");
                return View(permisos);
            }
        }

        // GET: PermisosController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Index));
            }

            tbl_Permisos permisos = _db.Permisos.Find(id);

            if (permisos == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(permisos);
        }

        // POST: PermisosController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                tbl_Permisos permisos = _db.Permisos.Find(id);

                permisos.Estado = false;

                _db.Entry(permisos).State = EntityState.Modified;
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
