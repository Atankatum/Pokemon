using System;
using System.Collections.Generic;


namespace Pokemon
{
    public class Pokemon
    {
        public Random generator = new Random();
        protected string name;
        protected int hp;
        protected int attack;
        protected int defense;
        protected int speed;
    
        protected int experience;
        protected int level;
        protected int experienceForLevelUp;
        protected string gender;
        protected float levelCap = 35;

        protected int damageTaken;
        protected string rename;
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
