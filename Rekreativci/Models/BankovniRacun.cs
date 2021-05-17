using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rekreativci.Models
{
 
    public class BankovniRacun : IRacun // OVO PROVJERI JOS
    {
        #region Properties
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        public long BrojRacuna { get; set; }
        [Required]
        public double StanjeRacuna { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DatumIsteka { get; set; }
        // [Required]
        //public IRacun Racun { get; set; }

        #endregion

        public BankovniRacun() { }

        public void skiniSaRacuna(double iznos)
        {
            throw new NotImplementedException();
        }

        public void staviNaRacun(double iznos)
        {
            throw new NotImplementedException();
        }
    }
}
