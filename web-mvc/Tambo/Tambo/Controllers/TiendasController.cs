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
using Entities_Layer;

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
            return View(tiendaService.FindAll());
        }

        // GET: Tiendas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tiendas tiendas = tiendaService.FindById(id);
            if (tiendas == null)
            {
                return HttpNotFound();
            }
            return View(tiendas);
        }

        // GET: Tiendas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tiendas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Tiendas tiendas)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                tiendaService.Save(tiendas);
                return RedirectToAction("Index", "Tiendas");
            }
            catch (Exception)
            {
                return View(tiendas);
            }
        }

        // GET: Tiendas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tiendas tiendas = tiendaService.FindById(id);
            if (tiendas == null)
            {
                return HttpNotFound();
            }
            return View(tiendas);
        }

        // POST: Tiendas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombre,telefono,direccion")] Tiendas tiendas)
        {
            if (ModelState.IsValid)
            {
                tiendaService.Update(tiendas);
                return RedirectToAction("Index");
            }
            return View(tiendas);
        }

        // GET: Tiendas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tiendas tiendas = tiendaService.FindById(id);
            if (tiendas == null)
            {
                return HttpNotFound();
            }
            return View(tiendas);
        }

        // POST: Tiendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tiendas tiendas = tiendaService.FindById(id);
            tiendaService.Delete(tiendas);
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
