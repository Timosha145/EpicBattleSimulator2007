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


            string rHero = GetRandomCharacter(heroes);
            string rVilliains = GetRandomCharacter(villains);
            string heroWeapon = GetRandomWeapon();
            string villiainWeapon = GetRandomWeapon();
            Console.WriteLine($"Your random hero is {rHero} and weapon is {heroWeapon}");
            Console.WriteLine($"Your random villiain is {rVilliains} and weapon is {villiainWeapon}");
        }
        public static string GetRandomCharacter(string[] someArray)
        {
            return someArray[GetRandomIndexForArray(someArray)];
        }
        public static string GetRandomWeapon()
        {
            string rootPath = @"C:\Users\opilane\Samples\heroesAndVilliains\";
            string[] weapon = GetDataFromFile(rootPath + "weapon.txt");
            return weapon[GetRandomIndexForArray(weapon)];
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
    }
}
