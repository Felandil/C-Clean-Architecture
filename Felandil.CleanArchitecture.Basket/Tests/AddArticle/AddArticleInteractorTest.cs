// --------------------------------------------------------------------------------------------------------------------
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.CleanArchitecture.Basket.Tests.AddArticle
{
  using Felandil.CleanArchitecture.Basket.Entity;
  using Felandil.CleanArchitecture.Basket.Usecase.AddArticle;

  using Microsoft.VisualStudio.TestTools.UnitTesting;

  /// <summary>
  /// The add article interactor test.
  /// </summary>
  [TestClass]
  public class AddArticleInteractorTest
  {
    #region Public Methods and Operators

    /// <summary>
    /// The test basket does not exist should return information and create new basket.
    /// </summary>
    [TestMethod]
    public void TestBasketDoesNotExistShouldReturnInformationAndCreateNewBasket()
    {
      var interactor = new AddArticleInteractor<IViewModel>(new TestAddArticlePresenter(), new InMemoryBasketRepository());
      interactor.ExecuteAsync(new AddArticleRequest { Email = "test@a.de", Price = 9.99M, Quantity = 2 });

      var response = ((TestAddArticlePresenter)interactor.Presenter).GetResponse();

      Assert.AreEqual(1, response.ArticleCount);
      Assert.AreEqual(19.98M, response.BasketValue);
      Assert.AreEqual("test@a.de", response.Email);
    }

    /// <summary>
    /// The test basket exists should be safed after modification.
    /// </summary>
    [TestMethod]
    public void TestBasketExistsShouldBeSafedAfterModification()
    {
      var basket = new Basket("test@a.de");
      basket.Articles.Add(new Article { Price = 19.99M, Quantity = 1 });
      var inMemoryBasketRepository = new InMemoryBasketRepository(basket);

      var interactor = new AddArticleInteractor<IViewModel>(new TestAddArticlePresenter(), inMemoryBasketRepository);
      interactor.ExecuteAsync(new AddArticleRequest { Email = "test@a.de", Price = 9.99M, Quantity = 2 });

      var response = ((TestAddArticlePresenter)interactor.Presenter).GetResponse();

      Assert.AreEqual(2, response.ArticleCount);
      Assert.AreEqual(39.97M, response.BasketValue);

      var savedBasket = inMemoryBasketRepository.GetBasket(string.Empty);
      Assert.AreEqual(2, savedBasket.Articles.Count);
      Assert.AreEqual(39.97M, savedBasket.Value);
    }

    #endregion
  }
}