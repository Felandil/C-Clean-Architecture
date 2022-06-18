using System.Threading.Tasks;

namespace Felandil.CleanArchitecture.Basket.Tests.GetBasket
{
  using System;

  using Felandil.CleanArchitecture.Basket.Usecase.GetBasket;

  internal class TestGetBasketPresenter : UsecasePresenter<GetBasketResponse, IViewModel>
  {
    public GetBasketResponse GetBasketResponse()
    {
      return this.Response;
    }

    public override Task<IViewModel> PresentAsync()
    {
      throw new NotImplementedException();
    }
  }
}