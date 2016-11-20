// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BasketTest.cs" company="Felandil IT">
//   Copyright (c) 2014 - 2016 Felandil IT. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.CleanArchitecture.Basket.Tests
{
  using System.Collections.Generic;

  using Felandil.CleanArchitecture.Basket.Entity;

  using Microsoft.VisualStudio.TestTools.UnitTesting;

  /// <summary>
  /// The basket test.
  /// </summary>
  [TestClass]
  public class BasketTest
  {
    #region Public Methods and Operators

    /// <summary>
    /// The test basket value is calculated.
    /// </summary>
    [TestMethod]
    public void TestBasketValueIsCalculated()
    {
      var articleOne = new Article { Price = 19.99M, Quantity = 2 };
      var articleTwo = new Article { Price = 69.99M, Quantity = 1 };

      var basket = new Basket(string.Empty) { Articles = new List<Article> { articleOne, articleTwo } };

      Assert.AreEqual(109.97M, basket.Value);
    }

    #endregion
  }
}