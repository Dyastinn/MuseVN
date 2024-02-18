using Microsoft.AspNetCore.Mvc;
using MuseVN.DataAccess.Repository.IRepository;
using MuseVN.Models;


namespace MuseVNWeb.Areas.Admin.Controllers;
[Area("Admin")]


public class TagController : Controller {


    private readonly IUnitOfWork _unitOfWork;
    public TagController(IUnitOfWork unitOfWork) {
        _unitOfWork = unitOfWork;
    }

    public IActionResult Index() {
        List<Tag> objTagList = _unitOfWork.Tag.GetAll().ToList();
        return View(objTagList);
    }

    public IActionResult Create() {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Tag obj) {
        if (ModelState.IsValid) {
            _unitOfWork.Tag.Add(obj);
            _unitOfWork.Save();
            TempData["success"] = "A new Tag has been added";
            return RedirectToAction("Index", "Tag");
        }
        return View();

    }
    public IActionResult Edit(int? id) {
        if (id == null || id == 0) {
            return NotFound();
        }
        Tag? tagFromDb = _unitOfWork.Tag.Get(u => u.Id == id);
        if (tagFromDb == null) {
            return NotFound();
        }
        return View(tagFromDb);
    }
    [HttpPost]
    public IActionResult Edit(Tag obj) {
        if (ModelState.IsValid) {
            _unitOfWork.Tag.Update(obj);
            _unitOfWork.Save();
            TempData["success"] = "The tag has been updated";
            return RedirectToAction("Index", "Tag");
        }
        return View();

    }

    public IActionResult Delete(int? id) {
        if (id == null || id == 0) {
            return NotFound();
        }
        Tag? tagFromDb = _unitOfWork.Tag.Get(u => u.Id == id);
        if (tagFromDb == null) {
            return NotFound();
        }
        return View(tagFromDb);
    }
    [HttpPost, ActionName("Delete")]
    public IActionResult DeletePOST(int? id) {
        Tag? obj = _unitOfWork.Tag.Get(u => u.Id == id);
        if (obj == null) return NotFound();


        _unitOfWork.Tag.Remove(obj);
        _unitOfWork.Save();
        TempData["error"] = "The tag has been deleted";
        return RedirectToAction("Index", "Tag");


    }
}
