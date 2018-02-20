using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzConsoleApp.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void fBTest()
        {
            Assert.AreEqual("Fizz ", Program.fB(3));
        }
        [TestMethod()]
        public void fBTest1()
        {
            Assert.AreEqual("Buzz", Program.fB(5));
        }
        [TestMethod()]
        public void fBTest2()
        {
            Assert.AreEqual("Fizz Buzz", Program.fB(15));
        }
        [TestMethod()]
        public void fBTest3()
        {
            Assert.AreEqual("Buzz", Program.fB(20));
        }
    }
}