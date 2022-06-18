using System.Threading.Tasks;
using Felandil.CleanArchitecture.Basket.Repository;

namespace Felandil.CleanArchitecture.Basket.Usecase.GetBasket
{
  public class GetBasketInteractor<TViewModel> : UsecaseInteractor<GetBasketRequest, GetBasketResponse, TViewModel>
    where TViewModel : IViewModel
  {
    public GetBasketInteractor(UsecasePresenter<GetBasketResponse, TViewModel> presenter, IBasketRepository repository)
      : base(presenter)
    {
      Repository = repository;
    }

    private IBasketRepository Repository { get; }

    protected override async Task<GetBasketResponse> ActionAsync(GetBasketRequest request)
    {
      var basket = Repository.GetBasket(request.Email) ?? new Entity.Basket(request.Email);
      return new GetBasketResponse
        { ArticleCount = basket.Articles.Count, BasketValue = basket.Value, Email = request.Email };
    }
  }
}