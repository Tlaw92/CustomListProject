﻿using System;
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
    }
}
 