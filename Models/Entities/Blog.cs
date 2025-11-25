using System.ComponentModel.DataAnnotations;

namespace SezenElifCaba_BlogSitesi.Models.Entities
{
    public class Blog
    {

        [Key]
        public int BlogID { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

        public string BlogText { get; set; }

        public string BlogContext { get; set; }

        public DateTime BlogDate { get; set; }

        [MaxLength(255)]
        public string? BlogPhoto { get; set; }

    }
}
