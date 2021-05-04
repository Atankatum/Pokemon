using System;

namespace Pokemon
{
    public class Pokemon
    {
        public Random generator = new Random();
        public string name;
        public int hp;
        public int attack;
        public int defense;
        public int speed;
        public int experience;
        public int level;
        private int experienceForLevelUp;
        public string gender;
    public void Hurt(int amount)
    {
        hp -= amount;
    }

    public void Attack(Pokemon enemy)
    {
        if (attack > enemy.defense)
        {
            enemy.hp -= attack - enemy.defense;
        }
    }
    public void GainExperience()
    {
    experience += generator.Next(60, 70);
    }
    public void LevelUp()
    {
    if (experience >= 35)
    {
        level++;
        
    }
    }
    }
}
