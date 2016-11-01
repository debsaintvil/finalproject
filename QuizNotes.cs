using System.Collections.Generic;
using System;

namespace FinalProject.Models
{
  public class QuizNote
  {
       public string NoteText {get; set;} //the text of the quiz note
   
       public int QuizNumber {get; set;}
       public string Name {get; set;}

        public static List<QuizNote> GetAll() 
          {
            return GlobalVariables.QuizNotes;
          }

  }
  

 

}


