using Microsoft.AspNetCore.Mvc;
using MuseVN.Models;
using MuseVNWeb.DataAccess.Data;
using MuseVN.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace MuseVNWeb.Areas.Admin.Controllers;
[Area("Admin")]
public class ProductController : Controller
{

    private readonly IUnitOfWork _unitOfWork;
    public ProductController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public IActionResult Index()
    {
        List<Product> objProductList = _unitOfWork.Product.GetAll().ToList();
        

        return View(objProductList);
    }

    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Product obj)
    {
        if (ModelState.IsValid)
        {
            _unitOfWork.Product.Add(obj);
            _unitOfWork.Save();
            TempData["success"] = "A new Product has been added";
            return RedirectToAction("Index", "Product");
        }
        return View();

    }
    public IActionResult Edit(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }
        Product? ProductFromDb = _unitOfWork.Product.Get(u => u.Id == id);
        if (ProductFromDb == null)
        {
            return NotFound();
        }
        return View(ProductFromDb);
    }
    [HttpPost]
    public IActionResult Edit(Product obj)
    {
        if (ModelState.IsValid)
        {
            _unitOfWork.Product.Update(obj);
            _unitOfWork.Save();
            TempData["success"] = "The Product has been updated";
            return RedirectToAction("Index", "Product");
        }
        return View();

    }

    public IActionResult Delete(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }
        Product? ProductFromDb = _unitOfWork.Product.Get(u => u.Id == id);
        if (ProductFromDb == null)
        {
            return NotFound();
        }
        return View(ProductFromDb);
    }
    [HttpPost, ActionName("Delete")]
    public IActionResult DeletePOST(int? id)
    {
        Product? obj = _unitOfWork.Product.Get(u => u.Id == id);
        if (obj == null) return NotFound();


        _unitOfWork.Product.Remove(obj);
        _unitOfWork.Save();
        TempData["error"] = "The Product has been deleted";
        return RedirectToAction("Index", "Product");


    }
}
