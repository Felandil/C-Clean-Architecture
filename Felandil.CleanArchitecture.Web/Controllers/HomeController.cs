using System.Threading.Tasks;
using System.Web.Mvc;
using Felandil.CleanArchitecture.Basket.Usecase.AddArticle;
using Felandil.CleanArchitecture.Basket.Usecase.GetBasket;
using Felandil.CleanArchitecture.BasketRepository;
using Felandil.CleanArchitecture.Web.Models;
using Felandil.CleanArchitecture.Web.Presenters;

namespace Felandil.CleanArchitecture.Web.Controllers
{
  public class HomeController : Controller
  {
    private const string BasketEmail = "test@request.de";

    public HomeController()
    {
      GetBasketInteractor = new GetBasketInteractor<BasketModel>(new GetBasketPresenter(), new CacheBasketRepository());
      AddArticleInteractor =
        new AddArticleInteractor<BasketModel>(new AddArticlePresenter(), new CacheBasketRepository());
    }

    private AddArticleInteractor<BasketModel> AddArticleInteractor { get; }

    private GetBasketInteractor<BasketModel> GetBasketInteractor { get; }

    [HttpPost]
    public async Task<ActionResult> AddArticle(int quantity, decimal price)
    {
      await AddArticleInteractor.ExecuteAsync(new AddArticleRequest
        { Email = BasketEmail, Price = price, Quantity = quantity });
      return Json(await AddArticleInteractor.Presenter.PresentAsync());
    }

    public async Task<ActionResult> Index()
    {
      await GetBasketInteractor.ExecuteAsync(new GetBasketRequest { Email = BasketEmail });
      return View(await GetBasketInteractor.Presenter.PresentAsync());
    }
  }
}