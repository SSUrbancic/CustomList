using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

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
        [TestMethod]
        public void CountElementsInList_Length_TestLength()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expectedValue0 = 0;
            int expectedValue1 = 1;
            //Act
            myList.Add(expectedValue0);
            myList.Add(expectedValue1);
            int expectedLength = 2;
            int actualLength = myList.Length();
            //Assert
            Assert.AreEqual(expectedLength, actualLength);
        }
        [TestMethod]
        public void TestLengthMethodAfterIncreasedCapacity_Length_TestLength()
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
            int expectedLength = 10;
            int actualLength = myList.Length();
            //Assert
            Assert.AreEqual(expectedLength, actualLength);
        }
        [TestMethod]
        public void RemoveInteger_Remove_TestIndex1()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expectedValue0 = 16;
            int expectedValue1 = 17;
            //Act
            myList.Add(expectedValue0);
            myList.Add(expectedValue1);
            myList.Remove(17);
            int actualValue1 = myList[1];
            //Assert
            Assert.AreEqual(0, actualValue1);
        }
        [TestMethod]
        public void RemoveMiddleInteger_Remove_TestIndex1()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expectedValue0 = 20;
            int expectedValue1 = 11;
            int expectedValue2 = 22;
            //Act
            myList.Add(expectedValue0);
            myList.Add(expectedValue1);
            myList.Add(expectedValue2);
            myList.Remove(11);
            int actualValue1 = myList[1];
            //Assert
            Assert.AreEqual(expectedValue2, actualValue1);
        }
        [TestMethod]
        public void RemoveOnlyFirstOccurenceOfValue_Remove_TestIndex1()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expectedValue0 = 0;
            int expectedValue1 = 1;
            int expectedValue2 = 1;
            int expectedValue3 = 2;
            //Act
            myList.Add(expectedValue0);
            myList.Add(expectedValue1);
            myList.Add(expectedValue2);
            myList.Add(expectedValue3);
            myList.Remove(1);
            int actualValue1 = myList[1];
            //Assert
            Assert.AreEqual(expectedValue2, actualValue1);
        }
        [TestMethod]
        public void AddTwoLists_CustomList_ThirdList()
        {
            //Arrange
            CustomList<int> firstList = new CustomList<int>();
            CustomList<int> secondList = new CustomList<int>();
            //Act
            firstList.Add(1);
            firstList.Add(2);
            secondList.Add(3);
            secondList.Add(4);
            CustomList<int> thirdList = firstList + secondList;
            //Assert
            Assert.AreEqual(4, thirdList[3]);
        }
        [TestMethod]
        public void AddTwoListsTestLength_CustomList_ThirdList()
        {
            //Arrange
            CustomList<int> firstList = new CustomList<int>();
            CustomList<int> secondList = new CustomList<int>();
            int value = 9;
            int expectedLength = 20;
            
            //Act
            firstList.Add(value);
            firstList.Add(value);
            firstList.Add(value);
            firstList.Add(value);
            firstList.Add(value);
            firstList.Add(value);
            firstList.Add(value);
            firstList.Add(value);
            firstList.Add(value);
            firstList.Add(value);
            secondList.Add(value);
            secondList.Add(value);
            secondList.Add(value);
            secondList.Add(value);
            secondList.Add(value);
            secondList.Add(value);
            secondList.Add(value);
            secondList.Add(value);
            secondList.Add(value);
            secondList.Add(value);
            CustomList<int> thirdList = firstList + secondList;
            int actualLength = thirdList.Length();
            //Assert
            Assert.AreEqual(expectedLength, actualLength);
        }
        public void IterateThroughList_CustomList_myList()
        {

        }
    }
}
