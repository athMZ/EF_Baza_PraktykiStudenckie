using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Baza_PraktykiStudenckie.Models
{
    public class Adres
    {
        [Key]
        [Column("ID_Firmy")]
        public int Id { get; set; }

        public string Miejscowość { get; set; } = string.Empty;
        public string KodPocztowy { get; set; } = string.Empty;
        public string Ulica { get; set; } = string.Empty;
        public int? NrBudynku { get; set; }
        public int? NrLokalu { get; set; }

        public virtual Firma Firma { get; set; } = new Firma();
    }
}