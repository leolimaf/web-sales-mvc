﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebSalesMVC.Models;

namespace WebSalesMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department(){Id = 1, Name = "Eletronics"});
            list.Add(new Department(){Id = 2, Name = "Fashion"});
            
            return View(list);
        }
    }
}