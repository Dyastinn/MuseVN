using Microsoft.AspNetCore.Mvc;
using MuseVN.Models;
using MuseVNWeb.DataAccess.Data;
using MuseVN.DataAccess.Repository.IRepository;


namespace MuseVNWeb.Areas.Admin.Controllers;
[Area("Admin")]
public class PlatformController : Controller {

    private readonly IUnitOfWork _unitOfWork;
    public PlatformController(IUnitOfWork unitOfWork) {
        _unitOfWork = unitOfWork;
    }
    public IActionResult Index() {
        List<Platform> objPlatformList = _unitOfWork.Platform.GetAll().ToList();
        return View(objPlatformList);
    }

    public IActionResult Create() {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Platform obj) {
        if (ModelState.IsValid) {
            _unitOfWork.Platform.Add(obj);
            _unitOfWork.Save();
            TempData["success"] = "A new platform has been added";
            return RedirectToAction("Index", "Platform");
        }
        return View();

    }
    public IActionResult Edit(int? id) {
        if (id == null || id == 0) {
            return NotFound();
        }
        Platform? platformFromDb = _unitOfWork.Platform.Get(u => u.Id == id);
        if (platformFromDb == null) {
            return NotFound();
        }
        return View(platformFromDb);
    }
    [HttpPost]
    public IActionResult Edit(Platform obj) {
        if (ModelState.IsValid) {
            _unitOfWork.Platform.Update(obj);
            _unitOfWork.Save();
            TempData["success"] = "The platform has been updated";
            return RedirectToAction("Index", "Platform");
        }
        return View();

    }

    public IActionResult Delete(int? id) {
        if (id == null || id == 0) {
            return NotFound();
        }
        Platform? platformFromDb = _unitOfWork.Platform.Get(u => u.Id == id);
        if (platformFromDb == null) {
            return NotFound();
        }
        return View(platformFromDb);
    }
    [HttpPost, ActionName("Delete")]
    public IActionResult DeletePOST(int? id) {
        Platform? obj = _unitOfWork.Platform.Get(u => u.Id == id);
        if (obj == null) return NotFound();


        _unitOfWork.Platform.Remove(obj);
        _unitOfWork.Save();
        TempData["error"] = "The platform has been deleted";
        return RedirectToAction("Index", "Platform");


    }
}
