using System;

namespace Pokemon
{
    public class Prinplup : Piplup
    {
        public Prinplup()
        {
            name = "Prinplup";
            hp = hp + generator.Next(35, 41);
            attack = attack + generator.Next(15, 18);
            defense = defense + generator.Next(13, 17);
            speed = speed + generator.Next(6, 9);
            InitStats();
        }
    }
}
