using Microsoft.AspNetCore.Mvc;
using SportsStoreV2.Models;

namespace SportsStoreV2.Controllers
{
	public class ProductController : Controller
	{
		private IProductRepository repository;
		public ProductController(IProductRepository repository)
		{
			this.repository = repository;
		}
	}
}
