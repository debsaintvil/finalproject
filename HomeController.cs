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
            return View("Index");
        }

        [HttpPost]
        public IActionResult NoteSubmit0(string notetext, int quiznumber)
        {
            var QuizNote = new QuizNote();

            QuizNote.NoteText = notetext;
            QuizNote.QuizNumber = 0;
            GlobalVariables.QuizNotes.Add(QuizNote);

            return View("NoteSubmit");
        }

        [HttpPost]
         public IActionResult NoteSubmit1(string notetext, int quiznumber)
        {
            var QuizNote = new QuizNote();

            QuizNote.NoteText = notetext;
            QuizNote.QuizNumber = 1;
            GlobalVariables.QuizNotes.Add(QuizNote);

            return View("NoteSubmit");
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
