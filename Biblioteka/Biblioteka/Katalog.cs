using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    public class Katalog
    {
        internal String tytul { get; }
        internal String autor { get; }
        internal int rokWydania { get; }

        public Katalog(String tytul, String autor, int rok)
        {
            this.tytul = tytul;
            this.autor = autor;
            rokWydania = rok;
        }
    }
}
