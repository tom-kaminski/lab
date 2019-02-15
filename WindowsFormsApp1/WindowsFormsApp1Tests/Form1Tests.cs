using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void BtnResponseTest()
        {
            //Arrange
            string expected = "Hello World1";
            string response = new WindowsFormsApp1.Form1().BtnResponse("foo");

            //Act
            //write act code here!

            //Assert
            Assert.AreEqual(expected,response);
        }
    }
}