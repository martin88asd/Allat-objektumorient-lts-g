using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatok
{
    class Versenyzo
    {

        private string nev;
        private int szuletesEv;

        private int szepseg, viselkedes;
        private int pont;

        private static int Ev;
        private static int korHatar;




        public Versenyzo(string nev, int szuletesEv)
        {
            this.nev = nev;
            this.szuletesEv = szuletesEv;

        }

        public int Kor()
        {
            return Ev - szuletesEv;
        }
        public void Pontozas(int szepseg, int viskelkedes)
        {
            this.szepseg = szepseg;
            this.viselkedes = viskelkedes;
            if (Kor() <= korHatar)
            {
                pont = viselkedes * Kor() + szepseg * (korHatar - Kor());
            }
            else
            {
                pont = 0;
            }
        }
        public override string ToString()
        {
            return nev + " Pontszáma: " + pont;
        }

        public string Neve
        {
            get { return nev; }
        }

        public int SzuletesEve
        {
            get { return szuletesEv; }
        }

        public int SzepsegPontja
        {
            get { return szepseg; }
        }

        public int ViselkedesPontja
        {
            get { return viselkedes; }
        }

        public int Pontszama
        {
            get { return pont; }
        }


        public static int AktualisEv
        {
            get { return Ev; }
            set { Ev = value; }
        }

        public static int KorHatar
        {
            get { return korHatar; }
            set { korHatar = value; }
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Versenyzo versenyzo;

            int aktEv = 2024;
            int korhatar = 10;

            string nev;
            int szulEv;
            int szepsege;
            int viselkedese;

            Versenyzo.AktualisEv = aktEv;
            Versenyzo.KorHatar = korhatar;

            Random rnd = new Random();
            nev = "Szörős";
            szulEv = 2014;
            szepsege = rnd.Next(1, 10);
            viselkedese = rnd.Next(1, 10);

            versenyzo = new Versenyzo(nev, szulEv);

            versenyzo.Pontozas(szepsege, viselkedese);

            Console.WriteLine(versenyzo);

            Console.ReadKey();
        }
    }
}
