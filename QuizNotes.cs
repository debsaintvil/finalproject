using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Final_Project.Models
{
    public class QuizNote
    {
        public string NoteText { get; set; } //the text of the quiz note

        public int QuizNumber { get; set; }
        public string Name { get; set; }

        public static void NoteSubmit(string notetext, string name, int num)
        { //static methods allow us to access the method without instantiating the class it lives in. now you can call it like models.quiznote.notesubmit(notetext)
            var QuizNote = new QuizNote();

            QuizNote.Name = name;
            QuizNote.NoteText = notetext;
            QuizNote.QuizNumber = num;

            // if(GlobalVariables.QuizNotes == null)
            //     GlobalVariables.QuizNotes = new List<QuizNote>();

            GlobalVariables.QuizNotes.Add(QuizNote);

        }


        public static List<QuizNote> GetAll()
        {
            // if(GlobalVariables.QuizNotes == null)
            //     GlobalVariables.QuizNotes = new List<QuizNote>();

            return GlobalVariables.QuizNotes;
        }


        //function to print out the notes people selected
        public static List<string> Print(string[] notetext)
        {
             List<string> PrintingNotes = new List<string>();    

            //loop through all of the text snippets and send to the controller, which will send to the printpage view
            foreach (var note in notetext)
            {
              PrintingNotes.Add(note);
              System.Console.WriteLine(note);
            }

          //  System.Console.WriteLine(PrintingNotes);

            return PrintingNotes;

        }




// public class PdfResult : PartialViewResult
// {
//     // Setting a FileDownloadName downloads the PDF instead of viewing it
//     public string FileDownloadName { get; set; }

//     public override void ExecuteResult(ControllerContext context)
//     {
//         if (context == null)
//         {
//             throw new ArgumentNullException("context");
//         }

//         // Set the model and data
//         context.Controller.ViewData.Model = Model;
//         ViewData = context.Controller.ViewData;
//         TempData = context.Controller.TempData;


//         // Get the view name
//         if (string.IsNullOrEmpty(ViewName))
//         {
//             ViewName = context.RouteData.GetRequiredString("action");
//         }

//         // Get the view
//         ViewEngineResult viewEngineResult = null;
//         if (View == null)
//         {
//             viewEngineResult = FindView(context);
//             View = viewEngineResult.View;
//         }

//         // Render the view
//         StringBuilder sb = new StringBuilder();
//         using (TextWriter tr = new StringWriter(sb))
//         {
//             ViewContext viewContext = new ViewContext(context, View, ViewData, TempData, tr);
//             View.Render(viewContext, tr);
//         }
//         if (viewEngineResult != null)
//         {
//             viewEngineResult.ViewEngine.ReleaseView(context, View);
//         }

//         // Create a PDF from the rendered view content
//         Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();
//         using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(sb.ToString())))
//         {
//             pdf.BindXML(ms, null);
//         }

//         // Save the PDF to the response stream
//         using(MemoryStream ms = new MemoryStream())
//         {
//             pdf.Save(ms);
//             FileContentResult result = new FileContentResult(ms.ToArray(), "application/pdf")
//             {
//                 FileDownloadName = FileDownloadName
//             };
//             result.ExecuteResult(context);
//         }
//     }
// }



    }
}
