using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNET.Controllers
{
    [Route("api/[controller]")]
    public class CalculatorController : Controller
    {
        // GET api/values/5
        [HttpGet("{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstnumber, string secondNumber)
        {
            if (IsNumeric(firstnumber) && IsNumeric(secondNumber))
            {
                var sum = Convert.ToDecimal(firstnumber) + Convert.ToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input.");
        }

        //Comentado. Existe a função Convert.To

        //private decimal ConvertToDecimal(string number)
        //{
        //    decimal decimalValue;
        //    if (decimal.TryParse(number, out decimalValue))
        //    {
        //        return decimalValue;
        //    }
        //    return 0;
        //}

        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(strNumber, System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo, out number);
            return isNumber;
        }
    }
}
