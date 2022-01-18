using System;
using System.IO;

namespace EpicBattleSimulator2007
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\opilane\Samples\heroesAndVilliains\";
            string[] heroes = GetDataFromFile(rootPath + "heroes.txt");
            string[] villains = GetDataFromFile(rootPath + "villains.txt");
            string[] armor = GetDataFromFile(rootPath + "armor.txt");
            string[] weapon = GetDataFromFile(rootPath + "weapon.txt");
            int hp;

            string rHero = GetRandomCharacter(heroes);
            string rVilliains = GetRandomCharacter(villains);
            string heroWeapon = GetRandomCharacter(weapon);
            string villiainWeapon = GetRandomCharacter(weapon);
            string heroArmor = GetRandomCharacter(armor);
            string villiainArmor = GetRandomCharacter(armor);
            int heroHp = heroArmor.Length;
            int villiainHp = villiainArmor.Length;

            Console.WriteLine($"Your random hero is {rHero} and weapon is {heroWeapon} and equiped with {heroArmor} which has {heroHp}Hp");
            Console.WriteLine($"Your random villiain is {rVilliains} and weapon is {villiainWeapon} and equiped with {villiainArmor} which has {villiainHp}Hp");

            while (heroHp>0 && villiainHp>0)
            {
                heroHp = heroHp - weaponForce(rVilliains, villiainWeapon);
                villiainHp = villiainHp - weaponForce(rHero, heroWeapon);
            }
            if(heroHp>villiainHp)
            { Console.WriteLine("Hero won"); }
            else if(heroHp<villiainHp)
            { Console.WriteLine("Villiain won"); }
            else
            { Console.WriteLine("Both died!"); }
        }
        public static string GetRandomCharacter(string[] someArray)
        {
            return someArray[GetRandomIndexForArray(someArray)];
        }
        public static int GetRandomIndexForArray(string[] someArray)
        {
            Random r = new Random();
            return r.Next(0, someArray.Length);
        }

        public static string[] GetDataFromFile(string filePath)
        {
            string[] dataFromFile = File.ReadAllLines(filePath);
            return dataFromFile;

        }

        public static int weaponForce(string character ,string weapon)
        {
            Random r = new Random();
            int hit = r.Next(0, weapon.Length -2);
            if (hit==0)
            {
                Console.WriteLine($"{character} missed the target");
            }
            else if (hit==weapon.Length-2)
            {
                Console.WriteLine($"{character} made critical hit");
            }
            else { Console.WriteLine($"{character} damaged target with {hit}Hp"); }
            return hit;
        }
    }
}
