using NUnit.Framework;
using Codurance_Pair_Session.Library;

namespace Codurance_Pair_Session.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Class1 myClass = new Class1();
            Assert.AreEqual(true, myClass.ReturnTrue());
        }
    }
}