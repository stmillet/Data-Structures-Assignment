﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataStructuresAssignment.Controllers
{
    public class IndexController : Controller
    {
        public static Random random = new Random();

        //Generate a random name

        public static string randomName()
        {
            string[] names = new string[8] { "Dan Morain", "Emily Bell", "Carol Roche", "Ann Rose", "John Miller", "Greg Anderson", "Arthur McKinney", "Joann Fisher" };
            int randomIndex = Convert.ToInt32(random.NextDouble() * 7);
            return names[randomIndex];
        }

        //this checks to see if each customer is in the dictionary
        
        public static bool isFound(string customerName, Dictionary<string, int> tempDictionary)
        {
            if (tempDictionary.ContainsKey(customerName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Generate a random number

        public static int randomNumberInRange()
        {
            return Convert.ToInt32(random.NextDouble() * 20);
        }

        // GET: Index

        public ActionResult Index()
        {

            //Create queue and dictionary

            Queue<string> theLine = new Queue<string>();
            Dictionary<string, int> customerInfo = new Dictionary<string, int>();

            //Add customers to queue

            for (int iCount = 0; iCount < 100; iCount++)
            {
                string personsName = randomName();
                theLine.Enqueue(personsName);
            }    

            //For statement that gives each customer in the line the number of burgers they ordered that instance. 
           
            for (int iCount = 0; iCount < 100; iCount++)
            {
                string customerName = theLine.Dequeue();
                int numBurgers = randomNumberInRange();

                if (!isFound(customerName, customerInfo))
                {
                    customerInfo.Add(customerName, 0);
                }

                customerInfo[customerName] += numBurgers;
            }

            //Statement to Sort the dictionary by the number of Burgers eaten.

            var items = from pair in customerInfo orderby pair.Value ascending select pair;

            //Creates the heading for the output table

            ViewBag.Output = "<table id='ourTable'>";
            ViewBag.Output += "<tr>";
            ViewBag.Output += "<th>Customer Name:</th>";
            ViewBag.Output += "<th class='theBurgers'>Burgers Ordered:</th>";
            ViewBag.Output += "</tr>";

            //For Each Statement to finish creating the table and load it to the viewbag.

            foreach (KeyValuePair<string, int> sName in items)
            {
                ViewBag.Output += "<tr><td>" + sName.Key + "</td><td class='theBurgers'>" + sName.Value + "</td></tr>";
            }

            return View();
        }
    }
}