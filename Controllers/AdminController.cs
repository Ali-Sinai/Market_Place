using App.Domain.Core.Contracts.Service;
using App.Domain.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace Market_Place.Controllers
{
	public class AdminController : Controller
	{
		private readonly IWebHostEnvironment _webHostEnvironment;
		//private readonly IAdminService _adminApplicationService;
        public AdminController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
            //_adminApplicationService = adminApplicationService;
        }
        [Area("Admin")]
		public IActionResult dashboard()
		{
            //	var filePath = Path.Combine(_webHostEnvironment.ContentRootPath, "Areas", "Admin", "dashboard" + ".html");
            //	var fileContent = System.IO.File.ReadAllText(filePath);

            //	return Content(fileContent, "text/html");
            var html = System.IO.File.ReadAllText(@"Areas/Admin/dashboard.html");
            return base.Content(html, "text/html");
        }

    //    public IActionResult ConfirmProduct(Product product, bool confirmed, CancellationToken cancellationToken)
    //    {
    //        _adminApplicationService.ConfirmSalesManeProducts(product, confirmed, cancellationToken);
    //        return View();
    //    }

    //    public IActionResult ConfirmComment(Comment comment, bool Confirmed, CancellationToken cancellationToken)
    //    {
    //        _adminApplicationService.ConfirmCustomerComment(comment, Confirmed, cancellationToken);
    //        return View();
    //    }

    //    public IActionResult EditCustomer(int customerId, Customer customer, CancellationToken cancellationToken)
    //    {
    //        _adminApplicationService.EditCustomer(customerId, customer, cancellationToken);
    //        return View();
    //    }

    //    public IActionResult DeleteCustomer(int customerId, CancellationToken cancellationToken)
    //    {
    //        _adminApplicationService.DeleteCustomer(customerId, cancellationToken);
    //        return View();
    //    }

    //    public IActionResult EditBooth(int boothId, Booth booth, CancellationToken cancellationToken)
    //    {
    //        _adminApplicationService.EditBooth(boothId, booth, cancellationToken);
    //        return View();
    //    }

    //    public IActionResult DeleteBooth(int boothId, CancellationToken cancellationToken)
    //    {
    //        _adminApplicationService.DeleteBooth(boothId, cancellationToken);
    //        return View();
    //    }

    //    public IActionResult EditProduct(Product product, CancellationToken cancellationToken)
    //    {
    //        _adminApplicationService.EditProduct(product, cancellationToken);
    //        return View();
    //    }

    //    public IActionResult DeleteProduct(int ProductId, CancellationToken cancellationToken)
    //    {
    //        _adminApplicationService.DeleteProduct(ProductId, cancellationToken);
    //        return View();
    //    }

    //    public IActionResult GetBoothDiscountDetails(int BoothId, CancellationToken cancellationToken)
    //    {
    //        _adminApplicationService.GetBoothDiscountDetails(BoothId, cancellationToken);
    //        return View();
    //    }
    }
}
