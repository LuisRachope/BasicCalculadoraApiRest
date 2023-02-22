using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraApiRest.Model.Enums
{
    public enum Operations
    {
        [Description("Sum")]
        Sum = 1,
        [Description("Subtraction")]
        Subtraction = 2,
        [Description("Multiplication")]
        Multiplication = 3,
        [Description("Division")]
        Division = 4
    }
}
