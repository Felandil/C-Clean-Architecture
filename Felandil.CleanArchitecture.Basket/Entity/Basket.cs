// --------------------------------------------------------------------------------------------------------------------
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.CleanArchitecture.Basket.Entity
{
  using System.Collections.Generic;

  /// <summary>
  /// The basket.
  /// </summary>
  public class Basket
  {
    #region Constructors and Destructors

    /// <summary>
    /// Initializes a new instance of the <see cref="Basket"/> class.
    /// </summary>
    /// <param name="email">
    /// The email.
    /// </param>
    public Basket(string email)
    {
      this.Articles = new List<Article>();
      this.Email = email;
    }

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets or sets the articles.
    /// </summary>
    public List<Article> Articles { get; set; }

    /// <summary>
    /// Gets or sets the email.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Gets the value.
    /// </summary>
    public decimal Value
    {
      get
      {
        var value = 0.0M;

        foreach (var article in this.Articles)
        {
          value += article.Price * article.Quantity;
        }

        return value;
      }
    }

    #endregion
  }
}