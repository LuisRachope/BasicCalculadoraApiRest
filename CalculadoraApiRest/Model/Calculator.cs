using CalculadoraApiRest.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraApiRest.Model
{
    public class Calculator
    {
        public int Id { get; set; }
        public Operations Operation { get; set; }
        public double Total { get; set; }
    }
}
