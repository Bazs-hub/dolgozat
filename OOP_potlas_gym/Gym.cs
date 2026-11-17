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
        public string Edzoteremneve { get; set; }

        List<GymMember> tagok = new List<GymMember>();



        //KONSTRUKTOR - megkapja a nevet és a kezdeti tagok listáját

        public Gym(string edzoteremneve, List<GymMember> kezdeti_tagok)
        {
            Edzoteremneve = edzoteremneve;
            tagok = kezdeti_tagok;
        }


        //METÓDUSOK


        /// Hozzáad egy tagot a listához. Null értéket ne adjon hozzá.
        public void AddMember(GymMember member)
        {
            if (member != null)
            {
                tagok.Add(member);
            }
        }

        /// Kiírja a konzolra az edzőterem összes tagjának adatait.
        public void DisplayAllMembers()
        {
            foreach (GymMember member in tagok)
            {
                Console.WriteLine($"Azonosító: {member.Azonosito}\n Név: {member.Nev}\n Havi díj: {member.Havidij}\n Életkor: {member.Eletkor}\n Hátralévő hónapok: {member.Hatralevo_honapok}");
            }

        }

        /// Megkeresi a megadott azonosítójú klubtagot.
        /// Ha nincs ilyen tag, null értéket ad vissza.
        public GymMember FindMember(int memberId)
        {
            foreach (GymMember member in tagok)
            {
                if (member.Azonosito == memberId)
                {
                    return member;
                }
            }
            return null;
        }

        /// Visszaadja az összes tag havi tagsági díjának összegét.
        public double GetTotalMonthlyFees()
        {
            double tagdij = 0;

            foreach (GymMember member in tagok)
            {
                tagdij += member.Azonosito;
            }
            return tagdij;
        }

        /// Megadja, hogy van-e olyan klubtag, akinek az életkora
        /// nagyobb a paraméterként kapott életkornál.
        public bool HasMemberOverAge(int age)
        {
            foreach (GymMember member in tagok)
            {
                if (member.Eletkor > age)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
