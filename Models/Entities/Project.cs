using System.ComponentModel.DataAnnotations;

namespace SezenElifCaba_BlogSitesi.Models.Entities
{
    public class Project
    {

        [Key]
        public int ProjectID { get; set; }

        [MaxLength(100)]
        public string ProjectTitle { get; set; }

        public string ProjectDesc { get; set; }

        public DateTime ProjectDate { get; set; }

        [MaxLength(255)]
        public string? ProjectPhoto { get; set; }

    }
}
