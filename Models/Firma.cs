using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Baza_PraktykiStudenckie.Models
{
    public class Firma
    {
        [Key]
        [Column("ID_Firmy")]
        public int Id { get; set; }

        public string Nazwa { get; set; } = string.Empty;

        [StringLength(10)]
        public string NIP { get; set; } = string.Empty;

        public string NrTelefonu { get; set; } = string.Empty;

        public virtual ICollection<Praktyka> Praktyki { get; set; } = new List<Praktyka>();
    }
}