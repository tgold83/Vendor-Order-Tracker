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

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      //Arrange
      string title = "Bread";
      string description = "20 loaves";
      int price = 30;
      int date = 11-03-22;
      Order newOrder = new Order(title, description, price, date);

      //Act
      string updatedTitle = "French Bread";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string title = "Bread";
      string description = "20 loaves";
      int price = 30;
      int date = 11-03-22;
      Order newOrder = new Order(title, description, price, date);

      //Act
      string updatedDescription = "10 loaves";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void SetPrice_SetPrice_Int()
    {
      //Arrange
      string title = "Bread";
      string description = "20 loaves";
      int price = 30;
      int date = 11-03-22;
      Order newOrder = new Order(title, description, price, date);

      //Act
      int updatedPrice = 10;
      newOrder.Price = updatedPrice;
      int result = newOrder.Price;

      //Assert
      Assert.AreEqual(updatedPrice, result);
    }

    [TestMethod]
    public void SetDate_SetDate_Int()
    {
      //Arrange
      string title = "Bread";
      string description = "20 loaves";
      int price = 30;
      int date = 11-03-22;
      Order newOrder = new Order(title, description, price, date);

      //Act
      int updatedDate = 10-03-22;
      newOrder.Date = updatedDate;
      int result = newOrder.Date;

      //Assert
      Assert.AreEqual(updatedDate, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      //Arrange
      string title01 = "Bread";
      string description01 = "20 loaves";
      int price01 = 30;
      int date01 = 11-03-22;
      string title02 = "Pastry";
      string description02 = "croisants";
      int price02 = 15;
      int date02 = 11-03-22;
      Order newOrder1 = new Order(title01, description01, price01, date01);
      Order newOrder2 = new Order(title02, description02, price02, date02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}