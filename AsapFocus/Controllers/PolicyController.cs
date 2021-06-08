using AsapFocus.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsapFocus.Controllers
{
    public class PolicyController : Controller
    {
         Context _context=new Context(); 
        
        [HttpGet]
        public async Task<IActionResult> Index()
        {


            List<SelectListItem> value = (from x in _context.Hs_ExpenseTypes.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.ExpenseType,
                                              Value = x.Id.ToString()
                                          }).ToList();

            ViewBag.v1 = value;
            return View();
            
        }
        [HttpPost]
        public async Task<IActionResult> Index(HS_CostOfFuture expenseFuture)
        {

            if (ModelState.IsValid)
            {

                _context.HS_CostOfFutures.Add(expenseFuture);
                _context.SaveChanges();
                return RedirectToAction("Index", "Detail", new { id = expenseFuture.DocNum });
            }
            return View("Index","Policy");
        }


        [HttpPost]
        public IActionResult ExpenseAdd(Hs_ExpenseType  hs_ExpenseType )
        {

            if (ModelState.IsValid)
            {
                _context.Hs_ExpenseTypes.Add(hs_ExpenseType);
                _context.SaveChanges();
                return RedirectToAction("Index", "Policy");
            }
            return View();
        }

    }
}
