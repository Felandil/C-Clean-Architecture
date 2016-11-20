// --------------------------------------------------------------------------------------------------------------------
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.CleanArchitecture.Basket.Usecase.GetBasket
{
  /// <summary>
  /// The get basket request.
  /// </summary>
  public class GetBasketRequest : IRequestBoundry
  {
    #region Public Properties

    /// <summary>
    /// Gets or sets the email.
    /// </summary>
    public string Email { get; set; }

    #endregion
  }
}