using Microsoft.AspNetCore.Mvc;
using MuseVN.Models;
using MuseVN.DataAccess.Repository.IRepository;


namespace MuseVNWeb.Areas.Admin.Controllers;
[Area("Admin")]
public class LanguageController : Controller {

    private readonly IUnitOfWork _unitOfWork;
    public LanguageController(IUnitOfWork unitOfWork) {
        _unitOfWork = unitOfWork;
    }
    public IActionResult Index() {
        List<Language> objLanguageList = _unitOfWork.Language.GetAll().ToList();
        return View(objLanguageList);
    }

    public IActionResult Create() {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Language obj) {
        if (ModelState.IsValid) {
            _unitOfWork.Language.Add(obj);
            _unitOfWork.Save();
            TempData["success"] = "A new language has been added";
            return RedirectToAction("Index", "Language");
        }
        return View();

    }
    public IActionResult Edit(int? id) {
        if (id == null || id == 0) {
            return NotFound();
        }
        Language? languageFromDb = _unitOfWork.Language.Get(u => u.Id == id);
        if (languageFromDb == null) {
            return NotFound();
        }
        return View(languageFromDb);
    }
    [HttpPost]
    public IActionResult Edit(Language obj) {
        if (ModelState.IsValid) {
            _unitOfWork.Language.Update(obj);
            _unitOfWork.Save();
            TempData["success"] = "The language has been updated";
            return RedirectToAction("Index", "Language");
        }
        return View();

    }

    public IActionResult Delete(int? id) {
        if (id == null || id == 0) {
            return NotFound();
        }
        Language? languageFromDb = _unitOfWork.Language.Get(u => u.Id == id);
        if (languageFromDb == null) {
            return NotFound();
        }
        return View(languageFromDb);
    }
    [HttpPost, ActionName("Delete")]
    public IActionResult DeletePOST(int? id) {
        Language? obj = _unitOfWork.Language.Get(u => u.Id == id);
        if (obj == null) return NotFound();


        _unitOfWork.Language.Remove(obj);
        _unitOfWork.Save();
        TempData["error"] = "The language has been deleted";
        return RedirectToAction("Index", "Language");


    }
}
