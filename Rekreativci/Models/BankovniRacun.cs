using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rekreativci.Models
{
 
    public class BankovniRacun 
    {
        #region Properties
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        [DisplayName("Broj racuna:")]
        public long BrojRacuna { get; set; }
        [Required]
        [DisplayName("Stanje na racunu:")]
        public double StanjeRacuna { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Datum isteka racuna:")]
        public DateTime DatumIsteka { get; set; }
        [Required]
        [DisplayName("Racun:")]
        public IRacun Racun { get; set; }
        #endregion

        public BankovniRacun() { }
    }
}
