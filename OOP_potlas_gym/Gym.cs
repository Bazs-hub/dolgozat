using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_potlas_gym
{
    internal class Gym
    {
        //PROPERTY-k
        /*
         * - Az edzőterem neve
         * - Az edzőterem tagjait tároló lista
         */
       
        //KONSTRUKTOR - megkapja a nevet és a kezdeti tagok listáját

        //METÓDUSOK


        /// Hozzáad egy tagot a listához. Null értéket ne adjon hozzá.
        public void AddMember(GymMember member)
        {
        }

        /// Kiírja a konzolra az edzőterem összes tagjának adatait.
        public void DisplayAllMembers()
        {
        }

        /// Megkeresi a megadott azonosítójú klubtagot.
        /// Ha nincs ilyen tag, null értéket ad vissza.
        public GymMember FindMember(int memberId)
        {
            return null;    //ezt a sort töröld ki, mielőtt megoldod a feladatot
        }

        /// Visszaadja az összes tag havi tagsági díjának összegét.
        public double GetTotalMonthlyFees()
        {
            return 0;   //ezt a sort töröld ki, mielőtt megoldod a feladatot
        }

        /// Megadja, hogy van-e olyan klubtag, akinek az életkora
        /// nagyobb a paraméterként kapott életkornál.
        public bool HasMemberOverAge(int age)
        {
            return false;   //ezt a sort töröld ki, mielőtt megoldod a feladatot
        }
    }
}
