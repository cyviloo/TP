using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    public class Wykaz
    {
        internal int id { get; }
        internal String imie { get; set; }
        internal String nazwisko { get; set; }

        public Wykaz(int ID, String imie, String nazwisko)
        {
            id = ID;
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
    }
}
