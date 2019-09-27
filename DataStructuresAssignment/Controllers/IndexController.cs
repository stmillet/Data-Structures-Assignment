using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataStructuresAssignment.Controllers
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

    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            //Create queue and dictionary
            Queue<string> theLine = new Queue<string>();
            Dictionary<string, int> customerInfo = new Dictionary<string, int>();

            //Add customers to queue
            for (int iCount = 0; iCount < 99; iCount++)
            {
                string randomName = randomName();
                theLine.Enqueue(randomName);
            }    

            foreach (string customerName in theLine)
            {
                int numBurgers = randomNumberInRange();
                if (isFound(customerName))
                {
                    customerInfo(customerName,  )
                }
            }

            return View();
        }
    }
}