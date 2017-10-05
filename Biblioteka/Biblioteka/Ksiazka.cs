using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    class Ksiazka
    {
        internal String tytul { get; }
        internal String autor { get; }
        internal int rokWydania { get; }

        public Ksiazka(String tytul, String autor, int rok)
        {
            this.tytul = tytul;
            this.autor = autor;
            rokWydania = rok;
        }
    }
}
