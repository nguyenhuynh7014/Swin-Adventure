using System;
namespace Swin_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory bag = new Inventory();
            Item sword = new Item(new string[] { "sword" }, "a sword", "It is a strong weapon.");

            bag.Put(sword);

            Console.WriteLine(bag.ItemList);
        }
    }
}