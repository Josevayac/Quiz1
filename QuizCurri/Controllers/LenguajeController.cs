using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuizCurri.Models;

namespace QuizCurri.Controllers
{
    public class LenguajeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Lenguaje
        public async Task<ActionResult> Index()
        {
            return View(await db.Lenguajes.ToListAsync());
        }

        // GET: Lenguaje/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lenguajes lenguajes = await db.Lenguajes.FindAsync(id);
            if (lenguajes == null)
            {
                return HttpNotFound();
            }
            return View(lenguajes);
        }

        // GET: Lenguaje/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lenguaje/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "LenguajeId,LenguajeName")] Lenguajes lenguajes)
        {
            if (ModelState.IsValid)
            {
                db.Lenguajes.Add(lenguajes);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(lenguajes);
        }

        // GET: Lenguaje/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lenguajes lenguajes = await db.Lenguajes.FindAsync(id);
            if (lenguajes == null)
            {
                return HttpNotFound();
            }
            return View(lenguajes);
        }

        // POST: Lenguaje/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "LenguajeId,LenguajeName")] Lenguajes lenguajes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lenguajes).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(lenguajes);
        }

        // GET: Lenguaje/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lenguajes lenguajes = await db.Lenguajes.FindAsync(id);
            if (lenguajes == null)
            {
                return HttpNotFound();
            }
            return View(lenguajes);
        }

        // POST: Lenguaje/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Lenguajes lenguajes = await db.Lenguajes.FindAsync(id);
            db.Lenguajes.Remove(lenguajes);
            await db.SaveChangesAsync();
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
