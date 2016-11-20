// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IBasketRepository.cs" company="Felandil IT">
//   Copyright (c) 2014 - 2016 Felandil IT. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.CleanArchitecture.Basket.Repository
{
  using Felandil.CleanArchitecture.Basket.Entity;

  /// <summary>
  /// The BasketRepository interface.
  /// </summary>
  public interface IBasketRepository
  {
    #region Public Methods and Operators

    /// <summary>
    /// The get basket.
    /// </summary>
    /// <param name="email">
    /// The email.
    /// </param>
    /// <returns>
    /// The <see cref="Basket"/>.
    /// </returns>
    Basket GetBasket(string email);

    /// <summary>
    /// The save basket.
    /// </summary>
    /// <param name="basket">
    /// The basket.
    /// </param>
    void SaveBasket(Basket basket);

    #endregion
  }
}