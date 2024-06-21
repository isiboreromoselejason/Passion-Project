using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ContactManagementSystem.Models;
using Contentmanagementsystem.Models;

namespace Contentmanagementsystem.Controllers
{
    public class ContactCategoryMapsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ContactCategoryMaps
        public async Task<ActionResult> Index()
        {
            var contactCategoryMaps = db.ContactCategoryMaps.Include(c => c.Contact);
            return View(await contactCategoryMaps.ToListAsync());
        }

        // GET: ContactCategoryMaps/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactCategoryMap contactCategoryMap = await db.ContactCategoryMaps.FindAsync(id);
            if (contactCategoryMap == null)
            {
                return HttpNotFound();
            }
            return View(contactCategoryMap);
        }

        // GET: ContactCategoryMaps/Create
        public ActionResult Create()
        {
            ViewBag.ContactId = new SelectList(db.Contacts, "ContactId", "Name");
            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "CategoryName");
            return View(new ContactCategoryMap());
        }

        // POST: ContactCategoryMaps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,ContactId,CategoryId")] ContactCategoryMap contactCategoryMap)
        {
            if (ModelState.IsValid)
            {
                db.ContactCategoryMaps.Add(contactCategoryMap);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.ContactId = new SelectList(db.Contacts, "ContactId", "Name", contactCategoryMap.ContactId);
            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "CategoryName", contactCategoryMap.CategoryId);
            return View(contactCategoryMap);
        }

        // GET: ContactCategoryMaps/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactCategoryMap contactCategoryMap = await db.ContactCategoryMaps.FindAsync(id);
            if (contactCategoryMap == null)
            {
                return HttpNotFound();
            }
            ViewBag.ContactId = new SelectList(db.Contacts, "ContactId", "Name", contactCategoryMap.ContactId);
            return View(contactCategoryMap);
        }

        // POST: ContactCategoryMaps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,ContactId,CategoryId")] ContactCategoryMap contactCategoryMap)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contactCategoryMap).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.ContactId = new SelectList(db.Contacts, "ContactId", "Name", contactCategoryMap.ContactId);
            return View(contactCategoryMap);
        }

        // GET: ContactCategoryMaps/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactCategoryMap contactCategoryMap = await db.ContactCategoryMaps.FindAsync(id);
            if (contactCategoryMap == null)
            {
                return HttpNotFound();
            }
            return View(contactCategoryMap);
        }

        // POST: ContactCategoryMaps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ContactCategoryMap contactCategoryMap = await db.ContactCategoryMaps.FindAsync(id);
            db.ContactCategoryMaps.Remove(contactCategoryMap);
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
