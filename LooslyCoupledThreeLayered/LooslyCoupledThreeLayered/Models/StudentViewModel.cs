using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LooslyCoupledThreeLayered.Models
{
    public class StudentViewModel
    {
        public string Name { get; set; }
        public string SummaryText { get; set; }
        public double GPA { get; set; }
    }
}