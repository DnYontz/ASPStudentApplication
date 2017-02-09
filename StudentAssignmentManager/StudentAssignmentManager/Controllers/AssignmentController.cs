using StudentAssignmentManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentAssignmentManager.Controllers
{
    public class AssignmentController : Controller
    {
        // GET: Assignment
        public ActionResult Index()
        {
            using (AssignmentContext context = new AssignmentContext())
            {
                return View();
            }
        }
        public ActionResult Create()
        {
            return View("Manage");
        }
        public ActionResult Edit(int id)
        {
            var Model = new Assignment();
            return View("Manage", Model);
        }
    }
}