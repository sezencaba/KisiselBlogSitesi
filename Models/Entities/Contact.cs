using System.ComponentModel.DataAnnotations;

namespace SezenElifCaba_BlogSitesi.Models.Entities
{
    public class Contact
    {

        [Key]
        public int ContactID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }

        [Required]
        [MaxLength(255)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }

        public bool IsRead { get; set; } = false;

    }
}
