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
    public class TiposUsuariosController : Controller
    {
        private readonly PruebaContext _db;

        public TiposUsuariosController(PruebaContext pruebaContext)
        {
            _db = pruebaContext;
        }


        // GET: TiposUsuariosController
        public ActionResult Index()
        {
            return View(_db.Tipos_Usuarios.ToList());
        }

        // GET: TiposUsuariosController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Index));
            }

            tbl_Tipos_usuarios tipos_usuarios = _db.Tipos_Usuarios.Find(id);

            if (tipos_usuarios == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(tipos_usuarios);
        }

        // GET: TiposUsuariosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TiposUsuariosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(tbl_Tipos_usuarios tipos_usuarios)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _db.Tipos_Usuarios.Add(tipos_usuarios);
                    _db.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(tipos_usuarios);
            }
        }

        // GET: TiposUsuariosController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Index));
            }

            tbl_Tipos_usuarios tipos_Usuarios = _db.Tipos_Usuarios.Find(id);

            if (tipos_Usuarios == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(tipos_Usuarios);
        }

        // POST: TiposUsuariosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(tbl_Tipos_usuarios tipos_Usuarios)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _db.Entry(tipos_Usuarios).State = EntityState.Modified;
                    _db.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(tipos_Usuarios);
            }
        }

        // GET: TiposUsuariosController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Index));
            }

            tbl_Tipos_usuarios tipos_usuarios = _db.Tipos_Usuarios.Find(id);

            if (tipos_usuarios == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(tipos_usuarios);
        }

        // POST: TiposUsuariosController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            tbl_Tipos_usuarios tipos_usuarios = _db.Tipos_Usuarios.Find(id);
            
            try
            {
                _db.Tipos_Usuarios.Remove(tipos_usuarios);
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(tipos_usuarios);
            }
        }
    }
}
