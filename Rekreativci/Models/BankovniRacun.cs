using System;
using System.Collections.Generic;
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
        public long BrojRacuna { get; set; }
        [Required]
        public double StanjeRacuna { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DatumIsteka { get; set; }
        #endregion

        public BankovniRacun() { }
    }
}
