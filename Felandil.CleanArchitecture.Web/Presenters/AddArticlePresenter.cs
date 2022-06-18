using System.Threading.Tasks;
using Felandil.CleanArchitecture.Basket.Usecase.AddArticle;
using Felandil.CleanArchitecture.Web.Models;

namespace Felandil.CleanArchitecture.Web.Presenters
{
  public class AddArticlePresenter : UsecasePresenter<AddArticleResponse, BasketModel>
  {
    public override async Task<BasketModel> PresentAsync()
    {
      return new BasketModel
      {
        ArticleCount = Response.ArticleCount,
        BasketValue = Response.BasketValue.ToString("C0"),
        Email = Response.Email
      };
    }
  }
}