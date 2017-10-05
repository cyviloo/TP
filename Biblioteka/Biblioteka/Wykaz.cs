using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    class Wykaz
    {
        internal int id { get; set; }
        internal String imie { get; set; }
        internal String nazwisko { get; set; }

        public Wykaz(int ID, String imie, String nazwisko)
        {
            id = ID;
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public void Clone(Wykaz other)
        {
            this.id = other.id;
            this.imie = other.imie;
            this.nazwisko = other.nazwisko;
        }

    }
}
