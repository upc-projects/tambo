using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Entities_Layer;
using BusinessLayer.Service;
using BusinessLayer.ServiceImpl;

namespace Tambo.Controllers
{
    public class ProductosController : Controller
    {
        private ProductoService productoService;
        private CategoriaService categoriaService;
        private MarcaService marcaService;
        private TamboContext db = new TamboContext();

        public ProductosController()
        {
            productoService = new ProductoServiceImpl();
            categoriaService = new CategoriaServiceImpl();
            marcaService = new MarcaServiceImpl();
        }

        // GET: Productos
        public ActionResult Index()
        {
            return View(productoService.FindAll());
        }

        // GET: Productos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Productos producto = productoService.FindById(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }

        // GET: Productos/Create
        public ActionResult Create()
        {
            ViewBag.id_categoria = new SelectList(categoriaService.FindAll(), "id", "nombre");
            ViewBag.id_marca = new SelectList(marcaService.FindAll(), "id", "nombre");
            return View();
        }

        // POST: Productos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,id_marca,nombre,descripcion,precio,fecha_vencimiento,codigo,id_categoria")] Productos producto)
        {
            if (ModelState.IsValid)
            {
                productoService.Save(producto);
                return RedirectToAction("Index");
            }

            ViewBag.id_categoria = new SelectList(categoriaService.FindAll(), "id", "nombre", producto.id_categoria);
            ViewBag.id_marca = new SelectList(marcaService.FindAll(), "id", "nombre", producto.id_marca);
            return View(producto);
        }

        // GET: Productos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Productos producto = productoService.FindById(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_categoria = new SelectList(categoriaService.FindAll(), "id", "nombre", producto.id_categoria);
            ViewBag.id_marca = new SelectList(marcaService.FindAll(), "id", "nombre", producto.id_marca);
            return View(producto);
        }

        // POST: Productos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,id_marca,nombre,descripcion,precio,fecha_vencimiento,codigo,id_categoria")] Productos producto)
        {
            if (ModelState.IsValid)
            {
                productoService.Update(producto);
                return RedirectToAction("Index");
            }
            ViewBag.id_categoria = new SelectList(categoriaService.FindAll(), "id", "nombre", producto.id_categoria);
            ViewBag.id_marca = new SelectList(marcaService.FindAll(), "id", "nombre", producto.id_marca);
            return View(producto);
        }

        // GET: Productos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Productos producto = db.Productos.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }

        // POST: Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Productos producto = productoService.FindById(id);
            productoService.Delete(producto);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
