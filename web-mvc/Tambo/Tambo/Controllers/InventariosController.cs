using System;
using System.Collections.Generic;
using System.Data;
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
    public class InventariosController : Controller
    {
        private TamboContext db = new TamboContext();
        private InventarioService inventarioService;
        private ProductoService productoService;
        private TiendaService tiendaService;

        public InventariosController()
        {
            inventarioService = new InventarioServiceImpl();
            productoService = new ProductoServiceImpl();
            tiendaService = new TiendaServiceImpl();
        }

        // GET: Inventarios
        public ActionResult Index()
        {
            var inventario = inventarioService.FindAll();
            return View(inventario);
        }

        // GET: Inventarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inventario inventario = inventarioService.FindById(id);
            if (inventario == null)
            {
                return HttpNotFound();
            }
            return View(inventario);
        }

        // GET: Inventarios/Create
        public ActionResult Create()
        {
            ViewBag.id_producto = new SelectList(productoService.FindAll(), "id", "nombre");
            ViewBag.id_tienda = new SelectList(tiendaService.FindAll(), "id", "nombre");
            return View();
        }

        // POST: Inventarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,id_tienda,id_producto,stock")] Inventario inventario)
        {
            if (ModelState.IsValid)
            {
                inventarioService.Save(inventario);
                return RedirectToAction("Index");
            }

            ViewBag.id_producto = new SelectList(productoService.FindAll(), "id", "nombre", inventario.id_producto);
            ViewBag.id_tienda = new SelectList(tiendaService.FindAll(), "id", "nombre", inventario.id_tienda);
            return View(inventario);
        }

        // GET: Inventarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inventario inventario = inventarioService.FindById(id);
            if (inventario == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_producto = new SelectList(productoService.FindAll(), "id", "nombre", inventario.id_producto);
            ViewBag.id_tienda = new SelectList(tiendaService.FindAll(), "id", "nombre", inventario.id_tienda);
            return View(inventario);
        }

        // POST: Inventarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,id_tienda,id_producto,stock")] Inventario inventario)
        {
            if (ModelState.IsValid)
            {
                inventarioService.Update(inventario);
                return RedirectToAction("Index");
            }
            ViewBag.id_producto = new SelectList(productoService.FindAll(), "id", "nombre", inventario.id_producto);
            ViewBag.id_tienda = new SelectList(tiendaService.FindAll(), "id", "nombre", inventario.id_tienda);
            return View(inventario);
        }

        // GET: Inventarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inventario inventario = inventarioService.FindById(id);
            if (inventario == null)
            {
                return HttpNotFound();
            }
            return View(inventario);
        }

        // POST: Inventarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Inventario inventario = inventarioService.FindById(id);
            inventarioService.Delete(inventario);
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
