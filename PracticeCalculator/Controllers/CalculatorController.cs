using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Mvc;

namespace PracticeCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index()
        {
            return "abacus";
        }

        public double Add(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
