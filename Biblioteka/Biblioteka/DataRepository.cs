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
