using System.ComponentModel.DataAnnotations;

namespace SezenElifCaba_BlogSitesi.Models.Entities
{
    public class User
    {

        [Key]
        public int UserID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Surname { get; set; }

        [MaxLength(20)]
        public string UserName { get; set; }

        [MaxLength(10)]
        public string Password { get; set; }

        [MaxLength(10)]
        public string Role { get; set; }

    }
}
