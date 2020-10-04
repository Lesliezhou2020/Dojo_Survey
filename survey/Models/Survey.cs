using System;
using System.ComponentModel.DataAnnotations;

namespace survey.Models
{
    public class Survey
    {
        public string name { get; set; }
        public string location { get; set; }
        public string language { get; set; }
        public string comment { get; set; }
        
    }
}