using System.Collections.Generic;
using SezenElifCaba_BlogSitesi.Models.Entities;

namespace SezenElifCaba_BlogSitesi.Models
{
    public class AdminDashboardViewModel
    {
        public int TotalBlogs { get; set; }
        public int TotalProjects { get; set; }
        public int TotalContacts { get; set; }
        public List<Blog> RecentBlogs { get; set; } = new();
        public List<Project> RecentProjects { get; set; } = new();
    }
}
