using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SezenElifCaba_BlogSitesi.Models.Context;
using Microsoft.EntityFrameworkCore;

namespace SezenElifCaba_BlogSitesi.Controllers
{

    [AllowAnonymous]
    public class SiteController : Controller
    {

        private readonly ProjectContext db;

        public SiteController(ProjectContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {

          ViewBag.BlogYazilari=db.Blogs.OrderByDescending(x=>x.BlogDate).ToList();    

            return View(db.Projects.OrderByDescending(x=>x.ProjectDate).ToList());
        }

        public IActionResult Blog(int id)
        {
            var blog = db.Blogs.FirstOrDefault(x => x.BlogID == id);
            if (blog == null) return NotFound();
            return View(blog);
        }

        public IActionResult Project(int id)
        {
            var project = db.Projects.FirstOrDefault(x => x.ProjectID == id);
            if (project == null) return NotFound();
            return View(project);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(SezenElifCaba_BlogSitesi.Models.Entities.Contact contact)
        {
            if (!ModelState.IsValid)
            {
                
                ViewBag.BlogYazilari = db.Blogs.OrderByDescending(x => x.BlogDate).ToList();
                var projects = db.Projects.OrderByDescending(x => x.ProjectDate).ToList();
                return View("Index", projects);
            }
            db.Contacts.Add(contact);
            db.SaveChanges();
            TempData["ContactSuccess"] = "ok";
            return RedirectToAction("Index");
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("site/ping")]
        public IActionResult Ping()
        {
            try
            {
                var canConnect = db.Database.CanConnect();
                return Content(canConnect ? "OK" : "DB_FAIL");
            }
            catch (Exception ex)
            {
                return Content($"ERR: {ex.Message}");
            }
        }
    }
}
