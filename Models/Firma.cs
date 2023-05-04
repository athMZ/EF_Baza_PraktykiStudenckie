﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Baza_PraktykiStudenckie.Models
{
    public class Firma
    {
        [Key]
        [Column("ID_Firmy")]
        public int Id { get; set; }

        public string Nazwa { get; set; } = String.Empty;

        [StringLength(10)]
        public string NIP { get; set; } = String.Empty;

        public string Nr_telefonu { get; set; } = String.Empty;
    }
}