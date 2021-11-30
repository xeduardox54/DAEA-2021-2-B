using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Data.Entity;

namespace Examen_4.Controllers
{
    public class PrestamosController : Controller
    {
        #region Contexto
        //ATRIBUTO CONTEXTO
        private BibliotecaEntities _contexto;

        //PROPIEDAD CONTEXTO
        public BibliotecaEntities Contexto
        {
            set { _contexto = value; }
            get
            {
                if (_contexto == null)
                    _contexto = new BibliotecaEntities();
                return _contexto;
            }
        }
        #endregion

        // GET: Prestamos
        public ActionResult Index()
        {
            return View(Contexto.Prestamos.ToList());
        }

        // GET: Prestamos/Create/
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        // POST: Prestamos/Create/
        public ActionResult Create(Prestamos nuevoPrestamo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Contexto.Prestamos.Add(nuevoPrestamo);
                    Contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(nuevoPrestamo);
            }
            catch
            {
                return View();
            }
        }

        // GET: /Prestamos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Prestamos PrestamoEditar = Contexto.Prestamos.Find(id);
            if (PrestamoEditar == null)
                return HttpNotFound();
            return View(PrestamoEditar);
        }

        //POST /Prestamos/Edit/5
        [HttpPost]
        public ActionResult Edit(Prestamos PrestamoEditar)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Contexto.Entry(PrestamoEditar).State = EntityState.Modified;
                    Contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(PrestamoEditar);
            }
            catch
            {
                return View();
            }
        }

        // GET /Categories/Delete/5

        public ActionResult Delete(int id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Prestamos PrestamoEliminar = Contexto.Prestamos.Find(id);
            if (PrestamoEliminar == null)
                return HttpNotFound();
            return View(PrestamoEliminar);
        }

        //POST /Categories/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, Prestamos Prestamo)
        {
            try
            {
                Prestamos PrestamoEliminar = new Prestamos();
                if (ModelState.IsValid)
                {
                    if (id == null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                    PrestamoEliminar = Contexto.Prestamos.Find(id);
                    if (PrestamoEliminar == null)
                        return HttpNotFound();
                    Contexto.Prestamos.Remove(PrestamoEliminar);
                    Contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(PrestamoEliminar);
            }
            catch
            {
                return View();
            }
        }
    }
}