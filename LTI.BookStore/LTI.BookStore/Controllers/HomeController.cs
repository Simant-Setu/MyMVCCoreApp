﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LTI.BookStore.Controllers
{
    public class HomeController:Controller
    {
        //public string Index()
        public ViewResult Index() 
        {
            //return "LTI";
            return View(); 
        }
        public ViewResult AboutUs()
        {
            return View();
        }
    }
}
