using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SezenElifCaba_BlogSitesi.Models;
using System.Linq;

namespace SezenElifCaba_BlogSitesi.Controllers
{

    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        private readonly SezenElifCaba_BlogSitesi.Models.Context.ProjectContext db;

        public AdminController(SezenElifCaba_BlogSitesi.Models.Context.ProjectContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var model = new AdminDashboardViewModel
            {
                TotalBlogs = db.Blogs.Count(),
                TotalProjects = db.Projects.Count(),
                TotalContacts = db.Contacts.Count(),
                RecentBlogs = db.Blogs.OrderByDescending(x => x.BlogDate).Take(5).ToList(),
                RecentProjects = db.Projects.OrderByDescending(x => x.ProjectDate).Take(5).ToList()
            };
            return View(model);
        }
    }
}
