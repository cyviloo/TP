using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    public class OpisStanu
    {
        private Katalog katalog { get; }
        public enum Stan { wolna, wypozyczona, zarezerwowana, niedostepna }
        private Stan stan { get; set; }

        public OpisStanu(Katalog katalog, Stan stan)
        {
            this.katalog = katalog;
            this.stan = stan;
        }
        public OpisStanu(Katalog katalog) : this(katalog, Stan.wolna)
        {
        }
    }
}
