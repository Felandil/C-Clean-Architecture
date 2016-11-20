// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CacheBasketRepository.cs" company="Felandil IT">
//   Copyright (c) 2014 - 2016 Felandil IT. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.CleanArchitecture.BasketRepository
{
  using System;
  using System.Diagnostics.CodeAnalysis;
  using System.Runtime.Caching;

  using Felandil.CleanArchitecture.Basket.Entity;
  using Felandil.CleanArchitecture.Basket.Repository;

  /// <summary>
  /// The cache basket repository.
  /// </summary>
  [ExcludeFromCodeCoverage]
  public class CacheBasketRepository : IBasketRepository
  {
    #region Properties

    /// <summary>
    /// Gets the cache.
    /// </summary>
    private static ObjectCache Cache
    {
      get
      {
        return MemoryCache.Default;
      }
    }

    #endregion

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
    public Basket GetBasket(string email)
    {
      return (Basket)Cache.Get(email);
    }

    /// <summary>
    /// The save basket.
    /// </summary>
    /// <param name="basket">
    /// The basket.
    /// </param>
    public void SaveBasket(Basket basket)
    {
      var policy = new CacheItemPolicy { AbsoluteExpiration = DateTime.Now + TimeSpan.FromMinutes(120) };
      Cache.Add(new CacheItem(basket.Email, basket), policy);
    }

    #endregion
  }
}