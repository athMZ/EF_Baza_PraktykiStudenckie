using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Baza_PraktykiStudenckie.Models
{
    public class Adres
    {
        [Key]
        [Column("ID_Firmy")]
        public int Id { get; set; }
        public string Miejscowość { get; set; }
        public string Kod_pocztowy { get; set; }
        public string Ulica { get; set; }
        public int Nr_budynku { get; set; }
        public int Nr_lokalu { get; set; }
    }
}
