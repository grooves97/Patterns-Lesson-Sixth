﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC.PatternLesson.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "Hello world!!!";
        }
    }
}