using System;

namespace Pokemon
{
    public class Turtwig : Pokemon
    {
        public Turtwig()
        {
            name = "Turtwig";
            hp = generator.Next(25, 34);
            attack = generator.Next(6, 9);
            defense = generator.Next(3, 5);
            speed = generator.Next(4, 8);
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
        }
    }
}
