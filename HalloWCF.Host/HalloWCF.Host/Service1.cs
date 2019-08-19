using System;
using System.Collections.Generic;

namespace HalloWCF.Host
{
    public class Service1 : IService1
    {
        public IEnumerable<Bääääh> GetAllTheBääääh()
        {
            yield return new Bääääh() { AnzahlBlub = 12, Hihihihih = "lol" };
            yield return new Bääääh() { AnzahlBlub = 3, Hihihihih = "rofl" };
            yield return new Bääääh() { AnzahlBlub =-93, Hihihihih = "Gnhahaha" };
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string WelcheWochentagIstHeute()
        {
            return $"{DateTime.Now:dddd}";
        }
    }
}
