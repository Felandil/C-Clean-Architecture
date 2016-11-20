namespace Felandil.CleanArchitecture
{
  /// <summary>
  /// The usecase presenter.
  /// </summary>
  /// <typeparam name="TResponse">
  /// The response type
  /// </typeparam>
  /// <typeparam name="TViewModel">
  /// The returned view model
  /// </typeparam>
  public abstract class UsecasePresenter<TResponse, TViewModel>
    where TResponse : IResponseBoundry where TViewModel : IViewModel
  {
    #region Properties

    /// <summary>
    /// Gets or sets the response.
    /// </summary>
    protected TResponse Response { get; set; }

    #endregion

    #region Public Methods and Operators

    /// <summary>
    /// The present.
    /// </summary>
    /// <returns>
    /// The <see cref="TViewModel"/>.
    /// </returns>
    public abstract TViewModel Present();

    #endregion

    #region Methods

    /// <summary>
    /// The set response.
    /// </summary>
    /// <param name="response">
    /// The response.
    /// </param>
    public void SetResponse(TResponse response)
    {
      this.Response = response;
    }

    #endregion
  }
}