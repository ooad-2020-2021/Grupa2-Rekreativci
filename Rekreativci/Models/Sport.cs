using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rekreativci.Models
{
    public class Sport
    {
        #region Properties
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        [DisplayName("Opis sporta:")]
        public string Opis { get; set; } // nema drugih ogranicenja
        [DisplayName("Slika sporta:")]
        public string Slika { get; set; } // nema nikakvih ogranicenja jer je ne mora imati
        [NotMapped]
        public List<SportskiCentar> SportskiCentri { get; set; } // nije Required jer kada se tek bude pravio neki sport ne mora odmah imati sportske centre
        #endregion
        public Sport() { }

        public void AddSportskiCentar(SportskiCentar NoviSportskiCentar) {
            SportskiCentri.Add(NoviSportskiCentar);
        }
        public void RemoveSportskiCentar(SportskiCentar StariSportskiCentar)
        {
            SportskiCentri.Remove(StariSportskiCentar);
        }
    }
}
