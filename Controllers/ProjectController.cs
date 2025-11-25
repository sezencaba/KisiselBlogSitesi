using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SezenElifCaba_BlogSitesi.Models.Context;
using SezenElifCaba_BlogSitesi.Models.Entities;

namespace SezenElifCaba_BlogSitesi.Controllers
{

    [Authorize(Roles = "Admin")]
    public class ProjectController : Controller
    {

        private readonly ProjectContext db;

        public ProjectController(ProjectContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View(db.Projects.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]  
        public IActionResult Create(Project project,IFormFile projectPhoto)
        {

            if(ModelState.IsValid)
            {
                if(projectPhoto!=null)
                {
                    string imageName=projectPhoto.FileName;
                    string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/Projeimg/{imageName}");
                    var stream = new FileStream(path, FileMode.Create);
                    project.ProjectPhoto = imageName;
                    projectPhoto.CopyTo(stream);
                }

                db.Projects.Add(project);
                db.SaveChanges();
                return RedirectToAction("Index");

            }

            return View(project);

        }

        public IActionResult Details(int? id)
        {

            if(id == null||db.Projects==null)
            {
                return NotFound();
            }

            Project projeler = db.Projects.FirstOrDefault(x => x.ProjectID == id);

            if(projeler==null)
            {
                return NotFound();  
            }

            return View(projeler);
        }

        public IActionResult Delete(int id)
        {

            Project projeler = db.Projects.FirstOrDefault(x => x.ProjectID == id);
            db.Projects.Remove(projeler);
            db.SaveChanges();   
            return RedirectToAction("Index");   

        }

        public IActionResult Edit(int? id)
        {
            if (id == null || db.Projects == null)
            {
                return NotFound();
            }

            Project projeler = db.Projects.FirstOrDefault(x => x.ProjectID == id);

            if (projeler == null)
            {
                return NotFound();
            }

            return View(projeler);
        }

        [HttpPost]
        public IActionResult Edit(Project proje,IFormFile ProjectPhoto)
        {

            if (ModelState.IsValid)
            {
                if (ProjectPhoto != null)
                {
                    string imageName = ProjectPhoto.FileName;
                    string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/Projeimg/{imageName}");
                    var stream = new FileStream(path, FileMode.Create);
                    proje.ProjectPhoto = imageName;
                    ProjectPhoto.CopyTo(stream);
                }

                db.Projects.Update(proje);
                db.SaveChanges();
                return RedirectToAction("Index");

            }

            return View(proje);

        }

    }
}
