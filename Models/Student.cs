using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Baza_PraktykiStudenckie.Models
{
    public class Student
    {
        [Key]
        [Column("ID_Studenta")]
        public int Id { get; set; }

        public string Imię { get; set; } = String.Empty;
        public string Nazwisko { get; set; } = String.Empty;
        public string Nr_albumu { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public int Rok_studiów { get; set; }
    }
}