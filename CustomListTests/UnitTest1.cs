using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddIntegerToList_Add_TestIndex0()
        {
            CustomList<int> myList = new CustomList<int>();
            //Arrange
            int expectedValue0 = 10;
            //Act
            myList.Add(expectedValue0);
            //Assert
            Assert.AreEqual(expectedValue0, myList[0]);
        }
        [TestMethod]
        public void AddIntegersToList_Add_TestIndex1()
        {
            CustomList<int> myList = new CustomList<int>();
            //Arrange
            int expectedValue0 = 0;
            int expectedValue1 = 1;
            //Act
            myList.Add(expectedValue0);
            myList.Add(expectedValue1);
            //Assert
            Assert.AreEqual(expectedValue1, myList[1]);
        }
        [TestMethod]
        public void AddIntegersPassedCapacity_Add_TestIndex9()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expectedValue0 = 0;
            int expectedValue1 = 1;
            int expectedValue2 = 2;
            int expectedValue3 = 3;
            int expectedValue4 = 4;
            int expectedValue5 = 5;
            int expectedValue6 = 6;
            int expectedValue7 = 7;
            int expectedValue8 = 8;
            int expectedValue9 = 9;
            //Act
            myList.Add(expectedValue0);
            myList.Add(expectedValue1);
            myList.Add(expectedValue2);
            myList.Add(expectedValue3);
            myList.Add(expectedValue4);
            myList.Add(expectedValue5);
            myList.Add(expectedValue6);
            myList.Add(expectedValue7);
            myList.Add(expectedValue8);
            myList.Add(expectedValue9);
            //Assert
            Assert.AreEqual(expectedValue9, myList[9]);
        }
    }
}
