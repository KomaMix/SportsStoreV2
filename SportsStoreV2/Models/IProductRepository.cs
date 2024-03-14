namespace SportsStoreV2.Models
{
	public interface IProductRepository
	{
		IQueryable<Product> Products { get; }
	}
}
