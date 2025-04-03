namespace Linqmaksimov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Maksimov Linq Tööd");
            ThenByMethod();
        }

        public static void ThenByMethod()
        {
            var people = new List<(string Name, int age)>
            {
                //siin ma panen kõik listis.
                //teen kaks muutujad (string) name ja (int)age
                ("Vitali", 30),
                ("Anna", 19),
                ("Mart", 33),
                ("Lembitu", 25),
                ("Aleksandr", 58),
                ("Silver", 29),
                ("Anneli", 22),
                ("Kätlin", 20)
            };

            //siin ma teen muutuja sorted list kus sorteerin esimeseks p.age ja teiseks (THENBY => Name)
            //kokku teeb kaks sorteerimist.
            var sorted = people.OrderBy(p => p.age).ThenBy(p => p.Name);

            foreach (var peop in sorted)
            {
                Console.WriteLine("Hello, " + peop.Name + ", your age is: " + peop.age);
            }


        }
    }
}
