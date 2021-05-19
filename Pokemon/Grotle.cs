using System;

namespace Pokemon
{
    public class Grotle : Turtwig
    {
        public Grotle()
        {
            name = "Grotle";
            hp = hp + generator.Next(40, 46);
            attack = attack + generator.Next(13, 16);
            defense = defense + generator.Next(15, 21);
            speed = speed + generator.Next(3, 6);
            InitStats();
        }
    }
}
