using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class TestSplitMethod
    {
        [TestMethod]
        public void TestMethodSplit()
        {
            // arrange

            // act
            string[] testSplit = SplitString.stringSplitted("tests tests");
            string[] testArray = new string[] { "tests", "tests" };
            // assert
            CollectionAssert.AreEqual(testArray,testSplit);
        }
    }

    [TestClass]
    public class TestCountMethod
    {
        [TestMethod]
        public void TestMethodCount()
        {
            // arrange
            string[] testArray = new string[] { "one", "two", "three" };
            // act
            int counter = CountStrings.stringsCount(testArray);
            // assert
            Assert.AreEqual(counter,3);
        }
    }

    [TestClass]
    public class TestSplitMethodSecond
    {
        [TestMethod]
        public void TestMethodSplitSecond()
        {
            // arrange
            string[] testArray = new string[] { "one", "two", "three" };
            // act
            string[] testSplit = SplitString.stringSplitted("one two three");
            // assert
            Assert.IsTrue(testArray.SequenceEqual(testSplit));
        }
    }

    
}
