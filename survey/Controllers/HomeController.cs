using System;
using System.Collections.Generic;
using survey.Models;
using Microsoft.AspNetCore.Mvc;
namespace survey.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet("")]       //type of request
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost("survey")]
        public IActionResult Submission(Survey yourSurvey)
        {
            if(ModelState.IsValid)
            {
                return View("Submission", yourSurvey);
            }
            else
            {
                return Index();
            }
        }
    }
}
