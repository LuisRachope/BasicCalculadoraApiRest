using CalculadoraApiRest.Model;
using CalculadoraApiRest.Model.Enums;
using CalculadoraApiRest.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraApiRest.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class CalculatorController : ControllerBase
    {
        
        public readonly CalculatorService _calculatorService;

        public CalculatorController(CalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }
       

        // GET operation SUM
        [HttpGet("sum/{value1}/{value2}")]
        public ActionResult<Calculator> Sum(double value1, double value2)
        {
            Calculator calc = _calculatorService.Sum(value1, value2);

            return Ok(calc);
        }

        // GET operation SUBTRACTION
        [HttpGet("subtraction/{value1}/{value2}")]
        public ActionResult<Calculator> Subtraction(double value1, double value2)
        {
            Calculator calc = _calculatorService.Subtraction(value1, value2);

            return Ok(calc);
        }

        // GET operation MULTIPLICATION
        [HttpGet("multiplication/{value1}/{value2}")]
        public ActionResult<Calculator> Multiplication(double value1, double value2)
        {
            Calculator calc = _calculatorService.Multiplication(value1, value2);

            return Ok(calc);
        }

        // GET operation DIVISION
        [HttpGet("division/{value1}/{value2}")]
        public ActionResult<Calculator> Division(double value1, double value2)
        {
            Calculator calc = _calculatorService.Division(value1, value2);

            return Ok(calc);
        }

        // GET ALL operations
        [HttpGet]
        public ActionResult<List<Calculator>> GettAll()
        {
            List<Calculator> list = _calculatorService.GettAll();

            return Ok(list);
        }
    }
}
