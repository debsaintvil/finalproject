using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // List<QuizNote> list =  Models.QuizNote.GetAll;
            return View("Index", Models.QuizNote.GetAll());
        }

        [HttpPost]
         public IActionResult NoteSubmit(string notetext, string name, int num)
        {
            Models.QuizNote.NoteSubmit(notetext, name, num);

            return RedirectToAction("Index"); //View("NoteSubmit");
            //RedirectToAction("NoteSubmit");
        }
        
        [HttpPost]
        public IActionResult Print()
        {
            return View("Index");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
