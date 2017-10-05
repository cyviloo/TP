using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    public class Zdarzenie
    {
        private OpisStanu stan { get; }
        private Wykaz kto { get; }
        private DateTime kiedy { get; }

        public Zdarzenie(OpisStanu nowyStan, Wykaz kto, DateTime kiedy)
        {
            stan = nowyStan;
            this.kto = kto;
            this.kiedy = kiedy;
        }

        public Zdarzenie(OpisStanu nowyStan, Wykaz kto) : this(nowyStan, kto, DateTime.Now)
        {
        }
    }
}
