using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SezenElifCaba_BlogSitesi.Models.Context;

namespace SezenElifCaba_BlogSitesi.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ContactController : Controller
    {
        private readonly ProjectContext db;

        public ContactController(ProjectContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var messages = db.Contacts.OrderByDescending(x => x.ContactID).ToList();
            return View(messages);
        }

        public IActionResult Details(int id)
        {
            var message = db.Contacts.FirstOrDefault(x => x.ContactID == id);
            if (message == null) return NotFound();
            if (!message.IsRead)
            {
                message.IsRead = true;
                db.Contacts.Update(message);
                db.SaveChanges();
            }
            return View(message);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ToggleRead(int id)
        {
            var message = db.Contacts.FirstOrDefault(x => x.ContactID == id);
            if (message == null) return NotFound();
            message.IsRead = !message.IsRead;
            db.Contacts.Update(message);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var message = db.Contacts.FirstOrDefault(x => x.ContactID == id);
            if (message == null) return NotFound();
            db.Contacts.Remove(message);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult MarkAllRead()
        {
            foreach (var m in db.Contacts.Where(x => !x.IsRead))
            {
                m.IsRead = true;
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult MarkSelected(bool read, int[] selectedIds)
        {
            if (selectedIds != null && selectedIds.Length > 0)
            {
                var list = db.Contacts.Where(x => selectedIds.Contains(x.ContactID)).ToList();
                foreach (var m in list)
                {
                    m.IsRead = read;
                }
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteSelected(int[] selectedIds)
        {
            if (selectedIds != null && selectedIds.Length > 0)
            {
                var list = db.Contacts.Where(x => selectedIds.Contains(x.ContactID)).ToList();
                db.Contacts.RemoveRange(list);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
