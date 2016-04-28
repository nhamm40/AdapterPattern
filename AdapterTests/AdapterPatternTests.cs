using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdapterPattern.Interfaces;
using AdapterPattern.Adapters;
using AdapterPattern;

namespace AdapterTests
{
    [TestClass]
    public class AdapterPatternTests
    {
        [TestMethod]
        public void TestMallard()
        {
            Duck mallard = new MallardDuck();
            Assert.AreEqual("Quack", mallard.quack());
            Assert.AreEqual("I'm flying!", mallard.fly());
        }

        [TestMethod]
        public void TestWildTurkey()
        {
            Turkey wildTurkey = new WildTurkey();
            Assert.AreEqual("Gobble, gobble", wildTurkey.Gobble());
            Assert.AreEqual("I'm flying a short distance!", wildTurkey.Fly());
        }

        [TestMethod]
        public void TestDuckAdapter()
        {
            Duck mallard = new MallardDuck();
            Turkey duckadapter = new DuckAdapter(mallard);

            Assert.AreEqual("Quack", duckadapter.Gobble());
            Assert.AreEqual("I'm flying!", duckadapter.Fly());
        }

        [TestMethod]
        public void TestTurkeyAdapter()
        {
            Turkey wildTurkey = new WildTurkey();
            Duck turkeyAdapter = new TurkeyAdapter(wildTurkey);

            Assert.AreEqual("Gobble, gobble", turkeyAdapter.quack());
            Assert.AreEqual("I'm flying a short distance!\n" + "I'm flying a short distance!\n" + 
                            "I'm flying a short distance!\n" + "I'm flying a short distance!\n" + 
                            "I'm flying a short distance!\n", turkeyAdapter.fly());
        }
    }
}
