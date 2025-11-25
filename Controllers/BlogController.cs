using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SezenElifCaba_BlogSitesi.Models.Context;
using SezenElifCaba_BlogSitesi.Models.Entities;

namespace SezenElifCaba_BlogSitesi.Controllers
{
    [Authorize(Roles = "Admin")]    
    public class BlogController : Controller
    {

        private readonly ProjectContext db;

        public BlogController(ProjectContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View(db.Blogs.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]  
        public IActionResult Create(Blog blog, IFormFile BlogPhoto)
        {

            if(ModelState.IsValid)
            {
                if(BlogPhoto!=null)
                {
                    string imageName = BlogPhoto.FileName;
                    string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/Blogimg/{imageName}");
                    var stream = new FileStream(path, FileMode.Create);
                    blog.BlogPhoto = imageName;
                    BlogPhoto.CopyTo(stream);
                }

                db.Blogs.Add(blog);
                db.SaveChanges();
                return RedirectToAction("Index");

            }

            return View(blog);

        }

        public IActionResult Details(int? id)
        {

            Blog yazi = db.Blogs.FirstOrDefault(x => x.BlogID == id);

            return View(yazi);  

        }

        public IActionResult Delete(int? id)
        {

            Blog yazi = db.Blogs.FirstOrDefault(x => x.BlogID == id);
            db.Blogs.Remove(yazi);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Edit(int? id)
        {

            if(id==null||db.Blogs==null)
            {
                return NotFound();
            }

            Blog yazi=db.Blogs.FirstOrDefault(x => x.BlogID == id);

            if (yazi==null)
            {
                return NotFound();
            }

            return View(yazi);

        }

        [HttpPost]  
        public IActionResult Edit(int BlogID, string Title, string BlogText, string BlogContext, DateTime BlogDate, IFormFile BlogPhoto)
        {
            try
            {
                Console.WriteLine($"Edit POST çağrıldı - BlogID: {BlogID}");
                Console.WriteLine($"Title: {Title}");
                Console.WriteLine($"BlogText: {BlogText}");
                Console.WriteLine($"BlogDate: {BlogDate}");

                
                var existingBlog = db.Blogs.FirstOrDefault(x => x.BlogID == BlogID);
                if (existingBlog == null)
                {
                    Console.WriteLine($"Blog bulunamadı - ID: {BlogID}");
                    return NotFound();
                }

                Console.WriteLine($"Mevcut blog bulundu: {existingBlog.Title}");

                
                if (BlogPhoto != null && BlogPhoto.Length > 0)
                {
                    string imageName = BlogPhoto.FileName;
                    string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/Blogimg/{imageName}");
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        BlogPhoto.CopyTo(stream);
                    }
                    existingBlog.BlogPhoto = imageName;
                    Console.WriteLine($"Yeni fotoğraf yüklendi: {imageName}");
                }

               
                existingBlog.Title = Title;
                existingBlog.BlogText = BlogText;
                existingBlog.BlogContext = BlogContext;
                existingBlog.BlogDate = BlogDate;

                Console.WriteLine($"Güncellenecek veriler:");
                Console.WriteLine($"Title: {existingBlog.Title}");
                Console.WriteLine($"BlogText: {existingBlog.BlogText}");
                Console.WriteLine($"BlogDate: {existingBlog.BlogDate}");

                
                int result = db.SaveChanges();
                Console.WriteLine($"SaveChanges sonucu: {result} kayıt etkilendi");

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata oluştu: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                return RedirectToAction("Edit", new { id = BlogID });
            }
        }

    }
}
