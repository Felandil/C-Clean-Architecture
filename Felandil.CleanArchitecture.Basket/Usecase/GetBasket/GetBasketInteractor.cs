﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetBasketInteractor.cs" company="Felandil IT">
//    Copyright (c) 2008 -2017 Felandil IT. All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.CleanArchitecture.Basket.Usecase.GetBasket
{
  using Felandil.CleanArchitecture.Basket.Entity;
  using Felandil.CleanArchitecture.Basket.Repository;

  /// <summary>
  /// The get basket interactor.
  /// </summary>
  /// <typeparam name="TViewModel">
  /// The View Model
  /// </typeparam>
  public class GetBasketInteractor<TViewModel> : UsecaseInteractor<GetBasketRequest, GetBasketResponse, TViewModel>
    where TViewModel : IViewModel
  {
    #region Constructors and Destructors

    /// <summary>
    /// Initializes a new instance of the <see cref="GetBasketInteractor{TViewModel}"/> class. 
    /// </summary>
    /// <param name="presenter">
    /// The presenter.
    /// </param>
    /// <param name="repository">
    /// The repository.
    /// </param>
    public GetBasketInteractor(UsecasePresenter<GetBasketResponse, TViewModel> presenter, IBasketRepository repository)
      : base(presenter)
    {
      this.Repository = repository;
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the repository.
    /// </summary>
    private IBasketRepository Repository { get; set; }

    #endregion

    #region Public Methods and Operators

    /// <summary>
    /// The action.
    /// </summary>
    /// <param name="request">
    /// The request.
    /// </param>
    /// <returns>
    /// The <see cref="GetBasketResponse"/>.
    /// </returns>
    protected override GetBasketResponse Action(GetBasketRequest request)
    {
      var basket = this.Repository.GetBasket(request.Email) ?? new Basket(request.Email);
      return new GetBasketResponse { ArticleCount = basket.Articles.Count, BasketValue = basket.Value, Email = request.Email };
    }

    #endregion
  }
}