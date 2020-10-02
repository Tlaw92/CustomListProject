using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomLists;
using System.Collections.Generic;

// I want to use Test Driven Development (TDD), so that I can
// write tests for my methods to pass to ensure proper functionality in my application.
// There needs to be several tests per method.

namespace UnitTestCustomList
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_ThreePositiveValues_CountThree()
        {
            //arrange
            MyList<int> myList = new MyList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int expected = 3;
            int actual;
            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            actual = myList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_OneValue_CountOne()
        {
            //Arrange
            MyList<int> myList = new MyList<int>();
            int value1 = 1;
            int expected = 1;
            int actual;
            //Act
            myList.Add(value1);
            actual = myList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_ThreePositive_ZeroIndexOne()
        {
            //Arrange
            MyList<int> myList = new MyList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int expected = 1;
            int actual;
            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            actual = myList[0];
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Add_5Things_Count5()
        {
            //Arrange

            MyList<int> myList = new MyList<int>();
            int flamingo1 = 1;
            int flamingo2 = 2;
            int flamingo3 = 3;
            int flamingo4 = 4;
            int flamingo5 = 5;
            int expected = 5;
            int actual;
            //Act
            myList.Add(flamingo1);
            myList.Add(flamingo2);
            myList.Add(flamingo3);
            myList.Add(flamingo4);
            myList.Add(flamingo5);
            actual = myList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_7Things_checkZeroIndex()
        {
            //Arrange
            MyList<int> myList = new MyList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int value7 = 7;
            int expected = 7;
            int actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList.Add(value6);
            myList.Add(value7);

            actual = myList[6];
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Capacity_ToArrayIndex()
        {
            //Arrange
            MyList<int> thing = new MyList<int>();
            int value1 = 167;
            int value2 = 234;
            int value3 = 365;
            int value4 = 425;
            int value5 = 524;
            int value6 = 626;
            int value7 = 777;
            int value8 = 824;
            int value9 = 987;
            int expected = 16;
            int actual;
            //Act
            thing.Add(value1);
            thing.Add(value2);
            thing.Add(value3);
            thing.Add(value4);
            thing.Add(value5);
            thing.Add(value6);
            thing.Add(value7);
            thing.Add(value8);
            thing.Add(value9);

            actual = thing.capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Remove_AllItems()
        {
            MyList<int> thing = new MyList<int>();
            int value1 = 167;
            int value2 = 234;
            int value3 = 365;
            int expected = 0;
            int actual;
            //Act
            thing.Add(value1);
            thing.Add(value2);
            thing.Add(value3);
            thing.Remove(value1);
            thing.Remove(value2);
            thing.Remove(value3);
            actual = thing.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_NonExistant_CountOf()
        {
            MyList<int> thing = new MyList<int>();
            int value1 = 3;
            int value2 = 4;
            int value3 = 5;
            int value4 = 700;
            int expected = 3;
            int actual;
            //Act
            thing.Add(value1);
            thing.Add(value2);
            thing.Add(value3);
            thing.Remove(value4);

            actual = thing.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_First_InDuplicate()
        {
            MyList<int> thing = new MyList<int>();
            int value1 = 3;
            int value2 = 3;
            int value3 = 3;
            int expected = 2;
            int actual;
            //Act
            thing.Add(value1);
            thing.Add(value2);
            thing.Add(value3);
            thing.Remove(value1);
            actual = thing.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_LastItem()
        {
            MyList<int> thing = new MyList<int>();
            int value1 = 100;
            int value2 = 200;
            int value3 = 300;
            int expected = 2;
            int actual;
            //Act
            thing.Add(value1);
            thing.Add(value2);
            thing.Add(value3);
            thing.Remove(value3);
            actual = thing.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void Remove_FirstItem()
        {
            MyList<int> thing = new MyList<int>();
            int value1 = 100;
            int value2 = 200;
            int value3 = 300;
            int expected = 2;
            int actual;
            //Act
            thing.Add(value1);
            thing.Add(value2);
            thing.Add(value3);
            thing.Remove(value1);
            actual = thing.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void Remove_No_item()
        {
            MyList<int> thing = new MyList<int>();
            int value1 = 100;
            int value2 = 200;
            int value3 = 300;
            int value4 = 400;
            bool expected = false;
            bool actual;
            //Act
            thing.Add(value1);
            thing.Add(value2);
            thing.Add(value3);

            actual = thing.Remove(value4);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_All_item()
        {
            MyList<int> thing = new MyList<int>();
            int value1 = 100;
            bool expected = true;
            bool actual;

            //Act
            thing.Add(value1);

            actual = thing.Remove(value1);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void Convert_To_String()
        {
            //Arrange
            MyList<string> myList = new MyList<string>();
            string phrase1 = "Hello World";
            string phrase2 = "Goodbye World";           
            string expected = ;
            int actual;
            //Act
            myList.Add(value1);
            myList.Add(value2);
            actual = 
            //Assert
            //Assert.AreEqual(expected, actual);
        }
    }
}
 