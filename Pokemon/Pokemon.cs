using System;
using System.Collections.Generic;


namespace Pokemon
{
    public abstract class Pokemon
    {
        public Random generator = new Random();
        protected string name, gender, rename;
        protected int hp, attack, defense, speed, experience, level, experienceForLevelUp, damageTaken;
        protected float levelCap = 35;
        Dictionary<string, int> stats = new Dictionary<string, int>();
         
        public void Attack(Pokemon enemy)
        {      
            damageTaken = attack -= defense;
            hp -= damageTaken;
        }

        public void GainExperience()
        {
            experience += generator.Next(30, 40);
        }

        public void LevelUp()
        {
            if (experience >= levelCap)
            {
                level++;
                levelCap *= 1.25f;
            }
        }

        public int GetHp()
        {
            return hp;    
        }

        public string GetName()
        {
            return name;
        }

        public void SetName()
        {
            name = rename;
        }

        public void GetStats()
        {
            System.Console.WriteLine(name);
            foreach(string stat in stats.Keys)
            {
                System.Console.WriteLine(stat + stats[stat]);
            }
            Console.ReadLine();
        }

        protected void InitStats()
        {
            stats.Add("HP:", hp);
            stats.Add("Attack:", attack);
            stats.Add("Defense:", defense);
            stats.Add("Speed:", speed);
            stats.Add("Level:", level);
        }
    }
}
