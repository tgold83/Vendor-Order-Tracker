using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "testing", 15, 11-03-21);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string title = "Bread";
      string description = "20 loaves";
      int price = 30;
      int date = 11-03-22;

      //Act
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string title = "Bread";
      string description = "20 loaves";
      int price = 30;
      int date = 11-03-22;

      //Act
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      //Arrange
      string title = "Bread";
      string description = "20 loaves";
      int price = 30;
      int date = 11-03-22;

      //Act
      Order newOrder = new Order(title, description, price, date);
      int result = newOrder.Price;

      //Assert
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_Int()
    {
      //Arrange
      string title = "Bread";
      string description = "20 loaves";
      int price = 30;
      int date = 11-03-22;

      //Act
      Order newOrder = new Order(title, description, price, date);
      int result = newOrder.Date;

      //Assert
      Assert.AreEqual(date, result);
    }
  }
}