namespace BunnyMadness.Tests.BunnyTests
{
    using System;

    using BunnyMadness;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BunnyTests
    {
        private Bunny firstBunny;
        private Bunny secondBunny;

        [TestInitialize]
        public void InitializeBunnies()
        {
            firstBunny = new Bunny();
            secondBunny = new Bunny();
        }

        [TestMethod]
        public void BunnyShouldBeAliveWhenInstantiated()
        {
            //Bunny bunny = new Bunny();
            var bunny = new Bunny();
            Assert.IsTrue(bunny.IsAlive/*, "Bunny should be alive when created"*/);
        }

        [TestMethod]
        public void BunnyShouldTakeCorrectDamageWhenAttacked()
        { 
            var attacker = new Bunny();
            var defender = new Bunny();

            attacker.Attack(defender, 20);
            var expectedHealth = 80;

            Assert.AreEqual(expectedHealth, defender.Health);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BunnyShouldNotHaveMoreThan100Health()
        {
            var attacker = new Bunny();
            var defender = new Bunny();

            attacker.Attack(defender, -20);

            //Assert.AreEqual(100, defender.Health);
        }
    }
}
