using System;
using System.Collections.Generic;

namespace Pokemon
{
    public class Chimchar : Pokemon
    {
     //konstruktor för chimchar, sätter värderna på dess stats.
        public Chimchar()
        {
            name = "Chimchar";  
            hp =  generator.Next(20, 31);
            attack = generator.Next(5, 8);
            defense = generator.Next(3, 5); 
            speed = generator.Next(6, 10);
            experience = 0;
            level = 5;
            if (generator.NextDouble() > 0.7) 
            {
            gender = "female";
            }
            else
            {
            gender = "male";
            }
            InitStats();
        }
    }
}
