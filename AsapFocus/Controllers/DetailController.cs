using AsapFocus.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsapFocus.Controllers
{
    public class DetailController : Controller
    {
        Context context = new Context();
        HS_CostOfFuture hS_CostOfFuture = new HS_CostOfFuture(); 
        
        [HttpGet]
        public IActionResult Index(int id)
        {
            var result = context.HS_CostOfFutures.Where(x => x.DocNum == id).ToList();
            
           
            return View(result);
        }
    }
}
