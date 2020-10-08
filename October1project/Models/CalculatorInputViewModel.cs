using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace October1project.Models
{
    public class CalculatorInputViewModel
    {
        public decimal InputOne { get; set; }
        public decimal InputTwo { get; set; }
        public CalculatorType Action { get; set; }
        public string Result { get; set; }
    }
}