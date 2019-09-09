using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sheet2_V1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home


        
    public ActionResult Index()
    {
        return View();
    }
    

        public ActionResult GradesController(FormCollection collection)

        {
            if (Int32.TryParse(collection["score1"], out int numValue))
            {

                double score1 = Double.Parse(collection["score1"]);
                double score2 = Double.Parse(collection["score2"]);
                double score3 = Double.Parse(collection["score3"]);

                char grade;
                double average = (score1 + score2 + score3) / 3;


                ViewData["Average"] = average;

                if (average < 60) grade = 'F';
                else if (average < 69) grade = 'D';
                else if (average < 79) grade = 'C';
                else if (average < 89) grade = 'B';
                else grade = 'A';

                ViewData["Grade"] = grade;

                ViewBag.Grade = grade; 


                return View();
            }
            else 

            return View();
        }
        public ActionResult LoanController(FormCollection collection)
        {

            if (Int32.TryParse(collection["years"], out int numValue))
            {

                int years = Int32.Parse(collection["years"]);
                double amount = Double.Parse(collection["amount"]);
                double rate = Double.Parse(collection["rate"]);

                double total = amount; 

                for (int i = 0; i < years; i++)
                {
                    total = total * (1 + rate / 100);


                }

                ViewData["Years"] = years;
                ViewData["Amount"] = Convert.ToDecimal(amount).ToString("C"); 
                ViewData["Rate"] = rate;
                ViewData["Total"] = Convert.ToDecimal(total).ToString("C");
                


                return View();


            }
            else





                return View();
         
        }


    }
}