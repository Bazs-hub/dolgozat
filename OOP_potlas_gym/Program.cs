namespace OOP_potlas_gym
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO 
            //
            // 1. Hozz létre legalább 2 GymMember-t
            //      - id: 1, életkor 17, tagsági díj: 15000, név: saját neved, hátralévő hónapok száma: 12
            //      - id: 2, életkor 59, tagsági díj: 5000, név: János, hátralévő hónapok száma: 2


            GymMember Dili = new GymMember(1, "Balázs", 15000, 17, 12);
            GymMember Hapciii = new GymMember(2, "János", 5000, 59, 2);


            // 2. Mindegyik tagnál hívd meg a DisplayMemberInfo() metódust.

            Dili.DisplayMemberInfo();
            Console.WriteLine();
            Hapciii.DisplayMemberInfo();
            Console.WriteLine();

            // 3. Teszteld a RenewMembership() 5 és -5
            //    hónapszámmal, majd ellenőrizd az IsMembershipActive()
            //    eredményét

            Dili.RenewMembership(5);
            Dili.DisplayMemberInfo();
            Console.WriteLine();
            Dili.RenewMembership(-5);
            Dili.DisplayMemberInfo();
            Console.WriteLine();

            // 4. Teszteld a CalculateTotalFee() 5 és 0 hónappal

            Console.WriteLine($" 5 havi díja: {Dili.CalculateTotalFee(5)}");
            Console.WriteLine();
            Console.WriteLine($"0 havi díja: {Dili.CalculateTotalFee(0)}");


            // 5. Teszteld a CanJoinAdvancedTraining() metódust mindkét taggal 

            Console.WriteLine($"Balazs: {Dili.CanJoinAdvancedTraining(true)}");
            Console.WriteLine($"János: {Hapciii.CanJoinAdvancedTraining(true)}");

            // 6. Hozz létre egy List<GymMember> listát, töltsd fel a
            //    korábban létrehozott tagokkal
            //      + hozz létre egy új Gym-et : név: BlathyGym, tagok: az előbb létrehozott lista
            List<GymMember> tagok = new List<GymMember>();
            tagok.Add( Dili );
            tagok.Add( Hapciii );

            Gym BlathyGym = new Gym("BlathyGym", tagok);



            // 7. Hozz létre egy új GymMebert és ass hozzá a Gym-hez az AddMember() metódussal
            GymMember Karcsi = new GymMember(3, "Karcsi", 1000, 23, 10);
            BlathyGym.AddMember( Karcsi );
            // 8. Hívd meg a DisplayAllMembers() metódust a Gym-re
            Console.WriteLine();
            BlathyGym.DisplayAllMembers();
            // 9. Teszteld a FindMember() metódust 1 és 87-es azonosítóval
            Console.WriteLine();

            GymMember egyes = BlathyGym.FindMember(1);
            Console.WriteLine($"1-es azonosító keresése: {egyes.Nev}");
            
            Console.WriteLine($"87-es azonosító keresése: {BlathyGym.FindMember(87)}");

        }
    }
}
