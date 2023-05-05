using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Baza_PraktykiStudenckie.Models
{
    public class Opiekun_ZakładPracy
    {
        [Key]
        [Column("ID_Opiekuna")]
        public int Id { get; set; }
        [Column("ID_Firmy")]
        public int IdFirmy { get; set; }
        public string Stanowsisko { get; set; } = string.Empty;
        public string NrTelefonu { get; set; } = string.Empty;

        public virtual Opiekun Opiekun { get; set; } = new Opiekun();
    }
}
