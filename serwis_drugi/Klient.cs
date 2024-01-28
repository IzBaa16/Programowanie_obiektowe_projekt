using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serwis_drugi
{
    class Klient : Osoba
    {
        public string RodzajProblemu { get; set; }

        public Klient(int id, string imie, string nazwisko, string rodzajProblemu)
        {
            ID = id;
            Imie = imie;
            Nazwisko = nazwisko;
            RodzajProblemu = rodzajProblemu;
        }
    }
}
