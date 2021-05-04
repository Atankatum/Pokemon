using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Chimchar chimchim = new Chimchar(); 
            System.Console.WriteLine(chimchim.hp);
            System.Console.WriteLine(chimchim.attack);
            System.Console.WriteLine(chimchim.defense);
            System.Console.WriteLine(chimchim.experience);
            System.Console.WriteLine(chimchim.level);
            System.Console.WriteLine(chimchim.speed);
            System.Console.WriteLine(chimchim.name);
            System.Console.WriteLine(chimchim.gender);

            Piplup piplup = new Piplup();


            chimchim.Attack(piplup);

            if (chimchim.attack > piplup.defense)
            {
                piplup.Hurt(chimchim.attack);
            }

            Console.ReadLine();
        }
    }
}
