using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace serwis_drugi
{
    class Program
    {
        public static List<Klient> Klienci = new List<Klient> { };
        public static List<PracownikSerwisu> PracownikSerwisus = new List<PracownikSerwisu> { };
        public static List<Narzedzia> Narzedziaa = new List<Narzedzia> { };
        public static List<Naprawa> Naprawaa = new List<Naprawa> { };
        public static List<Rower> Rowerr = new List<Rower> { };
        public static List<Czesc> Czescc = new List<Czesc> { };
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Wybierz, którą klasą chcesz zarządzać");
                Console.WriteLine("Klienci");
                Console.WriteLine("PracownikSerwisu");
                Console.WriteLine("Narzedzia");
                Console.WriteLine("Rower");
                Console.WriteLine("Naprawa");
                Console.WriteLine("Czesc");
                Console.WriteLine("Zakończ");

                string WyborKlasy = Console.ReadLine();
                if (WyborKlasy == "Klienci")
                {
                    Klienci.Clear();
                    string[] Klientt;


                    string fileName = @"C:\Users\kubus\Desktop\projekt.txt";
                    string text = File.ReadAllText(fileName);
                    string[] rows = text.Split('\n');
                    foreach (string row in rows)
                    {
                        Klientt = row.Split(", ");
                        Klienci.Add(new Klient(int.Parse(Klientt[0]), Klientt[1], Klientt[2], Klientt[3]));
                    }
                    Console.WriteLine("Wybierz co chcesz zrobić!");
                    Console.WriteLine("Wybierz 1 aby dodać");
                    Console.WriteLine("Wybierz 2 aby usunąć");
                    Console.WriteLine("Wybierz 3 aby mieć podgląd");
                    Console.WriteLine("Wybierz 4 aby modyfikować");
                    int Wybor = int.Parse(Console.ReadLine());

                    if (Wybor == 1)
                    {
                        Dodaj();
                    }
                    else if (Wybor == 2)
                    {
                        Usun();
                    }
                    else if (Wybor == 3)
                    {
                        Podglad();
                    }
                    else if (Wybor == 4)
                    {
                        Modyfikuj();
                    }
                }

                if (WyborKlasy == "PracownikSerwisu")
                {
                    PracownikSerwisus.Clear();
                    string[] PracownikSerwisust;


                    string fileName = @"C:\Users\kubus\Desktop\PracownikSerwisuuu.txt";
                    string text = File.ReadAllText(fileName);
                    string[] rows = text.Split('\n');
                    foreach (string row in rows)
                    {
                        PracownikSerwisust = row.Split(", ");
                        PracownikSerwisus.Add(new PracownikSerwisu(int.Parse(PracownikSerwisust[0]), PracownikSerwisust[1], PracownikSerwisust[2], int.Parse(PracownikSerwisust[3])));
                    }
                    Console.WriteLine("Wybierz co chcesz zrobić!");
                    Console.WriteLine("Wybierz 1 aby dodać");
                    Console.WriteLine("Wybierz 2 aby usunąć");
                    Console.WriteLine("Wybierz 3 aby mieć podgląd");
                    Console.WriteLine("Wybierz 4 aby modyfikować");
                    int Wybor = int.Parse(Console.ReadLine());

                    if (Wybor == 1)
                    {
                        DodajPracownik();
                    }
                    else if (Wybor == 2)
                    {
                        UsunPracownik();
                    }
                    else if (Wybor == 3)
                    {
                        PodgladPracownik();
                    }
                    else if (Wybor == 4)
                    {
                        ModyfikujPracownik();
                    }
                }
                if (WyborKlasy == "Zakończ")
                {
                    Environment.Exit(420);
                }



                if (WyborKlasy == "Narzedzia")
                {
                    Narzedziaa.Clear();
                    string[] NarzedziaT;


                    string fileName = @"C:\Users\kubus\Desktop\Narzedziaaa.txt";
                    string text = File.ReadAllText(fileName);
                    string[] rows = text.Split('\n');
                    foreach (string row in rows)
                    {
                        NarzedziaT = row.Split(", ");
                        Narzedziaa.Add(new Narzedzia(int.Parse(NarzedziaT[0]), NarzedziaT[1], int.Parse(NarzedziaT[2])));
                    }
                    Console.WriteLine("Wybierz co chcesz zrobić!");
                    Console.WriteLine("Wybierz 1 aby dodać");
                    Console.WriteLine("Wybierz 2 aby usunąć");
                    Console.WriteLine("Wybierz 3 aby mieć podgląd");
                    Console.WriteLine("Wybierz 4 aby modyfikować");
                    int Wybor = int.Parse(Console.ReadLine());

                    if (Wybor == 1)
                    {
                        DodajNarzedzia();
                    }
                    else if (Wybor == 2)
                    {
                        UsunNarzedzia();
                    }
                    else if (Wybor == 3)
                    {
                        PodgladNarzedzia();
                    }
                    else if (Wybor == 4)
                    {
                        ModyfikujNarzedzia();
                    }
                }

                if (WyborKlasy == "Naprawa")
                {
                    Naprawaa.Clear();
                    string[] NaprawaT;


                    string fileName = @"C:\Users\kubus\Desktop\Naprawaaa.txt";
                    string text = File.ReadAllText(fileName);
                    string[] rows = text.Split('\n');
                    foreach (string row in rows)
                    {
                        NaprawaT = row.Split(", ");
                        Naprawaa.Add(new Naprawa(int.Parse(NaprawaT[0]), DateTime.Parse(NaprawaT[1]), int.Parse(NaprawaT[2])));
                    }
                    Console.WriteLine("Wybierz co chcesz zrobić!");
                    Console.WriteLine("Wybierz 1 aby dodać");
                    Console.WriteLine("Wybierz 2 aby usunąć");
                    Console.WriteLine("Wybierz 3 aby mieć podgląd");
                    Console.WriteLine("Wybierz 4 aby modyfikować");
                    int Wybor = int.Parse(Console.ReadLine());

                    if (Wybor == 1)
                    {
                        DodajNaprawa();
                    }
                    else if (Wybor == 2)
                    {
                        UsunNaprawa();
                    }
                    else if (Wybor == 3)
                    {
                        PodgladNaprawa();
                    }
                    else if (Wybor == 4)
                    {
                        ModyfikujNaprawa();
                    }

                }


                if (WyborKlasy == "Rower")
                {
                    Rowerr.Clear();
                    string[] RowerT;


                    string fileName = @"C:\Users\kubus\Desktop\Rowerrr.txt";
                    string text = File.ReadAllText(fileName);
                    string[] rows = text.Split('\n');
                    foreach (string row in rows)
                    {
                        RowerT = row.Split(", ");
                        Rowerr.Add(new Rower(int.Parse(RowerT[0]), DateTime.Parse(RowerT[1])));
                    }
                    Console.WriteLine("Wybierz co chcesz zrobić!");
                    Console.WriteLine("Wybierz 1 aby dodać");
                    Console.WriteLine("Wybierz 2 aby usunąć");
                    Console.WriteLine("Wybierz 3 aby mieć podgląd");
                    Console.WriteLine("Wybierz 4 aby modyfikować");
                    int Wybor = int.Parse(Console.ReadLine());

                    if (Wybor == 1)
                    {
                        DodajRower();
                    }
                    else if (Wybor == 2)
                    {
                        UsunRower();
                    }
                    else if (Wybor == 3)
                    {
                        PodgladRower();
                    }
                    else if (Wybor == 4)
                    {
                        ModyfikujRower();
                    }
                }




                if (WyborKlasy == "Czesc")
                {
                    Czescc.Clear();
                    string[] CzescT;


                    string fileName = @"C:\Users\kubus\Desktop\Czesccc.txt";
                    string text = File.ReadAllText(fileName);
                    string[] rows = text.Split('\n');
                    foreach (string row in rows)
                    {
                        CzescT = row.Split(", ");
                        Czescc.Add(new Czesc(int.Parse(CzescT[0]), (CzescT[1])));
                    }
                    Console.WriteLine("Wybierz co chcesz zrobić!");
                    Console.WriteLine("Wybierz 1 aby dodać");
                    Console.WriteLine("Wybierz 2 aby usunąć");
                    Console.WriteLine("Wybierz 3 aby mieć podgląd");
                    Console.WriteLine("Wybierz 4 aby modyfikować");
                    int Wybor = int.Parse(Console.ReadLine());

                    if (Wybor == 1)
                    {
                        DodajCzesc();
                    }
                    else if (Wybor == 2)
                    {
                        UsunCzesc();
                    }
                    else if (Wybor == 3)
                    {
                        PodgladCzesc();
                    }
                    else if (Wybor == 4)
                    {
                        ModyfikujCzesc();
                    }



                }

                static void Dodaj()
                {
                    Console.WriteLine("Podaj dane");
                    using (StreamWriter writer = new StreamWriter(@"C:\Users\kubus\Desktop\projekt.txt", true))
                    {
                        writer.Write("\n" + Console.ReadLine());
                    }
                }
                static void Usun()
                {
                    Console.WriteLine("Podaj ID klienta do usunięcia: ");
                    int idDoUsuniecia = int.Parse(Console.ReadLine());

                    // Znajdź klienta do usunięcia
                    Klient klientDoUsuniecia = Klienci.Find(k => k.ID == idDoUsuniecia);

                    if (klientDoUsuniecia != null)
                    {
                        // Usuń klienta z listy
                        Klienci.Remove(klientDoUsuniecia);
                        Console.WriteLine("Klient usunięty.");

                        // Po usunięciu, zapisz zmiany z powrotem do pliku
                        ZapiszDoPliku();
                    }
                    else
                    {
                        Console.WriteLine("Nie znaleziono klienta o podanym ID.");
                    }
                }
                static void ZapiszDoPliku()
                {
                    using (StreamWriter writer = new StreamWriter(@"C:\Users\kubus\Desktop\projekt.txt"))
                    {

                        for (int j = 0; j < Klienci.Count - 1; j++)
                        {
                            writer.WriteLine($"{Klienci[j].ID}, {Klienci[j].Imie}, {Klienci[j].Nazwisko}, {Klienci[j].RodzajProblemu}");
                        }
                        writer.Write($"{Klienci[Klienci.Count - 1].ID}, {Klienci[Klienci.Count - 1].Imie}, {Klienci[Klienci.Count - 1].Nazwisko}, {Klienci[Klienci.Count - 1].RodzajProblemu}");

                    }

                }
                static void Podglad()
                {
                    Console.WriteLine("Lista klientów:");
                    foreach (Klient klient in Klienci)
                    {
                        Console.WriteLine($"ID: {klient.ID}, Imię: {klient.Imie}, Nazwisko: {klient.Nazwisko}, RodzajProblemu: {klient.RodzajProblemu}");
                    }
                }
                static void Modyfikuj()
                {
                    Console.WriteLine("Podaj ID klienta, którego chcesz zmodyfikować:");
                    int idChoice = int.Parse(Console.ReadLine());

                    Klient klientDoModyfikacji = Klienci.Find(k => k.ID == idChoice);

                    if (klientDoModyfikacji != null)
                    {
                        Console.WriteLine($"Aktualne dane klienta (ID: {klientDoModyfikacji.ID}):");
                        Console.WriteLine($"Imię: {klientDoModyfikacji.Imie}");
                        Console.WriteLine($"Nazwisko: {klientDoModyfikacji.Nazwisko}");
                        Console.WriteLine($"RodzajProblemu: {klientDoModyfikacji.RodzajProblemu}");

                        Console.WriteLine("Podaj nowe dane klienta:");

                        Console.Write("Nowe imię: ");
                        klientDoModyfikacji.Imie = Console.ReadLine();

                        Console.Write("Nowe nazwisko: ");
                        klientDoModyfikacji.Nazwisko = Console.ReadLine();

                        Console.Write("Nowy RodzajProblemu: ");
                        klientDoModyfikacji.RodzajProblemu = Console.ReadLine();

                        Console.WriteLine("Dane klienta zostały zaktualizowane.");
                        ZapiszDoPliku();
                    }
                    else
                    {
                        Console.WriteLine("Nie znaleziono klienta o podanym ID.");
                    }
                }





                //PRZESKOK DO PracownikSeriwsu







                static void DodajPracownik()
                {
                    Console.WriteLine("Podaj dane");
                    using (StreamWriter writer = new StreamWriter(@"C:\Users\kubus\Desktop\PracownikSerwisuuu.txt", true))
                    {
                        writer.Write("\n" + Console.ReadLine());
                    }
                }
                static void UsunPracownik()
                {
                    Console.WriteLine("Podaj ID Pracownika do usunięcia: ");
                    int idDoUsuniecia = int.Parse(Console.ReadLine());

                    // Znajdź klienta do usunięcia
                    PracownikSerwisu klientDoUsuniecia = PracownikSerwisus.Find(k => k.ID == idDoUsuniecia);

                    if (klientDoUsuniecia != null)
                    {
                        // Usuń klienta z listy
                        PracownikSerwisus.Remove(klientDoUsuniecia);
                        Console.WriteLine("Pracownik usunięty.");

                        // Po usunięciu, zapisz zmiany z powrotem do pliku
                        ZapiszDoPlikuPracownik();
                    }
                    else
                    {
                        Console.WriteLine("Nie znaleziono pracownika o podanym ID.");
                    }
                }
                static void ZapiszDoPlikuPracownik()
                {
                    using (StreamWriter writer = new StreamWriter(@"C:\Users\kubus\Desktop\PracownikSerwisuuu.txt"))
                    {
                        for(int i = 0; i < PracownikSerwisus.Count - 1; i++)
                        {
                            writer.WriteLine($"{PracownikSerwisus[i].ID}, {PracownikSerwisus[i].Imie}, {PracownikSerwisus[i].Nazwisko}, {PracownikSerwisus[i].Doswiadczenie}");

                        }
                        writer.Write($"{PracownikSerwisus[PracownikSerwisus.Count - 1].ID}, {PracownikSerwisus[PracownikSerwisus.Count - 1].Imie}, {PracownikSerwisus[PracownikSerwisus.Count - 1].Nazwisko}, {PracownikSerwisus[PracownikSerwisus.Count - 1].Doswiadczenie}");
                    }
                }
                static void PodgladPracownik()
                {
                    Console.WriteLine("Lista Pracowników:");
                    foreach (PracownikSerwisu PracownikSerwisu in PracownikSerwisus)
                    {
                        Console.WriteLine($"ID: {PracownikSerwisu.ID}, Imię: {PracownikSerwisu.Imie}, Nazwisko: {PracownikSerwisu.Nazwisko}, RodzajProblemu: {PracownikSerwisu.Doswiadczenie}");
                    }
                }
                static void ModyfikujPracownik()
                {
                    Console.WriteLine("Podaj ID Pracownika, którego chcesz zmodyfikować:");
                    int idChoice = int.Parse(Console.ReadLine());

                    PracownikSerwisu klientDoModyfikacji = PracownikSerwisus.Find(k => k.ID == idChoice);

                    if (klientDoModyfikacji != null)
                    {
                        Console.WriteLine($"Aktualne dane pracownika (ID: {klientDoModyfikacji.ID}):");
                        Console.WriteLine($"Imię: {klientDoModyfikacji.Imie}");
                        Console.WriteLine($"Nazwisko: {klientDoModyfikacji.Nazwisko}");
                        Console.WriteLine($"Doswiadczenie: {klientDoModyfikacji.Doswiadczenie}");

                        Console.WriteLine("Podaj nowe dane pracownika:");

                        Console.Write("Nowe imię: ");
                        klientDoModyfikacji.Imie = Console.ReadLine();

                        Console.Write("Nowe nazwisko: ");
                        klientDoModyfikacji.Nazwisko = Console.ReadLine();

                        Console.Write("Nowy Doświadczenie: ");
                        klientDoModyfikacji.Doswiadczenie = int.Parse(Console.ReadLine());

                        Console.WriteLine("Dane pracownika zostały zaktualizowane.");
                        ZapiszDoPlikuPracownik();
                    }
                    else
                    {
                        Console.WriteLine("Nie znaleziono pracowika o podanym ID.");
                    }
                }







                //Przeskok do Narzedzia







                static void DodajNarzedzia()
                {
                    Console.WriteLine("Podaj dane");
                    using (StreamWriter writer = new StreamWriter(@"C:\Users\kubus\Desktop\Narzedziaaa.txt", true))
                    {
                        writer.Write("\n" + Console.ReadLine());
                    }
                }
                static void UsunNarzedzia()
                {
                    Console.WriteLine("Podaj ID Narzędzia do usunięcia: ");
                    int idDoUsuniecia = int.Parse(Console.ReadLine());

                    // Znajdź klienta do usunięcia
                    Narzedzia klientDoUsuniecia = Narzedziaa.Find(k => k.ID == idDoUsuniecia);

                    if (klientDoUsuniecia != null)
                    {
                        // Usuń klienta z listy
                        Narzedziaa.Remove(klientDoUsuniecia);
                        Console.WriteLine("Narzedzie usunięty.");

                        // Po usunięciu, zapisz zmiany z powrotem do pliku
                        ZapiszDoPlikuNarzedzia();
                    }
                    else
                    {
                        Console.WriteLine("Nie znaleziono narzędzia o podanym ID.");
                    }
                }
                static void ZapiszDoPlikuNarzedzia()
                {
                    using (StreamWriter writer = new StreamWriter(@"C:\Users\kubus\Desktop\Narzedziaaa.txt"))
                    {


                        for (int i = 0; i < Narzedziaa.Count - 1; i++)
                        { 
                            writer.WriteLine($"{Narzedziaa[i].ID}, {Narzedziaa[i].Rodzaj}, {Narzedziaa[i].Wytrzymalosc}");
                        }
                        writer.Write($"{Narzedziaa[Narzedziaa.Count - 1].ID}, {Narzedziaa[Narzedziaa.Count - 1].Rodzaj}, {Narzedziaa[Narzedziaa.Count - 1].Wytrzymalosc}");



                    }
                }
                static void PodgladNarzedzia()
                {
                    Console.WriteLine("Lista narzędzi:");
                    foreach (Narzedzia Narzedzia in Narzedziaa)
                    {
                        Console.WriteLine($"ID: {Narzedzia.ID}, Rodzaj: {Narzedzia.Rodzaj}, Wytrzymałość: {Narzedzia.Wytrzymalosc}");
                    }
                }
                static void ModyfikujNarzedzia()
                {
                    Console.WriteLine("Podaj ID Narzędzia, które chcesz zmodyfikować:");
                    int idChoice = int.Parse(Console.ReadLine());

                    Narzedzia klientDoModyfikacji = Narzedziaa.Find(k => k.ID == idChoice);

                    if (klientDoModyfikacji != null)
                    {
                        Console.WriteLine($"Aktualne dane narzędzia (ID: {klientDoModyfikacji.ID}):");
                        Console.WriteLine($"Rodzaj: {klientDoModyfikacji.Rodzaj}");
                        Console.WriteLine($"Wytrzymałość: {klientDoModyfikacji.Wytrzymalosc}");

                        Console.WriteLine("Podaj nowe dane narzędzia:");

                        Console.Write("Nowy rodzaj: ");
                        klientDoModyfikacji.Rodzaj = Console.ReadLine();

                        Console.Write("Nowa wytrzymałość: ");
                        klientDoModyfikacji.Wytrzymalosc = int.Parse(Console.ReadLine());


                        Console.WriteLine("Dane narzędzia zostały zaktualizowane.");
                        ZapiszDoPlikuNarzedzia();
                    }
                    else
                    {
                        Console.WriteLine("Nie znaleziono narzędzia o podanym ID.");
                    }
                }






                // Przeskok do Naprawa






                static void DodajNaprawa()
                {
                    Console.WriteLine("Podaj dane");
                    using (StreamWriter writer = new StreamWriter(@"C:\Users\kubus\Desktop\Naprawaaa.txt", true))
                    {
                        writer.Write("\n" + Console.ReadLine());
                    }
                }
                static void UsunNaprawa()
                {
                    Console.WriteLine("Podaj ID Naprawy do usunięcia: ");
                    int idDoUsuniecia = int.Parse(Console.ReadLine());

                    // Znajdź klienta do usunięcia
                    Naprawa klientDoUsuniecia = Naprawaa.Find(k => k.ID == idDoUsuniecia);

                    if (klientDoUsuniecia != null)
                    {
                        // Usuń klienta z listy
                        Naprawaa.Remove(klientDoUsuniecia);
                        Console.WriteLine("Naprawa usunięta.");

                        // Po usunięciu, zapisz zmiany z powrotem do pliku
                        ZapiszDoPlikuNaprawa();
                    }
                    else
                    {
                        Console.WriteLine("Nie znaleziono naprawy o podanym ID.");
                    }
                }
                static void ZapiszDoPlikuNaprawa()
                {
                    using (StreamWriter writer = new StreamWriter(@"C:\Users\kubus\Desktop\Naprawaaa.txt"))
                    {


                        for (int i = 0; i < Naprawaa.Count - 1; i++)
                        { 
                            writer.WriteLine($"{Naprawaa[i].ID}, {Naprawaa[i].DataPrzyjecia}, {Naprawaa[i].Koszt}");
                        }
                        writer.Write($"{Naprawaa[Naprawaa.Count - 1].ID}, {Naprawaa[Naprawaa.Count - 1].DataPrzyjecia}, {Naprawaa[Naprawaa.Count - 1].Koszt}");



                    }
                }
                static void PodgladNaprawa()
                {
                    Console.WriteLine("Lista napraw:");
                    foreach (Naprawa Naprawa in Naprawaa)
                    {
                        Console.WriteLine($"ID: {Naprawa.ID}, Rodzaj: {Naprawa.DataPrzyjecia}, Wytrzymałość: {Naprawa.Koszt}");
                    }
                }
                static void ModyfikujNaprawa()
                {
                    Console.WriteLine("Podaj ID naprawy, którą chcesz zmodyfikować:");
                    int idChoice = int.Parse(Console.ReadLine());

                    Naprawa klientDoModyfikacji = Naprawaa.Find(k => k.ID == idChoice);

                    if (klientDoModyfikacji != null)
                    {
                        Console.WriteLine($"Aktualne dane naprawy (ID: {klientDoModyfikacji.ID}):");
                        Console.WriteLine($"Data Przyjęcia: {klientDoModyfikacji.DataPrzyjecia}");
                        Console.WriteLine($"Koszt: {klientDoModyfikacji.Koszt}");

                        Console.WriteLine("Podaj nowe dane naprawy:");

                        Console.Write("Nowa data przyjęcia: ");
                        klientDoModyfikacji.DataPrzyjecia = DateTime.Parse(Console.ReadLine());

                        Console.Write("Nowy koszt: ");
                        klientDoModyfikacji.Koszt = int.Parse(Console.ReadLine());


                        Console.WriteLine("Dane naprawy zostały zaktualizowane.");
                        ZapiszDoPlikuNaprawa();
                    }
                    else
                    {
                        Console.WriteLine("Nie znaleziono naprawy o podanym ID.");
                    }
                }






                //Przeskok do rower





                static void DodajRower()
                {
                    Console.WriteLine("Podaj dane: ID, data przyjęcia");
                    using (StreamWriter writer = new StreamWriter(@"C:\Users\kubus\Desktop\Rowerrr.txt", true))
                    {
                        writer.Write("\n" + Console.ReadLine());
                    }
                }
                static void UsunRower()
                {
                    Console.WriteLine("Podaj ID Roweru do usunięcia: ");
                    int idDoUsuniecia = int.Parse(Console.ReadLine());

                    // Znajdź klienta do usunięcia
                    Rower klientDoUsuniecia = Rowerr.Find(k => k.ID == idDoUsuniecia);

                    if (klientDoUsuniecia != null)
                    {
                        // Usuń klienta z listy
                        Rowerr.Remove(klientDoUsuniecia);
                        Console.WriteLine("Rower usunięty.");

                        // Po usunięciu, zapisz zmiany z powrotem do pliku
                        ZapiszDoPlikuRower();
                    }
                    else
                    {
                        Console.WriteLine("Nie znaleziono roweru o podanym ID.");
                    }
                }
                static void ZapiszDoPlikuRower()
                {
                    using (StreamWriter writer = new StreamWriter(@"C:\Users\kubus\Desktop\Rowerrr.txt"))
                    {


                        for(int i = 0; i < Rowerr.Count - 1; i++)
                        {
                            writer.WriteLine($"{Rowerr[i].ID}, {Rowerr[i].DataPrzyjecia}");
                        }
                        writer.Write($"{Rowerr[Rowerr.Count - 1].ID}, {Rowerr[Rowerr.Count - 1].DataPrzyjecia}");


                    }
                }
                static void PodgladRower()
                {
                    Console.WriteLine("Lista Rowerów:");
                    foreach (Rower Rower in Rowerr)
                    {
                        Console.WriteLine($"ID: {Rower.ID}, Data przyjęcia: {Rower.DataPrzyjecia}");
                    }
                }
                static void ModyfikujRower()
                {
                    Console.WriteLine("Podaj ID Roweru, który chcesz zmodyfikować:");
                    int idChoice = int.Parse(Console.ReadLine());

                    Rower klientDoModyfikacji = Rowerr.Find(k => k.ID == idChoice);

                    if (klientDoModyfikacji != null)
                    {
                        Console.WriteLine($"Aktualne dane roweru (ID: {klientDoModyfikacji.ID}):");
                        Console.WriteLine($"Data Przyjęcia: {klientDoModyfikacji.DataPrzyjecia}");

                        Console.WriteLine("Podaj nowe ID roweru:");

                        Console.Write("Nowa data przyjęcia: ");
                        klientDoModyfikacji.DataPrzyjecia = DateTime.Parse(Console.ReadLine());

                        Console.WriteLine("Dane naprawy zostały zaktualizowane.");
                        ZapiszDoPlikuRower();
                    }
                    else
                    {
                        Console.WriteLine("Nie znaleziono naprawy o podanym ID.");
                    }

                }





                //Przesko do czesc






                static void DodajCzesc()
                {
                    Console.WriteLine("Podaj dane: ID, nazwa części");
                    using (StreamWriter writer = new StreamWriter(@"C:\Users\kubus\Desktop\Czesccc.txt", true))
                    {
                        writer.Write("\n" + Console.ReadLine());
                    }
                }
                static void UsunCzesc()
                {
                    Console.WriteLine("Podaj ID Części do usunięcia: ");
                    int idDoUsuniecia = int.Parse(Console.ReadLine());

                    // Znajdź klienta do usunięcia
                    Czesc klientDoUsuniecia = Czescc.Find(k => k.ID == idDoUsuniecia);

                    if (klientDoUsuniecia != null)
                    {
                        // Usuń klienta z listy
                        Czescc.Remove(klientDoUsuniecia);
                        Console.WriteLine("Część usunięta.");

                        // Po usunięciu, zapisz zmiany z powrotem do pliku
                        ZapiszDoPlikuCzesc();
                    }
                    else
                    {
                        Console.WriteLine("Nie znaleziono części o podanym ID.");
                    }
                }
                static void ZapiszDoPlikuCzesc()
                {
                    using (StreamWriter writer = new StreamWriter(@"C:\Users\kubus\Desktop\Czesccc.txt"))
                    {


                        for (int i = 0; i < Czescc.Count - 1; i++)
                        { 
                            writer.WriteLine($"{Czescc[i].ID}, {Czescc[i].Nazwa}");
                        }
                        writer.Write($"{Czescc[Czescc.Count - 1].ID}, {Czescc[Czescc.Count - 1].Nazwa}");


                    }
                }
                static void PodgladCzesc()
                {
                    Console.WriteLine("Lista części:");
                    foreach (Czesc Czesc in Czescc)
                    {
                        Console.WriteLine($"ID: {Czesc.ID}, Nazwa: {Czesc.Nazwa}");
                    }
                }
                static void ModyfikujCzesc()
                {
                    Console.WriteLine("Podaj ID części, którą chcesz zmodyfikować:");
                    int idChoice = int.Parse(Console.ReadLine());

                    Czesc klientDoModyfikacji = Czescc.Find(k => k.ID == idChoice);

                    if (klientDoModyfikacji != null)
                    {
                        Console.WriteLine($"Aktualne dane części (ID: {klientDoModyfikacji.ID}):");
                        Console.WriteLine($"Nazwa części: {klientDoModyfikacji.Nazwa}");

                        Console.WriteLine("Podaj nowe dane części:");

                        Console.Write("Nowa nazwa części: ");
                        klientDoModyfikacji.Nazwa = Console.ReadLine();


                        Console.WriteLine("Dane części zostały zaktualizowane.");
                        ZapiszDoPlikuCzesc();
                    }
                    else
                    {
                        Console.WriteLine("Nie znaleziono części o podanym ID.");
                    }
                }

            }

        }
    }
}




