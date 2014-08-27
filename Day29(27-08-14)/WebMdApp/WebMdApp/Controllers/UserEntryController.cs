using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebMdApp.Models;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebMdApp.Controllers
{
    public class UserEntryController : Controller
    {
        private WebMdContext db = new WebMdContext();

        // GET: /UserEntry/
        public ActionResult Index()
        {
            var userentries = db.UserEntries.Include(u => u.UserType);
            return View(userentries.ToList());
        }

        // GET: /UserEntry/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserEntry userentry = db.UserEntries.Find(id);
            if (userentry == null)
            {
                return HttpNotFound();
            }
            return View(userentry);
        }

        // GET: /UserEntry/Create
        public ActionResult Create()
        {
            ViewBag.UserTypeId = new SelectList(db.UserTypes, "UserTypeId", "Type");
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.UserTypeId = new SelectList(db.UserTypes, "UserTypeId", "Type");
            return View();
        }

        // POST: /UserEntry/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Login(UserEntry userentry)
        {
            if (ModelState.IsValid)
            {
                var userName = db.UserEntries.Count(m => m.UserName == userentry.UserName);
                var password = db.UserEntries.Count(m => m.Password == userentry.Password);
                var type = db.UserEntries.Count(m => m.UserTypeId == userentry.UserTypeId);
                if (userName > 0 && password > 0 && type > 0)
                {
                    if (userentry.UserTypeId == 1)
                    {
                        return RedirectToAction("Index", "Doctor");
                    }
                    else if (userentry.UserTypeId == 2)
                    {
                        return View("Admin");
                    }
                    else if (userentry.UserTypeId == 3)
                    {
                        return View("Advitiser");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Unknown.");
                        return View();
                    }

                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                    return View();
                }
            }
            return View();
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Home");
        }

        // GET: /UserEntry/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserEntry userentry = db.UserEntries.Find(id);
            if (userentry == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserTypeId = new SelectList(db.UserTypes, "UserTypeId", "Type", userentry.UserTypeId);
            return View(userentry);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserId,FullName,UserName,Email,Password,UserTypeId")] UserEntry userentry)
        {
            if (ModelState.IsValid)
            {
                db.UserEntries.Add(userentry);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserTypeId = new SelectList(db.UserTypes, "UserTypeId", "Type", userentry.UserTypeId);
            return View(userentry);
        }

        // POST: /UserEntry/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="UserId,FullName,UserName,Email,UserTypeId")] UserEntry userentry)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userentry).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserTypeId = new SelectList(db.UserTypes, "UserTypeId", "Type", userentry.UserTypeId);
            return View(userentry);
        }

        // GET: /UserEntry/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserEntry userentry = db.UserEntries.Find(id);
            if (userentry == null)
            {
                return HttpNotFound();
            }
            return View(userentry);
        }

        // POST: /UserEntry/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserEntry userentry = db.UserEntries.Find(id);
            db.UserEntries.Remove(userentry);
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
