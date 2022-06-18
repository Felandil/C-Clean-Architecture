using System.Threading.Tasks;

namespace Felandil.CleanArchitecture.Basket.Tests.AddArticle
{
  using System;

  using Felandil.CleanArchitecture.Basket.Usecase.AddArticle;

  internal class TestAddArticlePresenter : UsecasePresenter<AddArticleResponse, IViewModel>
  {
    public AddArticleResponse GetResponse()
    {
      return this.Response;
    }

    public override Task<IViewModel> PresentAsync()
    {
      throw new NotImplementedException();
    }
  }
}