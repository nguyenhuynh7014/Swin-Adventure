using NUnit.Framework.Internal.Execution;
using Swin_Adventure;
using System;

namespace Test_Swin_Adventure
{
    public class Test_Item
    {
        [SetUp]
        public void SetUp()
        { }

        [Test]
        public void Test_Item_is_Identifiable()
        {
            Item sword = new Item(new string[] { "sword" }, "a sword", "It is a strong weapon.");

            Assert.IsTrue(sword.AreYou("sword"));
        }

        public void Test_Item_is_Not_Identifiable()
        {
            Item sword = new Item(new string[] { "sword" }, "a sword", "It is a strong weapon.");

            Assert.IsFalse(sword.AreYou("flower"));
        }

        public void Test_Short_Description()
        {
            Item sword = new Item(new string[] { "sword" }, "a sword", "It is a strong weapon.");
            Assert.AreEqual("a strong sword(sword)", sword.ShortDescription);
        }

        public void Test_Full_Description()
        {
            Item sword = new Item(new string[] { "sword" }, "a sword", "It is a strong weapon.");
            Assert.AreEqual("It is a weapon.", sword.FullDescription);
        }
    }
}
