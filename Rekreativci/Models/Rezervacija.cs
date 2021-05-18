using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Korisnik koji je rezervisao:")]
        public KorisnikSaNalogom Korisnik { get; set; }
        [Required]
        [DisplayName("Sportski centar:")]
        public SportskiCentar SportskiCentar { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayName("Pocetak termina:")]
        public DateTime PocetakTermina{ get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayName("Kraj termina:")]
        public DateTime KrajTermina { get; set; }
        [Required]
        [DisplayName("Cijena termina:")]
        public double Cijena { get; set; }
        #endregion

        public Rezervacija() { }
    }
}
