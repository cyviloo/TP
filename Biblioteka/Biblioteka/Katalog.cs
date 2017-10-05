using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    class Katalog
    {
        /**
         * Jako klucza uzyjemy ISBN:
         * https://pl.wikipedia.org/wiki/International_Standard_Book_Number
         * a wiec typu String
         */
        private Dictionary<String, Ksiazka> ksiazki;
        public Katalog()
        {
            ksiazki = new Dictionary<string, Ksiazka>();
        }

        public Katalog(Dictionary<string, Ksiazka> listaKsiazek)
        {
            ksiazki = listaKsiazek;
        }

        public void dodajKsiazke(String ISBN, Ksiazka ksiazka)
        {
            ksiazki.Add(ISBN, ksiazka);
        }

        public void dodajKsiazke(String ISBN, String tytul, String autor, int rok)
        {
            dodajKsiazke(ISBN, new Ksiazka(tytul, autor, rok));
        }

        public Ksiazka getKsiazka(String ISBN)
        {
            Ksiazka result = null;
            ksiazki.TryGetValue(ISBN, out result);
            return result;
        }

        public bool usunKsiazke(String ISBN)
        {
            return ksiazki.Remove(ISBN);
        }
    }
}
