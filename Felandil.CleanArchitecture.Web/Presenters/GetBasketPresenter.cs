// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetBasketPresenter.cs" company="Felandil IT">
//   Copyright (c) 2014 - 2016 Felandil IT. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.CleanArchitecture.Web.Presenters
{
  using Felandil.CleanArchitecture.Basket.Usecase.GetBasket;
  using Felandil.CleanArchitecture.Web.Models;

  /// <summary>
  /// The get basket presenter.
  /// </summary>
  public class GetBasketPresenter : UsecasePresenter<GetBasketResponse, BasketModel>
  {
    #region Public Methods and Operators

    /// <summary>
    /// The present.
    /// </summary>
    /// <returns>
    /// The <see cref="BasketModel"/>.
    /// </returns>
    public override BasketModel Present()
    {
      return new BasketModel
               {
                 ArticleCount = this.Response.ArticleCount,
                 BasketValue = this.Response.BasketValue.ToString("C0"),
                 Email = this.Response.Email
               };
    }

    #endregion
  }
}