using System;
using System.ComponentModel.Design;

namespace Excercise_1_WorkerData
{

    //Data structure declaration

    class Program
    {
        struct Data1
        {
            public string Name;
            public string Surname;
            public int Age;
            public char Sex;
            public int Pesel;
            public int WorkerNo;
        }

        public struct Data2
        {
            public string Name;
            public string Surname;
            public int Age;
            public char Sex;
            public int Pesel;
            public int TelNo;
            public string Email;
            public float Weight;
        }

        private static void Main(string[] args)
        {
            int nr_zadania = 0;
            bool parseresult;

            do
            {

                do
                {
                    Console.WriteLine("Podaj nr zadania które chcesz wykonać" +
                    "\n1. Dane pracownika" +
                    "\n2. Zmiana kolejności" +
                    "\n3. Długość przekątnej" +
                    "\n4. Szkoła Dotneta" +
                    "\n5. Dane personalne" +
                    "\n6. Zakończ\n");
                    parseresult = Int32.TryParse(Console.ReadLine(), out nr_zadania);
                }
                while (!parseresult || nr_zadania > 12 && nr_zadania < 1);

                Console.WriteLine($"\nWybrałeś zadanie nr {nr_zadania}\n");

                switch (nr_zadania)
                {
                    case 1:
                        //Structured variable declaration
                        Data1 WorkerData1 = new Data1();
                        //Name
                        Console.WriteLine("Podaj imię pracownika");
                        WorkerData1.Name = Console.ReadLine();
                        //Surmane
                        Console.WriteLine("Podaj nazwisko pracownika");
                        WorkerData1.Surname = Console.ReadLine();
                        //Age
                        Console.WriteLine("Podaj wiek pracownika");
                        Int32.TryParse(Console.ReadLine(), out WorkerData1.Age);
                        //Sex
                        do
                        {
                            Console.WriteLine("Podaj płeć pracownika k - kobieta, m - meżczyzna");
                            Char.TryParse(Console.ReadLine(), out WorkerData1.Sex);
                        }
                        while (!WorkerData1.Sex.Equals('m') && !WorkerData1.Sex.Equals('k'));
                        //Pesel
                        Console.WriteLine("Podaj PESEL pracownika");
                        Int32.TryParse(Console.ReadLine(), out WorkerData1.Pesel);
                        //WorkerNo
                        Console.WriteLine("Podaj numer pracownika");
                        Int32.TryParse(Console.ReadLine(), out WorkerData1.WorkerNo);

                        //Display data
                        Console.WriteLine($"Imię: {WorkerData1.Name}");
                        Console.WriteLine($"Nazwisko: {WorkerData1.Surname}");
                        Console.WriteLine($"Wiek: {WorkerData1.Age}");
                        Console.WriteLine($"Płeć: {WorkerData1.Sex}");
                        Console.WriteLine($"PESEL: {WorkerData1.Pesel}");
                        Console.WriteLine($"Numer pracownika: {WorkerData1.WorkerNo}");
                    break;
                    case 2:
                        char letter1 = ' ';
                        char letter2 = ' ';
                        char letter3 = ' ';

                        //Letter1
                        Console.WriteLine("Podaj pierwszą literę");
                        Char.TryParse(Console.ReadLine(), out letter1);
                        //Letter2
                        Console.WriteLine("Podaj drugą literę");
                        Char.TryParse(Console.ReadLine(), out letter2);
                        //Letter3
                        Console.WriteLine("Podaj trzecią literę");
                        Char.TryParse(Console.ReadLine(), out letter3);

                        //Display data
                        Console.WriteLine($"Litera 3: {letter3}");
                        Console.WriteLine($"Litera 2: {letter2}");
                        Console.WriteLine($"Litera 1: {letter1}");
                    break;
                    case 3:
                        int a = 0;
                        int b = 0;
                        double przekatna = 0;

                        //Bok a
                        Console.WriteLine("Podaj długość pierwszego boku");
                        Int32.TryParse(Console.ReadLine(), out a);
                        //Bok b
                        Console.WriteLine("Podaj długość drugiego boku");
                        Int32.TryParse(Console.ReadLine(), out b);

                        przekatna = Math.Pow((Math.Pow(a, 2) + Math.Pow(b, 2)), 0.5);
                        //Display data
                        Console.WriteLine($"Litera 3: {przekatna}");
                    break;
                    case 4:
                        int c = 10;
                        string d = "Szkola Dotneta";
                        double e = 10.5;

                        //Display data
                        Console.WriteLine(c);
                        Console.WriteLine(d);
                        Console.WriteLine(e);
                        break;
                    case 5:
                        //Structured variable declaration
                        Data2 WorkerData2 = new Data2();
                        //Name
                        Console.WriteLine("Podaj imię");
                        WorkerData2.Name = Console.ReadLine();
                        //Surmane
                        Console.WriteLine("Podaj nazwisko");
                        WorkerData2.Surname = Console.ReadLine();
                        //Age
                        Console.WriteLine("Podaj wiek");
                        Int32.TryParse(Console.ReadLine(), out WorkerData2.Age);
                        //Sex
                        do
                        {
                            Console.WriteLine("Podaj płeć k - kobieta, m - meżczyzna");
                            Char.TryParse(Console.ReadLine(), out WorkerData2.Sex);
                        }
                        while (!WorkerData2.Sex.Equals('m') && !WorkerData2.Sex.Equals('k'));
                        //Pesel
                        Console.WriteLine("Podaj PESEL");
                        Int32.TryParse(Console.ReadLine(), out WorkerData2.Pesel);
                        //TelNo
                        Console.WriteLine("Podaj numer telefonu");
                        Int32.TryParse(Console.ReadLine(), out WorkerData2.TelNo);
                        //Email
                        Console.WriteLine("Podaj adres email");
                        WorkerData2.Email = Console.ReadLine();
                        //Weight
                        Console.WriteLine("Podaj wage w kilogramach");
                        float.TryParse(Console.ReadLine(), out WorkerData2.Weight);

                        //Display data
                        Console.WriteLine($"Imię: {WorkerData2.Name}");
                        Console.WriteLine($"Nazwisko: {WorkerData2.Surname}");
                        Console.WriteLine($"Wiek: {WorkerData2.Age}");
                        Console.WriteLine($"Płeć: {WorkerData2.Sex}");
                        Console.WriteLine($"PESEL: {WorkerData2.Pesel}");
                        Console.WriteLine($"Numer telefonu: {WorkerData2.TelNo}");
                        Console.WriteLine($"Email: {WorkerData2.Email}");
                        Console.WriteLine($"Waga: {WorkerData2.Weight} kg");
                        break;

                }
            } while (nr_zadania != 6);
        }
    }



}
        