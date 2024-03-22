using Swin_Adventure;
using NUnit.Framework;
namespace Test_Swin_Adventure
{
    public class Tests 
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test_AreYou()
        {
            Identifiable_Object myid = new Identifiable_Object(new string[] { "fred", "bob" });

            Assert.IsTrue(myid.AreYou("fred"));
            Assert.IsTrue(myid.AreYou("bob"));
        }

        public void Test_Not_AreYou()
        {
            Identifiable_Object myid = new Identifiable_Object(new string[] { "fred", "bob" });

            Assert.IsFalse(myid.AreYou("boby"));
            Assert.IsFalse(myid.AreYou("wilma"));
        }

        public void Test_Case_Sensitive()
        {
            Identifiable_Object myid = new Identifiable_Object(new string[] { "fred", "bob" });

            Assert.IsTrue(myid.AreYou("FRED"));
            Assert.IsTrue(myid.AreYou("bOB"));
        }

        public void Test_FirstID()
        {
            Identifiable_Object myid = new Identifiable_Object(new string[] { "fred", "bob" });

            Assert.IsTrue((myid.FirstId) == "fred");
            
        }

        public void Test_FirstId_withoutIds()
        {
            Identifiable_Object myid = new Identifiable_Object(new string[] { });
            Assert.IsTrue((myid.FirstId) == "");
        }

        public void Test_AddID()
        {
            Identifiable_Object myid = new Identifiable_Object(new string[] { "fred", "bob" });

            myid.AddIdentifier("wilma");

            Assert.IsTrue(myid.AreYou("wilma"));
        }
        
    }
}