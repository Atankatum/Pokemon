using System;
using System.Collections.Generic;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
         Pokemon Test = new Chimchar();
         Test.GetStats();
         Console.ReadLine();
         Pokemon Enemy = InitEnemy(Test); 
        }
        //fick hjälp med starten av metoden av casper SAAAAAAAAAAND
        public static Pokemon InitEnemy(Pokemon player)
        {
         Random generator = new Random(); 
         //om spelaren väljer chimchar, returnera en av de två andra
         if(player is Chimchar)
         {
           if(generator.Next(1,3) == 1)
           {
              return(new Piplup());
           }
           else if (generator.Next(1,3) == 2)
           {
               return(new Turtwig());
           }
         }

         //spelare är piplup, returnerar en av de andra pokemon
          else if (player is Piplup)
         {
            if(generator.Next(1,3) == 1)
                {
                 return(new Chimchar());
                }
            else if (generator.Next(1,3) == 2)
                {
                 return(new Turtwig());
                }
         }
                
        //om spelaren är turtwig, returneras en av de två andra pokemon
            else if (player is Turtwig)
            {
                if (generator.Next(1,3) == 1)
                {
                    return(new Chimchar());
                }
                else if(generator.Next(1,3) == 2)
                {
                    return(new Piplup());
                }
            }
         }
    }
}
