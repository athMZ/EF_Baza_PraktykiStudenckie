using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Baza_PraktykiStudenckie.Models
{
    public class Opiekun_Uczelnia
    {
        [Key]
        [Column("ID_Opiekuna")]
        public int Id { get; set; }

        public string Katedra { get; set; } = string.Empty;
        public string Wydział { get; set; } = string.Empty;

        public virtual Opiekun Opiekun { get; set; } = new Opiekun();
    }
}