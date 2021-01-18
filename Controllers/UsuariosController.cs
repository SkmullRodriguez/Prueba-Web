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
    public class UsuariosController : Controller
    {
        private readonly PruebaContext _db;

        public UsuariosController(PruebaContext pruebaContext)
        {
            _db = pruebaContext;
        }

        // GET: UsuariosController
        public ActionResult Index()
        {
            //var usuario = _db.Usuarios.Where(s => s.Estado == true);
            var Usuarios = _db.Usuarios.Include(t => t.Tbl_Tipos_Usuarios);

            return View(Usuarios.Where(s => s.Estado == true).ToList());
        }

        // GET: UsuariosController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Index));
            }
            
            tbl_Usuarios usuarios = _db.Usuarios.Find(id);
            
            if (usuarios == null)
            {
                return RedirectToAction(nameof(Index));
            }


            return View(usuarios);
        }

        // GET: UsuariosController/Create
        public ActionResult Create()
        {
            
            ViewBag.Id_tipo_usuario = new SelectList(_db.Tipos_Usuarios, "Id_tipo_usuario", "Nombre");

            return View();
        }

        // POST: UsuariosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(tbl_Usuarios usuarios)
        {
            try
            {
                usuarios.Estado = true;
                    
                _db.Usuarios.Add(usuarios);
                _db.SaveChanges();
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewBag.Id_tipo_usuario = new SelectList(_db.Tipos_Usuarios, "Id_tipo_usuario", "Nombre");
                return View(usuarios);
            }
        }

        // GET: UsuariosController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Index));
            }

            tbl_Usuarios usuarios = _db.Usuarios.Find(id);

            if (usuarios == null)
            {
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Id_tipo_usuario = new SelectList(_db.Tipos_Usuarios, "Id_tipo_usuario", "Nombre");
            return View(usuarios);
        }

        // POST: UsuariosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(tbl_Usuarios usuarios)
        {
            try
            {
                usuarios.Estado = true;

                _db.Entry(usuarios).State = EntityState.Modified;
                _db.SaveChanges();                

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewBag.Id_tipo_usuario = new SelectList(_db.Tipos_Usuarios, "Id_tipo_usuario", "Nombre");
                return View(usuarios);
            }
        }

        // GET: UsuariosController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Index));
            }
            
            tbl_Usuarios usuarios = _db.Usuarios.Find(id);

            if (usuarios == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(usuarios);
        }

        // POST: UsuariosController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int? id)
        {
            try
            {
                if (id == null)
                {
                    return RedirectToAction(nameof(Index));
                }

                tbl_Usuarios usuarios = _db.Usuarios.Find(id);

                usuarios.Estado = false;

                _db.Entry(usuarios).State = EntityState.Modified;
                _db.SaveChanges();

                //_db.Usuarios.Remove(usuarios);
                //_db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
