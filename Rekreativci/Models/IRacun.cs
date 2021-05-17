using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rekreativci.Models
{
    interface IRacun
    {
        public void skiniSaRacuna(double iznos);

        public void staviNaRacun(double iznos);
    }
}
