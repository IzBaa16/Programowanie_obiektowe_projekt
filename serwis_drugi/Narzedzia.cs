using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serwis_drugi
{
    class Narzedzia
    {
        public int ID { get; set; }
        public string Rodzaj { get; set; }
        public int Wytrzymalosc { get; set; }

        public Narzedzia(int id, string rodzaj, int wytrzymalosc)
        {
            ID = id;
            Rodzaj = rodzaj;
            Wytrzymalosc = wytrzymalosc;
        }
    }
}
