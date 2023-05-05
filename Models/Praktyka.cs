using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Baza_PraktykiStudenckie.Models
{
    [PrimaryKey(nameof(IdFirmy), nameof(IdStudenta))]
    public class Praktyka
    {
        [Column("ID_Firmy")]
        public int IdFirmy { get; set; }

        [Column("ID_Studenta")]
        public int IdStudenta { get; set; }

        public DateTime Początek { get; set; }
        public DateTime Koniec { get; set; }
        public string ZakresObowiązków { get; set; } = string.Empty;
    }
}