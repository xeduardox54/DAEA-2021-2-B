using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Data.Entity;

namespace Lab14.Controllers
{
    public class CategoriesController : Controller
    {
        #region Contexto
        //ATRIBUTO CONTEXTO
        private NORTHWNDEntities _contexto;

        //PROPIEDAD CONTEXTO
        public NORTHWNDEntities Contexto
        {
            set { _contexto = value; }
            get
            {
                if (_contexto == null)
                    _contexto = new NORTHWNDEntities();
                return _contexto;
            }
        }
        #endregion

        // GET: Categories
        public ActionResult Index()
        {
            return View(Contexto.Categories.ToList());
        }

        // GET: /Categories/Details/5
        public ActionResult Details(int id)
        {
            var productosPorCategoria = from p in Contexto.Products
                                        orderby p.ProductName ascending
                                        where p.CategoryID == id
                                        select p;
            return View(productosPorCategoria.ToList());
        }

        // GET: /Categories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Categories/Create
        [HttpPost]
        public ActionResult Create(Categories nuevaCategoria)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Contexto.Categories.Add(nuevaCategoria);
                    Contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(nuevaCategoria);
            }
            catch
            {
                return View();
            }
        }

        // GET: /Categories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Categories CategoriaEditar = Contexto.Categories.Find(id);
            if (CategoriaEditar == null)
                return HttpNotFound();
            return View(CategoriaEditar);
        }

        //POST /Categories/Edit/5
        [HttpPost]
        public ActionResult Edit(Categories CategoriaEditar)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Contexto.Entry(CategoriaEditar).State = EntityState.Modified;
                    Contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(CategoriaEditar);
            }
            catch
            {
                return View();
            }
        }

        // GET /Categories/Delete/5

        public ActionResult Delete (int id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Categories CategoriaEliminar = Contexto.Categories.Find(id);
            if (CategoriaEliminar == null)
                return HttpNotFound();
            return View(CategoriaEliminar);
        }

        //POST /Categories/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, Categories Categoria1)
        {
            try
            {
                Categories CategoriaEliminar = new Categories();
                if (ModelState.IsValid)
                {
                    if (id == null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                    CategoriaEliminar = Contexto.Categories.Find(id);
                    if (CategoriaEliminar == null)
                        return HttpNotFound();
                    Contexto.Categories.Remove(CategoriaEliminar);
                    Contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(CategoriaEliminar);
            }
            catch
            {
                return View();
            }
        }

        // GET: /Categories/CrateProduct
        public ActionResult CreateProduct()
        {
            return View();
        }

        // POST: /Categories/CreateProduct
        [HttpPost]
        public ActionResult CreateProduct(Products nuevoProducto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Contexto.Products.Add(nuevoProducto);
                    Contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(nuevoProducto);
            }
            catch
            {
                return View();
            }
        }

        // GET: /Categories/EditProduct/5
        public ActionResult EditProduct(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Products ProductoEditar = Contexto.Products.Find(id);
            if (ProductoEditar == null)
                return HttpNotFound();
            return View(ProductoEditar);
        }

        //POST /Categories/EditProduct/5
        [HttpPost]
        public ActionResult EditProduct(Products ProductoEditar)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Contexto.Entry(ProductoEditar).State = EntityState.Modified;
                    Contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(ProductoEditar);
            }
            catch
            {
                return View();
            }
        }

        // GET /Categories/DeleteProduct/5
        public ActionResult DeleteProduct(int id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Products ProductoEliminar = Contexto.Products.Find(id);
            if (ProductoEliminar == null)
                return HttpNotFound();
            return View(ProductoEliminar);
        }

        //POST /Categories/DeleteProduct/5
        [HttpPost]
        public ActionResult DeletProduct(int? id, Products Producto)
        {
            try
            {
                Products ProductoEliminar = new Products();
                if (ModelState.IsValid)
                {
                    if (id == null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                    ProductoEliminar = Contexto.Products.Find(id);
                    if (ProductoEliminar == null)
                        return HttpNotFound();
                    Contexto.Products.Remove(ProductoEliminar);
                    Contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(ProductoEliminar);
            }
            catch
            {
                return View();
            }
        }
    }
}