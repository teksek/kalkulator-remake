using System;
using System.Runtime.CompilerServices;

namespace kalkulator
{
    public class kalkulatormain
    {
        static void Main(string[] args)
        {
            Mainmenu();
        }

        public static void Mainmenu()
        {
            Console.WriteLine("Kalkulator");
            Console.WriteLine("");
            Console.WriteLine("Co chciał*byś obliczyć?");
            Console.WriteLine("");
            Console.WriteLine("||Figury Płaskie||");
            Console.WriteLine("1. Pole");
            Console.WriteLine("2. Obwód");
            Console.WriteLine("3. Wysokość");
            Console.WriteLine("4. Przekątna");
            Console.WriteLine("");
            Console.WriteLine("||Bryły||");
            Console.WriteLine("5. Pole Całkowite");
            Console.WriteLine("6. Objętość");
            Console.WriteLine("");
            Console.WriteLine("7. Wyjście z programu");
            Console.WriteLine("");
            Console.WriteLine("||Dodatkowe Funkcje (Gry matematyczne)||");
            Console.WriteLine("");
            string choice1 = Console.ReadLine();
            Convert.ToByte(choice1);

            switch (choice1)
            {
                case "1":
                    Console.Clear();
                    Pole();
                    break;
                case "2":
                    Console.Clear();
                    Obwod();
                    break;
                case "3":
                    Console.Clear();
                    Wysokosc();
                    break;
                case "4":
                    Console.Clear();
                    Przekatna();
                    break;
                case "5":
                    Console.Clear();
                    PoleCalkowite();
                    break;
                case "6":
                    Console.Clear();
                    Objetosc();
                    break;
                case "7":
                    Console.Clear();
                    Console.WriteLine("Wyłączam się...");
                    Thread.Sleep(1000);
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Takiego wyboru nie ma na liście, spróbuj jeszcze raz!");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Mainmenu();
                    break;
            }


        }

        /// <summary>
        /// FIGURY PŁASKIE!
        /// </summary>

        public static void Pole()
        {
            Console.WriteLine("Ok, wybrałeś obliczanie Pola.");
            Thread.Sleep(500);
            Console.WriteLine("");
            Console.WriteLine("A więc jakiej figury chciał*byś obliczyć pole?:");
            Console.WriteLine("1. Kwadrat");
            Console.WriteLine("2. Prostokąt");
            Console.WriteLine("3. Trójkąt");
            Console.WriteLine("4. Trójkąt równoboczny");
            Console.WriteLine("5. Trapez");
            Console.WriteLine("6. Równoległobok");
            Console.WriteLine("7. Deltoid");
            Console.WriteLine("8. Romb");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("9. Wyjście z programu.");
            string choice1 = Console.ReadLine();
            Convert.ToByte(choice1);

            switch (choice1)
            {
                case "1":
                    Console.Clear();
                    KwadratPole();
                    break;
                case "2":
                    Console.Clear();
                    ProstokatPole();
                    break;
                case "3":
                    Console.Clear();
                    TrojkatPole();
                    break;
                case "4":
                    Console.Clear();
                    TrojkatRownobocznyPole();
                    break;
                case "5":
                    Console.Clear();
                    TrapezPole();
                    break;
                case "6":
                    Console.Clear();
                    RownoleglobokPole();
                    break;
                case "7":
                    Console.Clear();
                    DeltoidPole();
                    break;
                case "8":
                    Console.Clear();
                    RombPole();
                    break;
                case "9":
                    Console.Clear();
                    Exit();
                    break;
                default:
                    Console.WriteLine("Wybrałeś złą opcję! Spróbuj jeszcze raz!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Mainmenu();
                    break;
            }
        }

        public static void Obwod()
        {
            Console.WriteLine("Ok, wybrałeś obliczanie Obwodu.");
            Thread.Sleep(500);
            Console.WriteLine("");
            Console.WriteLine("A więc jakiej figury chciał*abyś obliczyć pole?");
            Console.WriteLine("1. Kwadrat");
            Console.WriteLine("2. Prostokąt");
            Console.WriteLine("3. Trójkąt");
            Console.WriteLine("4. Trójkąt równoboczny");
            Console.WriteLine("5. Trapez");
            Console.WriteLine("6. Równoległobok");
            Console.WriteLine("7. Deltoid");
            Console.WriteLine("8. Romb");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("9. Wyjście z programu.");
            string choice1 = Console.ReadLine();
            Convert.ToByte(choice1);

            switch(choice1)
            {
                case "1":
                    Console.Clear();
                    KwadratObwod();
                    break;
                case "2":
                    Console.Clear();
                    ProstokatObwod();
                    break;
                case "3":
                    Console.Clear();
                    TrojkatObwod();
                    break;
                case "4":
                    Console.Clear();
                    TrojkatRownobocznyObwod();
                    break;
                case "5":
                    Console.Clear();
                    TrapezObwod();
                    break;
                case "6":
                    Console.Clear();
                    RownoleglobokObwod();
                    break;
                case "7":
                    Console.Clear();
                    DeltoidObwod();
                    break;
                case "8":
                    Console.Clear();
                    RombObwod();
                    break;
                case "9":
                    Console.Clear();
                    Exit();
                    break;
                default:
                    Console.WriteLine("Wybrałeś złą opcję! Spróbuj jeszcze raz!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Mainmenu();
                    break;
            }
        }

        public static void Wysokosc()
        {
            Console.WriteLine("Ok, wybrałeś obliczanie Wysokości.");
            Console.WriteLine("");
            Thread.Sleep(500);
            Console.WriteLine("A więc jakiej figury chciałbyś obliczyć wysokość?:");
            Console.WriteLine("1. Trójkąt równoboczny.");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("2. Wyjście z programu");
            string choice = Console.ReadLine();
            
            if (choice == "1")
            {
                Console.Clear();
                TrojkatRownobocznyWysokosc();
            }
            else if (choice == "2")
            {
                Exit();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wybrałeś złą opcję! Spróbuj jeszcze raz!");
                Thread.Sleep(2000);
                Console.Clear();
                Mainmenu();
            }
        }

        public static void Przekatna()
        {
            Console.WriteLine("Ok, wybrałeś obliczanie Przekątnej.");
            Console.WriteLine("");
            Thread.Sleep(500);
            Console.WriteLine("A więc jakiej figury chciał*byś obliczyć przekątną?:");
            Console.WriteLine("1. Kwadrat/Prostokąt/Trójkąt");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("2. Wyjście z programu.");
            string choice = Console.ReadLine();
            
            if (choice == "1")
            {
                Console.Clear();
                KwadratProstokatTrojkatPrzekatna();
            }
            else if (choice == "2")
            {
                Exit();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wybrałeś złą opcję! Spróbuj jeszcze raz!");
                Thread.Sleep(2000);
                Console.Clear();
                Mainmenu();
            }
            
        }

        /// <summary>
        /// BRYŁY!
        /// </summary>

        public static void PoleCalkowite()
        {
            Console.WriteLine("Ok, wybrałeś obliczanie Pola Całkowitego brył.");
            Console.WriteLine("");
            Thread.Sleep(500);
            Console.WriteLine("A więc jakiej bryły chciałbyś obliczyć Pole Całkowite?:");
            Console.WriteLine("1. Graniastosłup");
            Console.WriteLine("2. Sześcian");
            Console.WriteLine("3. Prostopadłościan");
            Console.WriteLine("4. Ostrosłup");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("5. Wyjście z programu.");
            string choice = Console.ReadLine();
            Convert.ToByte(choice);

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    GraniastoslupPoleCalkowite();
                    break;
                case "2":
                    Console.Clear();
                    SzescianPoleCalkowite();
                    break;
                case "3":
                    Console.Clear();
                    ProstopadloscianPoleCalkowite();
                    break;
                case "4":
                    Console.Clear();
                    OstrosłupPoleCalkowite();
                    break;
                case "5":
                    Console.Clear();
                    Exit();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Wybrałeś złą opcję! Spróbuj jeszcze raz!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Mainmenu();
                    break;
            }
        }

        public static void Objetosc()
        {
            Console.WriteLine("Ok, wybrał*ś obliczanie Objętości brył.");
            Console.WriteLine("");
            Thread.Sleep(500);
            Console.WriteLine("A więc jakiej bryły chciałbyś obliczyć Objętość?:");
            Console.WriteLine("1. Graniastosłup");
            Console.WriteLine("2. Sześcian");
            Console.WriteLine("3. Prostopadłościan");
            Console.WriteLine("4. Ostrosłup");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("5. Wyjście z programu.");
            string choice = Console.ReadLine();
            Convert.ToByte(choice);

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    GraniastoslupObjetosc();
                    break;
                case "2":
                    Console.Clear();
                    SzescianObjetosc();
                    break;
                case "3":
                    Console.Clear();
                    ProstopadloscianObjetosc();
                    break;
                case "4":
                    Console.Clear();
                    OstroslupObjetosc();
                    break;
                case "5":
                    Console.Clear();
                    Exit();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Wybrałeś złą opcję! Spróbuj jeszcze raz!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Mainmenu();
                    break;
            }
        }

        /// <summary>
        ///  UŻYTKOWE
        /// </summary>

        public static void Again()
        {
            Console.WriteLine("Chcesz jeszcze coś obliczyć?");
            Console.WriteLine("1. Tak");
            Console.WriteLine("2. Nie");
            string choice2137 = Console.ReadLine();
            Convert.ToByte(choice2137);
            //papiezuwa troche

            if (choice2137 == "1")
            {
                Console.Clear();
                Mainmenu();
            }
            else if (choice2137 == "2")
            {
                Console.Clear();
                Exit();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wybrałeś złą opcję! Spróbuj jeszcze raz!");
                Thread.Sleep(2000);
                Console.Clear();
                Mainmenu();
            }
        }

        public static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Wyłączam się...");
            Thread.Sleep(1000);
            Console.Clear();
            System.Environment.Exit(0);
        }

        /// <summary>
        /// OBLICZENIA!
        /// </summary>

        /**
        p
        o
        t
        e
        n
        g
        i
        **/

        public static void KwadratPole()
        {
            Console.Clear();
            Console.WriteLine("Podaj bok kwadratu:");
            string a = Console.ReadLine();
            double ad = double.Parse(a);
            Console.WriteLine("Wynik: " + Math.Pow(ad, 2));
            Again();
        }

        public static void ProstokatPole()
        {
            Console.Clear();
            Console.WriteLine("Podaj dłuższy bok prostokąta");
            string a = Console.ReadLine();
            double ad = double.Parse(a);
            Console.WriteLine("Podaj krótszy bok prostokąta");
            string b = Console.ReadLine();
            double bd = double.Parse(b);
            Console.WriteLine("Wynik: " + (ad*bd));
            Again();
        }

        public static void TrojkatPole()
        {
            Console.Clear();
            Console.WriteLine("Podaj a:");
            string a = Console.ReadLine();
            double ad = double.Parse(a);
            Console.WriteLine("Podaj h:");
            string h = Console.ReadLine();
            double hd = double.Parse(h);
            Console.WriteLine("Wynik: " + ((ad * hd) / 2));
            Again();
        }

        public static void TrojkatRownobocznyPole()
        {
            Console.Clear();
            Console.WriteLine("Podaj a:");
            string a = Console.ReadLine();
            double ad = double.Parse(a);
            Console.WriteLine("Wynik: " + (Math.Pow(ad,2) * Math.Sqrt(3)) / 4 );
            Again();
        }

        public static void TrapezPole()
        {
            Console.Clear();
            Console.WriteLine("Podaj a: ");
            string a = Console.ReadLine();
            double ad = double.Parse(a);
            Console.WriteLine("Podaj b: ");
            string b = Console.ReadLine();
            double bd = double.Parse(b);
            Console.WriteLine("Podaj h: ");
            string h = Console.ReadLine();
            double hd = double.Parse(h);
            Console.WriteLine("Wynik: " + (ad+bd) * hd / 2);
            Again();
        }

        public static void RownoleglobokPole()
        {
            Console.Clear();
            Console.WriteLine("Podaj a: ");
            string a = Console.ReadLine();
            double ad = double.Parse(a);
            Console.WriteLine("Podaj h: ");
            string h = Console.ReadLine();
            double hd = double.Parse(h);
            Console.WriteLine("Wynik: " + (ad * hd));
            Again();
        }

        public static void DeltoidPole()
        {
            Console.Clear();
            Console.WriteLine("Podaj d1: ");
            string d1 = Console.ReadLine();
            double d1d = double.Parse(d1);
            Console.WriteLine("Podaj d2: ");
            string d2 = Console.ReadLine();
            double d2d = double.Parse(d2);
            Console.WriteLine("Wynik: " + (d1d*d2d / 2));
            Again();
        }

        public static void RombPole()
        {
            Console.Clear();
            Console.WriteLine("Które pole rombu chciał*byś obliczyć?");
            Console.WriteLine("1. Z przekątnymi. (e i f)");
            Console.WriteLine("2. Z wysokością i bokiem. (a i h)");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("3. Wyjście z programu.");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Clear();
                Console.WriteLine("Podaj e: ");
                string e = Console.ReadLine();
                double ed = double.Parse(e);
                Console.WriteLine("Podaj f: ");
                string f = Console.ReadLine();
                double fd = double.Parse(f);
                Console.WriteLine("Wynik: " + (ed * fd / 2));
                Again();
            }
            else if (choice == "2")
            {
                Console.Clear();
                Console.WriteLine("Podaj a: ");
                string a = Console.ReadLine();
                double ad = double.Parse(a);
                Console.WriteLine("Podaj h: ");
                string h = Console.ReadLine();
                double hd = double.Parse(h);
                Console.WriteLine("Wynik: " + (ad*hd));
                Again();
            }
            else if (choice == "3")
            {
                Exit();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wybrałeś złą opcję! Spróbuj jeszcze raz!");
                Thread.Sleep(2000);
                Console.Clear();
                RombPole();
            }
        }

        /**
        o
        b
        w
        ó
        d
        **/

        public static void KwadratObwod()
        {
            Console.Clear();
            Console.WriteLine("Podaj a: ");
            string a = Console.ReadLine();
            double ad = double.Parse(a);
            Console.WriteLine("Wynik: " + (4*ad));
            Again();
        }

        public static void ProstokatObwod()
        {
            Console.Clear();
            Console.WriteLine("Podaj a: ");
            string a = Console.ReadLine();
            double ad = double.Parse(a);
            Console.WriteLine("Podaj b: ");
            string b = Console.ReadLine();
            double bd = double.Parse(b);
            Console.WriteLine("Wynik: " + ((2*ad) + (2*bd)));
            Again();
        }

        public static void TrojkatObwod()
        {
            Console.Clear();
            Console.WriteLine("Podaj a: ");
            string a = Console.ReadLine();
            double ad = double.Parse(a);
            Console.WriteLine("Podaj b: ");
            string b = Console.ReadLine();
            double bd = double.Parse(b);
            Console.WriteLine("Podaj c: ");
            string c = Console.ReadLine();
            double cd = double.Parse(c);
            Console.WriteLine("Wynik: " + (ad + bd + cd));
            Again();
        }

        public static void TrojkatRownobocznyObwod()
        {
            Console.Clear();
            Console.WriteLine("Podaj a: ");
            string a = Console.ReadLine();
            double ad = Double.Parse(a);
            Console.WriteLine("Wynik: " + (3*ad));
            Again();
        }

        public static void TrapezObwod()
        {
            Console.Clear();
            Console.WriteLine("Podaj a: ");
            string a = Console.ReadLine();
            double ad = double.Parse(a);
            Console.WriteLine("Podaj b: ");
            string b = Console.ReadLine();
            double bd = double.Parse(b);
            Console.WriteLine("Podaj c: ");
            string c = Console.ReadLine();
            double cd = double.Parse(c);
            Console.WriteLine("Podaj d: ");
            string d = Console.ReadLine();
            double dd = double.Parse(d);
            Console.WriteLine("Wynik: " + (ad+bd+cd+dd));
            Again();
        }

        public static void RownoleglobokObwod()
        {
            Console.Clear();
            Console.WriteLine("Podaj a: ");
            string a = Console.ReadLine();
            double ad = double.Parse(a);
            Console.WriteLine("Podaj b: ");
            string b = Console.ReadLine();
            double bd = Double.Parse(b);
            Console.WriteLine("Wynik: " + ((2*ad) + (2*bd)));
            Again();
        }

        public static void DeltoidObwod()
        {
            Console.Clear();
            Console.WriteLine("Podaj a: ");
            string a = Console.ReadLine();
            double ad = double.Parse(a);
            Console.WriteLine("Podaj b: ");
            string b = Console.ReadLine();
            double bd = Double.Parse(b);
            Console.WriteLine("Wynik: " + ((2 * ad) + (2 * bd)));
            Again();
        }

        public static void RombObwod()
        {
            Console.Clear();
            Console.WriteLine("Podaj a: ");
            string a = Console.ReadLine();
            double ad = Double.Parse(a);
            Console.WriteLine("Wynik: " + (4*ad));
            Again();
        }

        /**
         * w
         * y
         * s
         * o
         * k
         * o
         * s
         * c
         **/

        public static void TrojkatRownobocznyWysokosc()
        {
            Console.Clear();
            Console.WriteLine("Podaj bok trójkąta(a): ");
            string a = Console.ReadLine();
            double ad = double.Parse(a);
            Console.WriteLine("Wynik: " + (ad * Math.Sqrt(3) / 2));
            Again();
        }

        /**
         * p
         * r
         * z
         * e
         * k
         * a
         * t
         * n
         * a
         **/

        public static void KwadratProstokatTrojkatPrzekatna()
        {
            Console.Clear();
            Console.WriteLine("Podaj a: ");
            string a = Console.ReadLine();
            double ad = double.Parse(a);
            Console.WriteLine("Chcesz obliczyć co wyjdzie z tego działania czy zostawić w zwykłej formie?");
            string choice = Console.ReadLine();
            Console.WriteLine("1. Oblicz");
            Console.WriteLine("2. Zostaw");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("3. Wyjście z programu.");

            if (choice == "1")
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Wynik: " + (ad * Math.Sqrt(2)));
                Again();
            }
            else if (choice == "2")
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Wynik: " + "d = " + ad + "√2");
                Again();
            }
            else if (choice == "3")
            {
                Exit();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wybrałeś złą opcję! Spróbuj jeszcze raz!");
                Thread.Sleep(2000);
                Console.Clear();
                KwadratProstokatTrojkatPrzekatna();
            }
        }

        /**
         * p
         * o
         * l
         * e
         * 
         * c
         * a
         * l
         * k
         * o
         * w
         * i
         * t
         * e
         **/

        public static void GraniastoslupPoleCalkowite()
        {
            Console.Clear();
            Console.WriteLine("Podaj Pole Podstawy: ");
            string pp = Console.ReadLine();
            double ppd = double.Parse(pp);
            Console.WriteLine("Podaj Pole Boczne: ");
            string pb = Console.ReadLine();
            double pbd = double.Parse(pb);
            Console.WriteLine("Wynik: " + ((2*ppd) + pbd));
            Again();
        }

        public static void SzescianPoleCalkowite()
        {
            Console.Clear();
            Console.WriteLine("Podaj a: ");
            string a = Console.ReadLine();
            double ad = double.Parse(a);
            Console.WriteLine("Wynik: " + (6 * Math.Pow(ad, 2)));
            Again();
        }

        public static void ProstopadloscianPoleCalkowite()
        {
            Console.Clear();
            Console.WriteLine("Podaj a: ");
            string a = Console.ReadLine();
            double ad = double.Parse(a);
            Console.WriteLine("Podaj b: ");
            string b = Console.ReadLine();
            double bd = double.Parse(b);
            Console.WriteLine("Podaj c: ");
            string c = Console.ReadLine();
            double cd = double.Parse(c);
            Console.WriteLine("Wynik: " + 2 * (ad * bd * (ad * cd) * (bd * cd)));
            Again();
        }

        public static void OstrosłupPoleCalkowite()
        {
            Console.Clear();
            Console.WriteLine("Podaj Pole Podstawy: ");
            string pp = Console.ReadLine();
            double ppd = double.Parse(pp);
            Console.WriteLine("Podaj Pole Boczne: ");
            string pb = Console.ReadLine();
            double pbd = double.Parse(pb);
            Console.WriteLine("Wynik: " + (ppd + pbd));
            Again();
        }

        /**
         * o
         * b
         * j
         * e
         * t
         * o
         * s
         * c
         **/

        public static void GraniastoslupObjetosc()
        {
            Console.Clear();
            Console.WriteLine("Podaj Pole Podstawy: ");
            string pp = Console.ReadLine();
            double ppd = Double.Parse(pp);
            Console.WriteLine("Podaj Wysokość(H): ");
            string h = Console.ReadLine();
            double hd = Double.Parse(h);
            Console.WriteLine("Wynik: " + (ppd * hd));
            Again();
        }

        public static void SzescianObjetosc()
        {
            Console.Clear();
            Console.WriteLine("Podaj a: ");
            string a = Console.ReadLine();
            double ad = Double.Parse(a);
            Console.WriteLine("Wynik: " + Math.Pow(ad, 3));
            Again();
        }

        public static void ProstopadloscianObjetosc()
        {
            Console.Clear();
            Console.WriteLine("Podaj a: ");
            string a = Console.ReadLine();
            double ad = double.Parse(a);
            Console.WriteLine("Podaj b: ");
            string b = Console.ReadLine();
            double bd = double.Parse(b);
            Console.WriteLine("Podaj c: ");
            string c = Console.ReadLine();
            double cd = double.Parse(c);
            Console.WriteLine("Wynik: " + (ad*bd*cd));
            Again();
        }

        public static void OstroslupObjetosc()
        {
            Console.WriteLine("Podaj Pole Podstawy: ");
            string pp = Console.ReadLine();
            double ppd = double.Parse(pp);
            Console.WriteLine("Podaj Wysokość(H): ");
            string h = Console.ReadLine();
            double hd = double.Parse(h);
            Console.WriteLine("Wynik: " + ((ppd * hd) / 3));
            Again();
        }
    }
}
