﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
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

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }

        public string Sorry()
        {
            return "I'm sorry";
        }
    }
}