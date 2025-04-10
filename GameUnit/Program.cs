using System;

namespace GameUnit
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Testing Game Units");

            MilitaryUnit soldier = new MilitaryUnit(2, 10, 5);
            Console.WriteLine("=== Military Unit ===");
            soldier.Move();
            Console.WriteLine($"Health: {soldier.Health}");
            Console.WriteLine($"Cost: {soldier.Cost}");

            SettlerUnit settler = new SettlerUnit();
            Console.WriteLine("\n=== Settler Unit ===");
            settler.Move();
            Console.WriteLine($"Health: {settler.Health}");
            Console.WriteLine($"Cost: {settler.Cost}");

            Console.WriteLine("\n=== Testing Attack ===");
            Console.WriteLine($"Settler health before attack: {settler.Health}");
            soldier.Attack(settler);
            Console.WriteLine($"Settler health after attack: {settler.Health}");
            Console.WriteLine($"Soldier XP after attack: {soldier.XP}");
            Console.WriteLine($"Soldier health with XP bonus: {soldier.Health}");
            Console.WriteLine($"Soldier cost with XP bonus: {soldier.Cost}");
        }
    }
}