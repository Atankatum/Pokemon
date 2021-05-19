using System;
using System.Collections.Generic;

namespace Pokemon
{
    class Program
    {
        //RESPONS ATT GÖRA MER
        //LÄGG TILL FLER ARV (EVOLUTIONS)
        //GÖR EN LOOP SOM FÖRHINDRAR SPELET ATT KRASCHA (INKLUDERA
        //TRYPARSE)
        //GÖR EN LIST / QUEUE FÖR MOTSTÅNDARE 
        //(FOREACH LOOP SOM LÄGGER TILL BASERAD PÅ EN RANDOMIZER)
        //KOMMENTERA
        //GÖR ETT KLASSDIAGRAM MED ARV
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
                    return new Piplup();
                }
                else
                {
                    return new Turtwig();
                }
            }

            //spelare är piplup, returnerar en av de andra pokemon
            else if (player is Piplup)
            {
                if(generator.Next(1,3) == 1)
                {
                return new Chimchar();
                }
                else
                {
                return new Turtwig();
                }
            }
                    
            //om spelaren är turtwig, returneras en av de två andra pokemon
            else if (player is Turtwig)
            {
                if (generator.Next(1,3) == 1)
                {
                    return new Chimchar();
                }
                else
                {
                    return new Piplup();
                }
            }
            else 
                return new Chimchar();
        }
    }
}
