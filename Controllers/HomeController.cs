using App.Domain.Core;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using App.Domain.Core.Entities;
using App.Infrastructure.Data.SqlServer;
using Microsoft.Extensions.Caching.Memory;

namespace Market_Place.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IMemoryCache _memorychache;
		private readonly MarketPlaceContext _dbContext;


		public HomeController(ILogger<HomeController> logger, IMemoryCache memorychache, MarketPlaceContext context)
		{
			_memorychache = memorychache;
			_logger = logger;
			_dbContext = context;
		}

		public IActionResult Index()
		{
			if (_memorychache.Get("Admins") == null)
			{
				MemoryCacheEntryOptions cacheOptions = new MemoryCacheEntryOptions();
				//cacheOptions.AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(20);
				cacheOptions.SlidingExpiration = TimeSpan.FromSeconds(8);
				var value = _dbContext.Admins.ToList();
				_memorychache.Set("Admins", value);
			}
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new Market_Place.Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}