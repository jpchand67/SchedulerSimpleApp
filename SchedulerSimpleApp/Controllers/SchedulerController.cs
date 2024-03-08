using DevExtreme.MVC.Demos.Models.SampleData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace DevExtreme.MVC.Demos.Controllers
{
    public class SchedulerController : Controller
    {
        public ActionResult BasicViews()
        {
            return View(SampleData.Appointments);
        }
    }
}