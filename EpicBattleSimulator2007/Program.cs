using System;

namespace EpicBattleSimulator2007
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] heroes = { "Boris", "Valera", "Genadij", "Gilbert" };
            string[] villains = { "BossOfThisGym", "Shumainzenba", "Bubershemrts", "Python", "Bubigga" };

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
            string[] weapon = { "Abobus Backpack", "Indian nokia", "Gucci Monkey", "Bread", "Glass of milk" };
            return weapon[GetRandomIndexForArray(weapon)];
        }
        public static int GetRandomIndexForArray(string[] someArray)
        {
            Random r = new Random();
            return r.Next(0, someArray.Length);
        }
    }
}