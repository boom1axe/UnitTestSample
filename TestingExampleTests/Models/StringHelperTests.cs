using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingExample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingExample.Models.Tests
{
    [TestClass()]
    public class StringHelperTests
    {
        [TestMethod()]
        [DataRow("joe.txt")]
        [DataRow("text.TXT")]
        [DataRow("  test.TXT")]
        [DataRow("  test.txt")]
        [DataRow("test.txt   ")]
        [DataRow("  test.txt   ")]
        [DataRow("null.txt")]
        public void IsTextFile_ValidTextFile_ReturnsTrue(string fileName)
        {
            // Act
            bool result = StringHelper.IsTextFile(fileName);

            // Assert
            Assert.IsTrue(result);
        }


        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow(".text")]
        [DataRow("<>.txt")]
        public void IsTextFile_InValidFileName_ReturnsFalse(string fileName)
        {
            bool result = StringHelper.IsTextFile(fileName);

            Assert.IsFalse(result);
        }
    }

}