// --------------------------------------------------------------------------------------------------------------------
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.CleanArchitecture.Basket.Tests
{
  using Felandil.CleanArchitecture.Basket.Entity;
  using Felandil.CleanArchitecture.Basket.Repository;

  /// <summary>
  /// The in memory Basket repository.
  /// </summary>
  internal class InMemoryBasketRepository : IBasketRepository
  {
    #region Constructors and Destructors

    /// <summary>
    /// Initializes a new instance of the <see cref="InMemoryBasketRepository"/> class.
    /// </summary>
    /// <param name="basket">
    /// The Basket.
    /// </param>
    public InMemoryBasketRepository(Basket basket)
    {
      this.Basket = basket;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="InMemoryBasketRepository"/> class.
    /// </summary>
    public InMemoryBasketRepository()
    {
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the basket.
    /// </summary>
    private Basket Basket { get; set; }

    #endregion

    #region Public Methods and Operators

    /// <summary>
    /// The get Basket.
    /// </summary>
    /// <param name="email">
    /// The email.
    /// </param>
    /// <returns>
    /// The <see cref="Entity.Basket"/>.
    /// </returns>
    public Basket GetBasket(string email)
    {
      return this.Basket;
    }

    /// <summary>
    /// The save Basket.
    /// </summary>
    /// <param name="basket">
    /// The Basket.
    /// </param>
    public void SaveBasket(Basket basket)
    {
      this.Basket = basket;
    }

    #endregion
  }
}