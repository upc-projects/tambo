using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Service;
using BusinessLayer.ServiceImpl;
using DataLayer;

namespace Tambo.Controllers
{
    public class TiendasController : Controller
    {
        private TamboContext db = new TamboContext();
        private TiendaService tiendaService;

        public TiendasController()
        {
            tiendaService = new TiendaServiceImpl();
        }

        // GET: Tiendas
        public ActionResult Index()
        {
            var tiendas = db.Tiendas.Include(t => t.Inventario);
            return View(tiendaService.FindAll());
        }

        // GET: Tiendas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tienda tienda = db.Tiendas.Find(id);
            if (tienda == null)
            {
                return HttpNotFound();
            }
            return View(tienda);
        }

        // GET: Tiendas/Create
        public ActionResult Create()
        {
            
            return View(new Tienda());
        }

        // POST: Tiendas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create(Tienda tienda)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                tiendaService.Save(tienda);
                return RedirectToAction("Index", "Tiendas");
            }
            catch (Exception)
            {
                return View();
            }
        }

        // GET: Tiendas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tienda tienda = db.Tiendas.Find(id);
            if (tienda == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_inventario = new SelectList(db.Inventarios, "id", "descripcion", tienda.id_inventario);
            return View(tienda);
        }

        // POST: Tiendas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombre,telefono,direccion,id_inventario")] Tienda tienda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tienda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_inventario = new SelectList(db.Inventarios, "id", "descripcion", tienda.id_inventario);
            return View(tienda);
        }

        // GET: Tiendas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tienda tienda = db.Tiendas.Find(id);
            if (tienda == null)
            {
                return HttpNotFound();
            }
            return View(tienda);
        }

        // POST: Tiendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tienda tienda = db.Tiendas.Find(id);
            db.Tiendas.Remove(tienda);
            db.SaveChanges();
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
