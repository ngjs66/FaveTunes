using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using FaveTunes.Models;

namespace FaveTunes.Controllers
{
    public class TunesController : Controller
    {
        private TunesDbContext db = new TunesDbContext();

        // GET: Tunes
        public ActionResult Index()
        {
            return View(db.Tunes.ToList());
        }

        // GET: Tunes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tunes tunes = db.Tunes.Find(id);
            if (tunes == null)
            {
                return HttpNotFound();
            }
            return View(tunes);
        }

        // GET: Tunes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tunes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,DateAdded,Genre,Album,Artist")] Tunes tunes)
        {
            if (ModelState.IsValid)
            {
                db.Tunes.Add(tunes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tunes);
        }

        // GET: Tunes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tunes tunes = db.Tunes.Find(id);
            if (tunes == null)
            {
                return HttpNotFound();
            }
            return View(tunes);
        }

        // POST: Tunes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,DateAdded,Genre,Album,Artist")] Tunes tunes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tunes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tunes);
        }

        // GET: Tunes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tunes tunes = db.Tunes.Find(id);
            if (tunes == null)
            {
                return HttpNotFound();
            }
            return View(tunes);
        }

        // POST: Tunes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tunes tunes = db.Tunes.Find(id);
            db.Tunes.Remove(tunes);
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
