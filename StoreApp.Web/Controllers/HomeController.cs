using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreApp.Data.Abstract;
using StoreApp.Data.Concrete;
using StoreApp.Web.Models;

namespace StoreApp.Web.Controllers;

public class HomeController : Controller
{
    public int pageSize = 3;
    private IStoreRepository _storeRepository;
    public HomeController(IStoreRepository storeRepository)
    {
        _storeRepository = storeRepository;
    }
    public IActionResult Index(int page = 1)
    {
        var products = _storeRepository.Products.Skip((page - 1) * pageSize).Select(p => new ProductViewModel
        {
            Id = p.Id,
            Name = p.Name,
            Description = p.Description,
            Price = p.Price
        }).ToList();

        return View(new ProductListViewModel
        {
            Products = products,
            PageInfo = new PageInfo
            {
                ItemPerPage = pageSize,
                TotalItems = _storeRepository.Products.Count()
            }
        });
    }
}