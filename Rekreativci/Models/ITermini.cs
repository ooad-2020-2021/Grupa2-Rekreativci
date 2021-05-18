using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rekreativci.Models
{
    interface ITermini
    {
        public List<List<Tuple<DateTime, DateTime>>> DajSlobodneTermine(List<Rezervacija> rezervacije);
    }
}
