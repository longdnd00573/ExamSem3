using Exam_sem3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exam_sem3.Controllers
{
    public class ExamController : Controller
    {
        ExamWADEntities db = new ExamWADEntities();
        // GET: Exam
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Exam exam)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    exam.Status = 1;
                    db.Exams.Add(exam);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(exam);
            }
            catch
            {
                return View();
            }
        }
    }
}