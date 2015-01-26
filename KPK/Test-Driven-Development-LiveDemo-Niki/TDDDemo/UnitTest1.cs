namespace TDDDemo
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    ////MOCK object for ILogger
    //public class TestLogger : ILogger
    //{
    //    public bool Logged { get; set; }

    //    public void Log(string message)
    //    {
    //        Logged = true;
    //    }
    //}

    //SubscriptonSystem
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SubscribeWorks()
        {
            var loggerMock = new Mock<ILogger>();
            bool isLogged = false;
            loggerMock.Setup(x => x.Log(It.IsAny<string>())).Callback(() => { isLogged = true; });
            
            //var system = new SubscriptonSystem(new TestLogger());
            var system = new SubscriptonSystem(loggerMock.Object);
            system.Subscribe(new User { Username = "Niki"});
            Assert.AreEqual(1, system.Users.Count);
        }

        [TestMethod]
        public void UsersShouldBeCharged()
        {
            var loggerMock = new Mock<ILogger>();
            //var system = new SubscriptonSystem(new TestLogger());
            var system = new SubscriptonSystem(loggerMock.Object);
            var user1 = new User();
            var user2 = new User();
            system.Users.Add(user1);
            system.Users.Add(user2);
            system.Charge(500);
            Assert.AreEqual(500, user1.Balance);
            Assert.AreEqual(500, user2.Balance);
        }


        [TestMethod]
        public void UsersShouldBeCharged2()
        {
            var loggerMock = new Mock<ILogger>();
            //var system = new SubscriptonSystem(new TestLogger());
            var system = new SubscriptonSystem(loggerMock.Object);
            var user1 = new User { Balance = 500 };
            //var user2 = new User();
            system.Users.Add(user1);
            //system.Users.Add(user2);
            system.Charge(500);
            Assert.AreEqual(1000, user1.Balance);
            //Assert.AreEqual(500, user2.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SystemChargeShouldNotAcceptNegativeValues()
        {
            var loggerMock = new Mock<ILogger>();
            //var system = new SubscriptonSystem(new TestLogger());
            var system = new SubscriptonSystem(loggerMock.Object);
            system.Charge(-500);
        }


        [TestMethod]
        public void SystemChargeShoudLog() 
        {
            var loggerMock = new Mock<ILogger>();
            bool isLogged = false;
            loggerMock.Setup(x => x.Log(It.IsAny<string>())).Callback(() => { isLogged = true; });
            //var logger = new TestLogger();
            var logger = loggerMock.Object;
            //logger.Logged = false;
            //var system = new SubscriptonSystem(logger);
            var system = new SubscriptonSystem(loggerMock.Object);
            system.Charge(100);
            //Assert.IsTrue(logger.Logged);
            Assert.IsTrue(isLogged);

        }
    }
}
