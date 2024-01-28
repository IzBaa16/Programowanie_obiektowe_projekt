using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serwis_drugi
{
    class Czesc
    {
        public int ID { get; set; }
        public string Nazwa { get; set; }

        public Czesc(int id, string nazwa)
        {
            ID = id;
            Nazwa = nazwa;
        }
    }
}
