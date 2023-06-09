﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Baza_PraktykiStudenckie.Models
{
    public class Student
    {
        [Key]
        [Column("ID_Studenta")]
        public int Id { get; set; }

        public string Imię { get; set; } = string.Empty;
        public string Nazwisko { get; set; } = string.Empty;
        public string NrAlbumu { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int RokStudiów { get; set; }

        public virtual ICollection<Opiekun> Opiekunowie { get; set; } = new List<Opiekun>();
        public virtual Praktyka Praktyka { get; set; } = new Praktyka();
    }
}