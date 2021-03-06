using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModTestProd;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]      
        public void TestMethod1()//Add 800
        {
            Bank str = new Bank();
            MoneyPrinter str2 = new MoneyPrinter();
            Walet tddwallet = new Walet(str, str2);
            tddwallet.addMoney("RUB", 800);
            string lol = "RUB";
            Assert.AreEqual(tddwallet.getMoney(lol), 800);

        }
        [TestMethod]
        public void TestMethod2()//Add 400 then Add 1000 EQUAL 1400
        {
            Bank str = new Bank();
            MoneyPrinter str2 = new MoneyPrinter();
            Walet tddwallet = new Walet(str, str2);
            tddwallet.addMoney("RUB", 400);
            tddwallet.addMoney("RUB", 1000);
            Assert.AreEqual(tddwallet.getMoney("RUB"), 1400);

        }

        [TestMethod]
        public void TestMethod3()//Add Two Course
        {
            Bank str = new Bank();
            MoneyPrinter str2 = new MoneyPrinter();
            Walet tddwallet = new Walet(str, str2);
            tddwallet.addMoney("RUB", 400);
            tddwallet.addMoney("EUR", 1000);
            Assert.AreEqual(tddwallet.getCount(), 2);

        }

        [TestMethod]
        public void TestMethod4()//Add then watch 1the list
        {
            Bank str = new Bank();
            MoneyPrinter str2 = new MoneyPrinter();
            Walet tddwallet = new Walet(str, str2);
            tddwallet.addMoney("RUB", 400);
            tddwallet.addMoney("EUR", 1000);
            Assert.AreEqual(tddwallet.toString(), "400 RUB,1000 EUR");
        }

        [TestMethod]
        public void TestMethod5()//Test method Converter 
        {
            Bank str = new Bank();
            MoneyPrinter str2 = new MoneyPrinter();
            Walet tddwallet = new Walet(str, str2);
            tddwallet.addMoney("USD", 100);
            tddwallet.addMoney("EUR", 100);
            int total = str.convert(100, "USD", "RUB");
            Assert.AreEqual(total, 6000);
        }
    }    
}
