// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetBasketInteractorTest.cs" company="Felandil IT">
//   Copyright (c) 2014 - 2016 Felandil IT. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.CleanArchitecture.Basket.Tests.GetBasket
{
  using System.Collections.Generic;

  using Felandil.CleanArchitecture.Basket.Entity;
  using Felandil.CleanArchitecture.Basket.Usecase.GetBasket;

  using Microsoft.VisualStudio.TestTools.UnitTesting;

  /// <summary>
  /// The get basket interactor test.
  /// </summary>
  [TestClass]
  public class GetBasketInteractorTest
  {
    #region Public Methods and Operators

    /// <summary>
    /// The test articles are in basket should return valid data.
    /// </summary>
    [TestMethod]
    public void TestArticlesAreInBasketShouldReturnValidData()
    {
      var articleOne = new Article { Price = 19.99M, Quantity = 2 };
      var articleTwo = new Article { Price = 69.99M, Quantity = 1 };

      var interactor = new GetBasketInteractor<IViewModel>(
        new TestGetBasketPresenter(),
        new InMemoryBasketRepository(new Basket("a@b.de") { Articles = new List<Article> { articleOne, articleTwo } }));
      interactor.Execute(new GetBasketRequest { Email = "a@b.de" });

      var response = ((TestGetBasketPresenter)interactor.Presenter).GetBasketResponse();

      Assert.AreEqual(2, response.ArticleCount);
      Assert.AreEqual(109.97M, response.BasketValue);
      Assert.AreEqual("a@b.de", response.Email);
    }

    /// <summary>
    /// The test no articles are in basket should have article count of zero.
    /// </summary>
    [TestMethod]
    public void TestNoArticlesAreInBasketShouldHaveArticleCountOfZero()
    {
      var interactor = new GetBasketInteractor<IViewModel>(new TestGetBasketPresenter(), new InMemoryBasketRepository());
      interactor.Execute(new GetBasketRequest { Email = "a@b.de" });

      var response = ((TestGetBasketPresenter)interactor.Presenter).GetBasketResponse();

      Assert.AreEqual(0, response.ArticleCount);
      Assert.AreEqual(0M, response.BasketValue);
    }

    #endregion
  }
}