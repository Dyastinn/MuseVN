﻿using Microsoft.AspNetCore.Mvc;
using MuseVNWeb.Data;
using MuseVNWeb.Models;

namespace MuseVNWeb.Controllers{
    public class CategoryController : Controller{
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db){
            _db = db;
        }
        public IActionResult Index(){
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }

        public IActionResult Create() {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj) { 
            if(ModelState.IsValid){
                _db.Categories.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "A new category has been added";
                return RedirectToAction("Index", "Category");
            }
            return View();
            
        }
        public IActionResult Edit(int? id){
            if(id == null || id == 0) {
                return NotFound();
            }
            Category? categoryFromDb = _db.Categories.Find(id);
            if(categoryFromDb == null) {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
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
            Category? categoryFromDb = _db.Categories.Find(id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Category? obj = _db.Categories.Find(id);
            if(obj == null) return NotFound();
            
            _db.Categories.Remove(obj);
            _db.SaveChanges();
            TempData["error"] = "The category has been deleted";
            return RedirectToAction("Index", "Category");
 

        }
    }
}
