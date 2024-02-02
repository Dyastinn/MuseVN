using Microsoft.AspNetCore.Mvc;
using MuseVN.Models;
using MuseVNWeb.DataAccess.Data;
using MuseVN.DataAccess.Repository.IRepository;


namespace MuseVNWeb.Areas.Admin.Controllers;
[Area("Admin")]
public class CategoryController : Controller
{

    private readonly IUnitOfWork _unitOfWork;
    public CategoryController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public IActionResult Index()
    {
        List<Category> objCategoryList = _unitOfWork.Category.GetAll().ToList();
        return View(objCategoryList);
    }

    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Category obj)
    {
        if (ModelState.IsValid)
        {
            _unitOfWork.Category.Add(obj);
            _unitOfWork.Save();
            TempData["success"] = "A new category has been added";
            return RedirectToAction("Index", "Category");
        }
        return View();

    }
    public IActionResult Edit(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }
        Category? categoryFromDb = _unitOfWork.Category.Get(u => u.Id == id);
        if (categoryFromDb == null)
        {
            return NotFound();
        }
        return View(categoryFromDb);
    }
    [HttpPost]
    public IActionResult Edit(Category obj)
    {
        if (ModelState.IsValid)
        {
            _unitOfWork.Category.Update(obj);
            _unitOfWork.Save();
            TempData["success"] = "The category has been updated";
            return RedirectToAction("Index", "Category");
        }
        return View();

    }

    public IActionResult Delete(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }
        Category? categoryFromDb = _unitOfWork.Category.Get(u => u.Id == id);
        if (categoryFromDb == null)
        {
            return NotFound();
        }
        return View(categoryFromDb);
    }
    [HttpPost, ActionName("Delete")]
    public IActionResult DeletePOST(int? id)
    {
        Category? obj = _unitOfWork.Category.Get(u => u.Id == id);
        if (obj == null) return NotFound();


        _unitOfWork.Category.Remove(obj);
        _unitOfWork.Save();
        TempData["error"] = "The category has been deleted";
        return RedirectToAction("Index", "Category");


    }
}
