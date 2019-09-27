using System;
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
            for (int iCount = 0; iCount < 99; iCount++)
            {
                string personsName = randomName();
                theLine.Enqueue(personsName);
            }    

            //Foreach statement that gives each customer in the line the number of burgers they ordered that instance. 
           
            foreach (string customerName in theLine)
            {
                int numBurgers = randomNumberInRange();
                if (!isFound(customerName, customerInfo))
                {
                    customerInfo.Add(customerName, 0);
                }
                customerInfo[customerName] += numBurgers;
            }

            return View();
        }
    }
}