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
            int expectedValue0 = 0;
            int actualValue0 = myList[0];
            //Act
            myList.Add(expectedValue0);
            //Assert
            Assert.AreEqual(expectedValue0, actualValue0);
        }

        /*public void AddMultipleIntegersTolist_Add_TestIndex9()
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
            int actualValue0 = myList[0];
            int actualValue1 = myList[1];
            int actualValue2 = myList[2];
            int actualValue3 = myList[3];
            int actualValue4 = myList[4];
            int actualValue5 = myList[5];
            int actualValue6 = myList[6];
            int actualValue7 = myList[7];
            int actualValue8 = myList[8];
            int actualValue9 = myList[9];
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
            Assert.AreEqual(expectedValue9, actualValue9);
        }
        public void AddMultipleIntegersTolist_Add_TestIndexCount()
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
            int actualValue0 = myList[0];
            int actualValue1 = myList[1];
            int actualValue2 = myList[2];
            int actualValue3 = myList[3];
            int actualValue4 = myList[4];
            int actualValue5 = myList[5];
            int actualValue6 = myList[6];
            int actualValue7 = myList[7];
            int actualValue8 = myList[8];
            int actualValue9 = myList[9];
            int expectedIndexCount = 10;
            int actualIndexCount = myList.Count;
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
            Assert.AreEqual(expectedIndexCount, actualIndexCount);
        }
        public void AddMultipleStringsTolist_Add_TestStringAtIndex9()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            string expectedValue0 = "a";
            string expectedValue1 = "b";
            string expectedValue2 = "c";
            string expectedValue3 = "d";
            string expectedValue4 = "e";
            string expectedValue5 = "f";
            string expectedValue6 = "g";
            string expectedValue7 = "h";
            string expectedValue8 = "i";
            string expectedValue9 = "j";
            string actualValue0 = myList[0];
            string actualValue1 = myList[1];
            string actualValue2 = myList[2];
            string actualValue3 = myList[3];
            string actualValue4 = myList[4];
            string actualValue5 = myList[5];
            string actualValue6 = myList[6];
            string actualValue7 = myList[7];
            string actualValue8 = myList[8];
            string actualValue9 = myList[9];
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
            Assert.AreEqual(expectedValue9, actualValue9);
        }
        */
    }
}
