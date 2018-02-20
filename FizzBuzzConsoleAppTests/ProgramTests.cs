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
            Assert.AreEqual("Fizz", Program.fB(3));
        }
        [TestMethod()]
        public void fBTest1()
        {
            Assert.AreEqual("Buzz", Program.fB(5));
        }
    }
}