using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    class Wykaz
    {
        private List<Czytelnik> lista { get; }
        private static int NEXT_ID = 0;

        public Wykaz(List<Czytelnik> czytelnicy)
        {
            lista = czytelnicy;
        }

        public Wykaz() : this(new List<Czytelnik>())
        {
        }

        public void dodajCzytelnika(String imie, String nazwisko)
        {
            lista.Add(new Czytelnik(getNextAvailableId(), imie, nazwisko));
        }

        public Czytelnik getCzytelnik(int id)
        {
            foreach (Czytelnik czytelnik in lista)
                if (czytelnik.id == id)
                    return czytelnik;
            return null;
        }

        public void usunCzytelnika(Czytelnik czytelnik)
        {
            lista.Remove(czytelnik);
        }

        public void usunCzytelnika(int id)
        {
            lista.Remove(getCzytelnik(id));
        }

        private int getNextAvailableId()
        {
            return ++NEXT_ID;
        }
    }
}
