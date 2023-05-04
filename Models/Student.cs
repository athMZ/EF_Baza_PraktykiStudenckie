using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Baza_PraktykiStudenckie.Models
{
    public class Student
    {
        [Key]
        [Column("ID_Studenta")]
        public int Id { get; set; }

        public string Imię { get; set; }
        public string Nazwisko { get; set; }
        public string Nr_albumu { get; set; }
        public string Email { get; set; }
        public int Rok_studiów { get; set; }
    }
}