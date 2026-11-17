using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_potlas_gym
{
    internal class GymMember
    {
        string name = "";
        /* PROPERTY-k
         *  - A tag egyedi azonosítója. A konstruktor állítja be, később nem módosítható
         *  - A tag neve. Nem lehet üres vagy csak szóközökből álló szöveg.
         *  - A tag havi tagsági díja. Kívülről nem módosítható
         *  - A tagságból hátralévő hónapok száma. Kezdeti értéke 0
         *  - A tag életkora. Csak 16 és 100 közötti értéket fogadjon el.
         */
        public int Azonosito { get;}

        private string nev = "";
        public string Nev
        {
            get { return nev; }
            set 
            {
                if (value == "")
                {
                    Console.WriteLine("A név nem lehet üres!");
                }
                else
                {
                    nev = value;
                }
            }
        }

        public double Havidij { get; private set; }
        public int Hatralevo_honapok { get; set; } = 0;

        private int eletkor = 0;

        public int Eletkor
        {
            get { return eletkor; }
            set
            {
                if (value >= 16 && value <= 100)
                {
                    eletkor = value;
                }
            }
        }
        // KONSTRUKTOR - minden property-nek adjon értéket

        public GymMember(int azonosito, string nev, double havidij, int eletkor, int hatralevo_honapok)
        {
            Azonosito = azonosito;
            Nev = nev;
            Havidij = havidij;
            Eletkor = eletkor;
            Hatralevo_honapok = hatralevo_honapok;
        }

        /// Kiírja a klubtag adatait a konzolra 
        public void DisplayMemberInfo()
        {
            Console.WriteLine($"Azonosító: {Azonosito}");
            Console.WriteLine($"Név: {nev}");
            Console.WriteLine($"Havidíj: {Havidij}");
            Console.WriteLine($"Életkor: {eletkor}");
            Console.WriteLine($"Hátralévő hónbapok: {Hatralevo_honapok}");
        }

        /// Meghosszabbítja a tagságot a megadott hónapokkal.
        /// Nulla vagy negatív érték esetén ne változtasson semmit.
        public void RenewMembership(int months)
        {
            if (months >= 0)
            {
                Hatralevo_honapok += months;
            }


        }

        /// Megadja, hogy aktív-e a tagság (van-e még hátralévő hónap).
        public bool IsMembershipActive()
        {
            return Hatralevo_honapok > 0;
        }

        /// Kiszámítja a megadott számú hónap teljes tagsági díját.
        /// Nem pozitív hónapszám esetén 0-t ad vissza.
        public double CalculateTotalFee(int months)
        {
            if (months <= 0)
            {
                return 0;
            }
            else
            {
                return months * Havidij;
            }
        }

        /// Megadja, hogy a tag részt vehet-e haladó edzésen:
        /// legalább 18 évesnek kell lennie, és orvosi engedély is szükséges.
        public bool CanJoinAdvancedTraining(bool medicalClearance)
        {
            if (eletkor >= 18 && medicalClearance)
            {  
                return true; 
            }
            else
            {
                return false;
            }
        }

    
    }
}
