using System;

namespace Pokemon
{
    public class Piplup : Pokemon
    {
        public Piplup()
        {
            name = "Piplup";
            hp = generator.Next(23, 32);
            attack = generator.Next(5, 7);
            defense = generator.Next(2, 3);
            speed = generator.Next(5, 8);
            experience = 0;
            level = 5;
            if (generator.NextDouble() > 0.4) 
            {
                 gender = "female";
            }
            else
            {
                gender = "male";
            } 
        }
    }
}
