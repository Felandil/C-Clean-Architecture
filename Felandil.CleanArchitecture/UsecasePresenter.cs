using System.Threading.Tasks;

namespace Felandil.CleanArchitecture
{
  public abstract class UsecasePresenter<TResponse, TViewModel>
    where TResponse : IResponseBoundry where TViewModel : IViewModel
  {
    protected TResponse Response { get; set; }

    public abstract Task<TViewModel> PresentAsync();

    public void SetResponse(TResponse response)
    {
      this.Response = response;
    }
  }
}