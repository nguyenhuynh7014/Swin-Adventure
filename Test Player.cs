using Swin_Adventure;
using System;

namespace Test_Swin_Adventure
{
    internal class Test_Player
    {
        [SetUp]
        
        [Test]
        public void Test_Player_is_Indentifiable() {
            Player player = new Player("kai", "This is an avatar.");

            Assert.IsTrue(player.AreYou("kai"));
            

        }

        [Test]
        public void Player_Locate_Item()
        {
            Player player = new Player("kai", "This is an avatar.");

            Item sword = new Item(new string[] { "sword" }, "a sword", "This is a strong sword.");
            Inventory bag = new Inventory();
            bag.Put(sword);

            Assert.IsNotNull(player.Locate("sword"));
        }


    }
}
