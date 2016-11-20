// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetBasketResponse.cs" company="Felandil IT">
//   Copyright (c) 2014 - 2016 Felandil IT. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.CleanArchitecture.Basket.Usecase.GetBasket
{
  /// <summary>
  /// The get basket response.
  /// </summary>
  public class GetBasketResponse : IResponseBoundry
  {
    #region Public Properties

    /// <summary>
    /// Gets or sets the article count.
    /// </summary>
    public int ArticleCount { get; set; }

    /// <summary>
    /// Gets or sets the basket value.
    /// </summary>
    public decimal BasketValue { get; set; }

    /// <summary>
    /// Gets or sets the email.
    /// </summary>
    public string Email { get; set; }

    #endregion
  }
}