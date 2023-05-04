using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Baza_PraktykiStudenckie.Models
{
    public class Opiekub
    {
        [Key]
        [Column("ID_Opiekuna")]
        public int Id { get; set; }

        public string Imię { get; set; } = String.Empty;
        public string Nazwisko { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
    }
}