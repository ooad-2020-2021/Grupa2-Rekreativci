using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rekreativci.Models
{
    public class SportskiCentarSaTerminima:SportskiCentar, ITermini
    {
        #region Properties
        [NotMapped]
        [DisplayName("Lista rezervacija:")]
        public List<Rezervacija> ListaRezervacija { get; set; }
        #endregion

        public SportskiCentarSaTerminima() { }
        public void AddRezervacija(Rezervacija NovaRezervacija) {
            ListaRezervacija.Add(NovaRezervacija);
        }
        public void RemoveRezervacija(Rezervacija StaraRezervacija)
        {
            ListaRezervacija.Remove(StaraRezervacija);
        }

        public List<List<Tuple<DateTime, DateTime>>> DajSlobodneTermine(List<Rezervacija> rezervacije)
        {
            // TODO implementiraj !!
            throw new NotImplementedException();
        }
    }
}
