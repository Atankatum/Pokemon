using System;

namespace Pokemon
{
    public class Pokemon
    {
        private int damageTaken;
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
        float levelCap = 35;

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
    }
}
