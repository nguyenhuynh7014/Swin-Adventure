using Swin_Adventure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Swin_Adventure
{
    internal class Test_Inventory
    {
        [SetUp]

        [Test]
        public void Test_Find_Item()
        {
            Inventory bag = new Inventory();

            Item sword = new Item(new string[] { "sword" }, "a sword", "It is a strong weapon.");
            bag.Put(sword);

            Assert.IsTrue(bag.HasItem("sword"));
        }

        [Test]
        public void Test_No_Item_Find()
        {
            Inventory bag = new Inventory();

            Item sword = new Item(new string[] { "sword" }, "a sword", "It is a strong weapon.");

            bag.Put(sword);

            Assert.IsFalse(bag.HasItem("a flower"));
        }

        [Test]
        public void Test_Fetch()
        {
            Inventory bag = new Inventory();
            

            Item sword = new Item(new string[] {"sword"},"a sword", "It is a strong weapon.");
            
            bag.Put(sword);

            Assert.AreEqual(sword,bag.Fetch("sword"));
            Assert.IsTrue(bag.HasItem("sword"));
        }

        [Test]
        public void Test_Take()
        {
            Inventory bag = new Inventory();

            Item sword = new Item(new string[] { "sword","shovel" }, "a sword", "It is a strong weapon.");
            bag.Put(sword);
           

            
            Assert.AreEqual(sword, bag.Take("sword"));
            Assert.IsFalse(bag.HasItem("sword"));
        }

        [Test]
        public void Test_ItemList()
        {
            Inventory bag = new Inventory();
            Item sword = new Item(new string[] { "sword" }, "a sword", "It is a strong weapon.");
            bag.Put(sword);
            string result = bag.ItemList;
            Assert.AreEqual("a sword(sword)", result);
        }
    }
}
