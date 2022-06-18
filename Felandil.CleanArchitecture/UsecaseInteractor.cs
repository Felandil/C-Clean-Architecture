using System.Threading.Tasks;

namespace Felandil.CleanArchitecture
{
  public abstract class UsecaseInteractor<TRequest, TResponse, TViewModel>
    where TRequest : IRequestBoundry where TResponse : IResponseBoundry where TViewModel : IViewModel
  {
    protected UsecaseInteractor(UsecasePresenter<TResponse, TViewModel> presenter)
    {
      Presenter = presenter;
    }

    public UsecasePresenter<TResponse, TViewModel> Presenter { get; }

    public async Task ExecuteAsync(TRequest request)
    {
      Presenter.SetResponse(await ActionAsync(request));
    }

    protected abstract Task<TResponse> ActionAsync(TRequest request);
  }
}