using System.Threading.Tasks;
using Felandil.CleanArchitecture.Basket.Entity;
using Felandil.CleanArchitecture.Basket.Repository;

namespace Felandil.CleanArchitecture.Basket.Usecase.AddArticle
{
  public class AddArticleInteractor<TViewModel> : UsecaseInteractor<AddArticleRequest, AddArticleResponse, TViewModel>
    where TViewModel : IViewModel
  {
    public AddArticleInteractor(UsecasePresenter<AddArticleResponse, TViewModel> presenter,
      IBasketRepository repository)
      : base(presenter)
    {
      Repository = repository;
    }

    private IBasketRepository Repository { get; }

    protected async override Task<AddArticleResponse> ActionAsync(AddArticleRequest request)
    {
      var basket = Repository.GetBasket(request.Email) ?? new Entity.Basket(request.Email);

      basket.Articles.Add(new Article { Price = request.Price, Quantity = request.Quantity });
      Repository.SaveBasket(basket);

      return new AddArticleResponse
        { BasketValue = basket.Value, ArticleCount = basket.Articles.Count, Email = request.Email };
    }
  }
}