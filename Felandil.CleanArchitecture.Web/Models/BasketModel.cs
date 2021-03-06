﻿// --------------------------------------------------------------------------------------------------------------------
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.CleanArchitecture.Web.Models
{
  /// <summary>
  /// The basket model.
  /// </summary>
  public class BasketModel : IViewModel
  {
    #region Public Properties

    /// <summary>
    /// Gets or sets the article count.
    /// </summary>
    public int ArticleCount { get; set; }

    /// <summary>
    /// Gets or sets the basket value.
    /// </summary>
    public string BasketValue { get; set; }

    /// <summary>
    /// Gets or sets the email.
    /// </summary>
    public string Email { get; set; }

    #endregion
  }
}