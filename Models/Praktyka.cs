using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Baza_PraktykiStudenckie.Models
{
    public class Praktyka
    {
        [Key]
        [Column("ID_Firmy")]
        public int IdFirmy { get; set; }

        [Key]
        [Column("ID_Studenta")]
        public int IdStudenta { get; set; }
        public string Początek { get; set; }
        public string Koniec { get; set; }
        public string Zakres_obowiązków { get; set; }
    }
}
