namespace Felandil.CleanArchitecture.Basket.Tests.GetBasket
{
  using System;

  using Felandil.CleanArchitecture.Basket.Usecase.GetBasket;

  /// <summary>
  /// The test get basket presenter.
  /// </summary>
  internal class TestGetBasketPresenter : UsecasePresenter<GetBasketResponse, IViewModel>
  {
    #region Public Methods and Operators

    /// <summary>
    /// The get basket response.
    /// </summary>
    /// <returns>
    /// The <see cref="GetBasketResponse"/>.
    /// </returns>
    public GetBasketResponse GetBasketResponse()
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