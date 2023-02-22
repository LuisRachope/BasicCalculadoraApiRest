using CalculadoraApiRest.Model;
using CalculadoraApiRest.Model.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraApiRest.Services
{
    public class CalculatorService
    {
        static List<Calculator> HistoryCalcs { get; set; }
        static int nextId = 0;

        static CalculatorService()
        {
            HistoryCalcs = new List<Calculator>();
        }


        public Calculator Sum(double num1, double num2)
        {
            nextId++;
            double total = num1 + num2;
            Calculator calc = new Calculator { Id = nextId, Total = total, Operation = Operations.Sum };

            HistoryCalcs.Add(calc);

            return calc;
        }

        public Calculator Subtraction(double num1, double num2)
        {
            nextId++;
            double total = num1 - num2;
            Calculator calc = new Calculator { Id = nextId, Total = total, Operation = Operations.Subtraction };

            HistoryCalcs.Add(calc);

            return calc;
        }

        public Calculator Multiplication(double num1, double num2)
        {
            nextId++;
            double total = num1 * num2;
            Calculator calc = new Calculator { Id = nextId, Total = total, Operation = Operations.Multiplication };

            HistoryCalcs.Add(calc);

            return calc;
        }

        public Calculator Division(double num1, double num2)
        {
            nextId++;
            double total = num1 / num2;
            Calculator calc = new Calculator { Id = nextId, Total = total, Operation = Operations.Division };

            HistoryCalcs.Add(calc);

            return calc;
        }
        public List<Calculator> GettAll()
        {
            return HistoryCalcs.ToList();
        }
    }
}
