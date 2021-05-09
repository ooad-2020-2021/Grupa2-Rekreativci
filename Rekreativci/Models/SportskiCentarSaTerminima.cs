using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rekreativci.Models
{
    public class SportskiCentarSaTerminima:SportskiCentar
    {
        #region Properties
        [NotMapped]
        public List<Rezervacija> ListaRezervacija { get; set; }
        #endregion

        public SportskiCentarSaTerminima() { }
        public void AddRezervacija(Rezervacija NovaRezervacija) {
            ListaRezervacija.Add(NovaRezervacija);
        }
    }
}
