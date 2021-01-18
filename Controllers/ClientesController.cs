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
    public class ClientesController : Controller
    {
        private readonly PruebaContext _db;

        public ClientesController(PruebaContext pruebaContext)
        {
            _db = pruebaContext;
        }

        /* 
        En cada una de las opciones de crear, editar y eliminar estaria sumando una nueva actividad a las actividades del usuario 
        Siempre primero validando la fecha, por el dado caso de que no haya marcado 
        sino ha marcado con solo realizar una de estas acciones se crearia la marcacion y al mismo tiempo el registro de la actividad
        si ya ha sido creada solo estariamos sumando en el campo actividades +1 y asi posterior en la agenda nos mostrara el numero de actividades que hemos realizado
         */


        // GET: ClientesController
        public ActionResult Index()
        {
            return View(_db.Clientes.Where(s=>s.Estado == true).ToList());
        }

        // GET: ClientesController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Index));
            }
            tbl_Clientes clientes = _db.Clientes.Find(id);
            if (clientes == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(clientes);
        }

        // GET: ClientesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(tbl_Clientes clientes)
        {
            try
            {
                clientes.Estado = true;

                _db.Clientes.Add(clientes);
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(clientes);
            }
        }

        // GET: ClientesController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Index));
            }

            tbl_Clientes clientes = _db.Clientes.Find(id);

            if (clientes == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(clientes);
        }

        // POST: ClientesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(tbl_Clientes clientes)
        {
            try
            {
                clientes.Estado = true;

                _db.Entry(clientes).State = EntityState.Modified;
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(clientes);
            }
        }

        // GET: ClientesController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Index));
            }

            tbl_Clientes clientes = _db.Clientes.Find(id);
            
            if (clientes == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(clientes);
        }

        // POST: ClientesController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                tbl_Clientes clientes = _db.Clientes.Find(id);

                clientes.Estado = false;

                _db.Entry(clientes).State = EntityState.Modified;
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
