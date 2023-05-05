using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Baza_PraktykiStudenckie.Models
{
    public class Opiekun
    {
        [Key]
        [Column("ID_Opiekuna")]
        public int Id { get; set; }

        public string Imię { get; set; } = string.Empty;
        public string Nazwisko { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public virtual ICollection<Student> StudenciPodOpieką { get; set; } = new List<Student>();
    }
}