// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UsecaseInteractor.cs" company="Felandil IT">
//    Copyright (c) 2008 -2017 Felandil IT. All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.CleanArchitecture
{
  /// <summary>
  /// The usecase interactor.
  /// </summary>
  /// <typeparam name="TRequest">
  /// The request
  /// </typeparam>
  /// <typeparam name="TResponse">
  /// The response
  /// </typeparam>
  /// <typeparam name="TViewModel">
  /// The view model
  /// </typeparam>
  public abstract class UsecaseInteractor<TRequest, TResponse, TViewModel>
    where TRequest : IRequestBoundry where TResponse : IResponseBoundry where TViewModel : IViewModel
  {
    #region Constructors and Destructors

    /// <summary>
    /// Initializes a new instance of the <see cref="UsecaseInteractor{TRequest,TResponse,TViewModel}"/> class.
    /// </summary>
    /// <param name="presenter">
    /// The presenter.
    /// </param>
    protected UsecaseInteractor(UsecasePresenter<TResponse, TViewModel> presenter)
    {
      this.Presenter = presenter;
    }

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets the presenter.
    /// </summary>
    public UsecasePresenter<TResponse, TViewModel> Presenter { get; private set; }

    #endregion

    #region Public Methods and Operators

    /// <summary>
    /// The execute.
    /// </summary>
    /// <param name="request">
    /// The request.
    /// </param>
    public void Execute(TRequest request)
    {
      this.Presenter.SetResponse(this.Action(request));
    }

    #endregion

    #region Methods

    /// <summary>
    /// The action.
    /// </summary>
    /// <param name="request">
    /// The request.
    /// </param>
    /// <returns>
    /// The <see cref="TResponse"/>.
    /// </returns>
    protected abstract TResponse Action(TRequest request);

    #endregion
  }
}