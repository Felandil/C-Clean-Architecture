// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomeController.cs" company="Felandil IT">
//   Copyright (c) 2014 - 2016 Felandil IT. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.CleanArchitecture.Web.Controllers
{
  using System.Web.Mvc;

  using Felandil.CleanArchitecture.Basket.Usecase.AddArticle;
  using Felandil.CleanArchitecture.Basket.Usecase.GetBasket;
  using Felandil.CleanArchitecture.BasketRepository;
  using Felandil.CleanArchitecture.Web.Models;
  using Felandil.CleanArchitecture.Web.Presenters;

  /// <summary>
  /// The home controller.
  /// </summary>
  public class HomeController : Controller
  {
    #region Constants

    /// <summary>
    /// The basket email.
    /// </summary>
    private const string BasketEmail = "test@request.de";

    #endregion

    #region Constructors and Destructors

    /// <summary>
    /// Initializes a new instance of the <see cref="HomeController"/> class.
    /// </summary>
    public HomeController()
    {
      this.GetBasketInteractor = new GetBasketInteractor<BasketModel>(new GetBasketPresenter(), new CacheBasketRepository());
      this.AddArticleInteractor = new AddArticleInteractor<BasketModel>(new AddArticlePresenter(), new CacheBasketRepository());
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the add article interactor.
    /// </summary>
    private AddArticleInteractor<BasketModel> AddArticleInteractor { get; set; }

    /// <summary>
    /// Gets or sets the get basket interactor.
    /// </summary>
    private GetBasketInteractor<BasketModel> GetBasketInteractor { get; set; }

    #endregion

    #region Public Methods and Operators

    /// <summary>
    /// The add article.
    /// </summary>
    /// <param name="quantity">
    /// The quantity.
    /// </param>
    /// <param name="price">
    /// The price.
    /// </param>
    /// <returns>
    /// The <see cref="JsonResult"/>.
    /// </returns>
    [HttpPost]
    public ActionResult AddArticle(int quantity, decimal price)
    {
      this.AddArticleInteractor.Execute(new AddArticleRequest { Email = BasketEmail, Price = price, Quantity = quantity });
      return this.Json(this.AddArticleInteractor.Presenter.Present());
    }

    /// <summary>
    /// The index.
    /// </summary>
    /// <returns>
    /// The <see cref="ActionResult"/>.
    /// </returns>
    public ActionResult Index()
    {
      this.GetBasketInteractor.Execute(new GetBasketRequest { Email = BasketEmail });
      return this.View(this.GetBasketInteractor.Presenter.Present());
    }

    #endregion
  }
}