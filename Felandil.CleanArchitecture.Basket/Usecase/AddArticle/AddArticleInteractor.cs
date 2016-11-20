﻿// --------------------------------------------------------------------------------------------------------------------
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.CleanArchitecture.Basket.Usecase.AddArticle
{
  using Felandil.CleanArchitecture.Basket.Entity;
  using Felandil.CleanArchitecture.Basket.Repository;

  /// <summary>
  /// The add article interactor.
  /// </summary>
  /// <typeparam name="TViewModel">
  /// The view Model
  /// </typeparam>
  public class AddArticleInteractor<TViewModel> : UsecaseInteractor<AddArticleRequest, AddArticleResponse, TViewModel>
    where TViewModel : IViewModel
  {
    #region Constructors and Destructors

    /// <summary>
    /// Initializes a new instance of the <see cref="AddArticleInteractor{TViewModel}"/> class. 
    /// </summary>
    /// <param name="presenter">
    /// The presenter.
    /// </param>
    /// <param name="repository">
    /// The repository.
    /// </param>
    public AddArticleInteractor(UsecasePresenter<AddArticleResponse, TViewModel> presenter, IBasketRepository repository)
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
    /// The execute.
    /// </summary>
    /// <param name="request">
    /// The request.
    /// </param>
    public override void Execute(AddArticleRequest request)
    {
      var basket = this.Repository.GetBasket(request.Email) ?? new Basket(request.Email);

      basket.Articles.Add(new Article { Price = request.Price, Quantity = request.Quantity });
      this.Repository.SaveBasket(basket);

      this.Presenter.SetResponse(new AddArticleResponse { BasketValue = basket.Value, ArticleCount = basket.Articles.Count, Email = request.Email });
    }

    #endregion
  }
}