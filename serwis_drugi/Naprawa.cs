using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using serwis_drugi;

namespace serwis_drugi
{
    class Naprawa : Rower
    {
        public int Koszt { get; set; }


        public Naprawa(int id, DateTime dataPrzyjecia, int koszt) : base(id, dataPrzyjecia)
        {
            ID = id;
            DataPrzyjecia = dataPrzyjecia;
            Koszt = koszt;
        }
    }
}









