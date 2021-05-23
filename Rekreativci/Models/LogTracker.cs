using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rekreativci.Models
{
    public class LogTracker
    {
        // mora imati privatni konstruktor jer je SINGLETON
        private LogTracker() { }

        private static LogTracker UniqueInstance = new LogTracker();
        public static LogTracker getInstance(){
            return UniqueInstance;
        }
    }
}
