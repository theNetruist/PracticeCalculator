using PracticeCalculator.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Mvc;

namespace PracticeCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        public double Add(AbacusModel abacus)
        {
            return abacus.firstNumber + abacus.secondNumber;
        }

        public double Subtract(AbacusModel abacus)
        {
            return abacus.firstNumber - abacus.secondNumber;
        }

        public double Multiply(AbacusModel abacus)
        {
            return abacus.firstNumber * abacus.secondNumber;
        }

        public double Divide(AbacusModel abacus)
        {
            return abacus.firstNumber / abacus.secondNumber;
        }
    }
}
