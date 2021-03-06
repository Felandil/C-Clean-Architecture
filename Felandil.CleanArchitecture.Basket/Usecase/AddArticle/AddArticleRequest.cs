﻿// --------------------------------------------------------------------------------------------------------------------
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.CleanArchitecture.Basket.Usecase.AddArticle
{
  /// <summary>
  /// The add article request.
  /// </summary>
  public class AddArticleRequest : IRequestBoundry
  {
    #region Public Properties

    /// <summary>
    /// Gets or sets the email.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Gets or sets the price.
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Gets or sets the quantity.
    /// </summary>
    public int Quantity { get; set; }

    #endregion
  }
}