using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Biblioteka
{
    class DataRepository
    {
        private DataContext db;
        public DataRepository()
        {
            db = new DataContext();
        }

        public void addKatalog(Katalog pozycja)
        {
            db.katalog.Add(System.Guid.NewGuid().ToString(), pozycja);
        }

        public Katalog getKatalog(String ID)
        {
            return db.katalog[ID];
        }

        public IEnumerable<Katalog> getAllKatalog()
        {
            return db.katalog.Values;
        }

        public void updateKatalog(String ID, Katalog pozycja)
        {
            db.katalog[ID] = pozycja;
        }

        public void deleteKatalog(String ID)
        {
            db.katalog.Remove(ID);
        }

        public void deleteKatalog(Katalog pozycja)
        {
            foreach (var item in db.katalog)
                if (item.Value.Equals(pozycja))
                    db.katalog.Remove(item.Key);
        }

        public void addWykaz(Wykaz element)
        {
            db.wykaz.Add(element);
        }

        public void getWykaz(int ID)
        {
            db.wykaz.Find(x => x.id == ID);
        }

        public IEnumerable<Wykaz> getAllWykaz()
        {
            return db.wykaz;
        }

        public void updateWykaz(int ID, Wykaz element)
        {
            Wykaz result = db.wykaz.Find(x => x.id == ID);
            result.Clone(element);
        }

        public void deleteWykaz(Wykaz element)
        {
            db.wykaz.Remove(element);
        }

        
        private class DataContext
        {
            public List<Wykaz> wykaz;
            public Dictionary<String, Katalog> katalog;
            public ObservableCollection<Zdarzenie> zdarzenia;
            public List<OpisStanu> stany;
            internal DataContext()
            {
                wykaz = new List<Wykaz>();
                katalog = new Dictionary<string, Katalog>();
                zdarzenia = new ObservableCollection<Zdarzenie>();
                stany = new List<OpisStanu>();
            }
        }
    }
}
