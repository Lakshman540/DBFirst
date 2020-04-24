using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDBFirst.Models;

namespace EFDBFirst.Controllers
{
    public class CategoryController : Controller
    {
       
        // GET: Category
        public ActionResult Index()
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
            List<Category> categories= db.Categories.ToList();
            return View(categories);
        }
    }
}