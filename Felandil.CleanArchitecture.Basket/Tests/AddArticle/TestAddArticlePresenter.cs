// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestAddArticlePresenter.cs" company="Felandil IT">
//   Copyright (c) 2014 - 2016 Felandil IT. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.CleanArchitecture.Basket.Tests.AddArticle
{
  using System;

  using Felandil.CleanArchitecture.Basket.Usecase.AddArticle;

  /// <summary>
  /// The test add article presenter.
  /// </summary>
  internal class TestAddArticlePresenter : UsecasePresenter<AddArticleResponse, IViewModel>
  {
    #region Public Methods and Operators

    /// <summary>
    /// The get response.
    /// </summary>
    /// <returns>
    /// The <see cref="AddArticleResponse"/>.
    /// </returns>
    public AddArticleResponse GetResponse()
    {
      return this.Response;
    }

    /// <summary>
    /// The present.
    /// </summary>
    /// <returns>
    /// The <see cref="IViewModel"/>.
    /// </returns>
    public override IViewModel Present()
    {
      throw new NotImplementedException();
    }

    #endregion
  }
}