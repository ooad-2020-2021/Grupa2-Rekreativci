using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rekreativci.Models
{
    public class KorisnikSaNalogom:KorisnikSistema
    {
        #region Properties
        // ni ovo nije Required jer ne mora da ima rezervacije 
        [NotMapped]
        public List<Rezervacija> Rezervacije;
        // nije Required jer ne mora korisnik da doda bankovni racun ako ne zeli
        public BankovniRacun BankovniRacun;
        #endregion

        public KorisnikSaNalogom() { }
        public void AddRezervacija(Rezervacija rezervacija) {
            Rezervacije.Add(rezervacija);
        }
        public void RemoveRezervacija(Rezervacija rezervacija) {
            Rezervacije.Remove(rezervacija);
        }
    }
}
