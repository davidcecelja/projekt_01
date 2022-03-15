using projekt_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projekt_01.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index() // tu se klikne na index view tj za taj kontoler delamo novi view
        {
            ViewBag.Title = "Početna o studentima";
            ViewBag.Fakultet = "MEV";
            return View();
        }
        public ActionResult Popis()
        {
            StudentiDB studentDB = new StudentiDB();
            return View(studentDB);
        }
    }
}