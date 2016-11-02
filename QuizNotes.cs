using System.Collections.Generic;
using System;

namespace FinalProject.Models
{
  public class QuizNote
  {
       public string NoteText {get; set;} //the text of the quiz note
   
       public int QuizNumber {get; set;}
       public string Name {get; set;}

        public static void NoteSubmit(string notetext, string name, int num )
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

  }
  

 

}


