using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    class Czytelnik
    {
        internal int id { get; }
        internal String imie { get; set; }
        internal String nazwisko { get; set; }

        public Czytelnik(int ID, String imie, String nazwisko)
        {
            id = ID;
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
    }
}
