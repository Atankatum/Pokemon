using System;

namespace Pokemon
{
    public class Monferno : Chimchar
    {
        public Monferno()
        {
            name = "Monferno";
            hp = hp + generator.Next(30, 41);
            attack = attack + generator.Next(18, 21);
            defense = defense + generator.Next(5, 11);
            speed = speed + generator.Next(3, 10);
            InitStats();
        }
    }
}
