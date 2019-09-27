﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataStructuresAssignment.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            Queue<string> myQueue = new Queue<string>();
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();

            public static Random random = new Random();

            public static string randomName()
            {
                string[] names = new string[8] { "Dan Morain", "Emily Bell", "Carol Roche", "Ann Rose", "John Miller", "Greg Anderson", "Arthur McKinney", "Joann Fisher" };
                int randomIndex = Convert.ToInt32(random.NextDouble() * 7);
                return names[randomIndex];
            }

            public static int randomNumberInRange()
               {
                    return Convert.ToInt32(random.NextDouble() * 20);
                }
            return View();
        }
    }
}