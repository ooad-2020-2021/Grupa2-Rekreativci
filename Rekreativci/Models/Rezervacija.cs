using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rekreativci.Models
{
    public class Rezervacija
    {
        #region Properties
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        public KorisnikSaNalogom Korisnik { get; set; }
        [Required]
        public SportskiCentar SportskiCentar { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime PocetakTermina{ get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime KrajTermina { get; set; }
        [Required]
        public double Cijena { get; set; }
        #endregion

        public Rezervacija() { }
    }
}
