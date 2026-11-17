using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_potlas_gym
{
    internal class GymMember
    {
        /* PROPERTY-k
         *  - A tag egyedi azonosítója. A konstruktor állítja be, később nem módosítható
         *  - A tag neve. Nem lehet üres vagy csak szóközökből álló szöveg.
         *  - A tag havi tagsági díja. Kívülről nem módosítható
         *  - A tagságból hátralévő hónapok száma. Kezdeti értéke 0
         *  - A tag életkora. Csak 16 és 100 közötti értéket fogadjon el.
         */



       // KONSTRUKTOR - minden property-nek adjon értéket


        /// Kiírja a klubtag adatait a konzolra 
        public void DisplayMemberInfo()
        {
        }

        /// Meghosszabbítja a tagságot a megadott hónapokkal.
        /// Nulla vagy negatív érték esetén ne változtasson semmit.
        public void RenewMembership(int months)
        {
        }

        /// Megadja, hogy aktív-e a tagság (van-e még hátralévő hónap).
        public bool IsMembershipActive()
        {
            return false;   //ezt a sort töröld ki, mielőtt megoldod a feladatot
        }

        /// Kiszámítja a megadott számú hónap teljes tagsági díját.
        /// Nem pozitív hónapszám esetén 0-t ad vissza.
        public double CalculateTotalFee(int months)
        {
            return 0;   //ezt a sort töröld ki, mielőtt megoldod a feladatot
        }

        /// Megadja, hogy a tag részt vehet-e haladó edzésen:
        /// legalább 18 évesnek kell lennie, és orvosi engedély is szükséges.
        public bool CanJoinAdvancedTraining(bool medicalClearance)
        {
            return false;   //ezt a sort töröld ki, mielőtt megoldod a feladatot
        }
    }
}
