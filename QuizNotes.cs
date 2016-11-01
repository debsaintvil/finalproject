using System.Collections.Generic;
using System;

namespace HW3Site.Models
{
  public class QuizNote
  {
    
       public string NoteText {get; set;} //the text of the quiz note
       public List<Answer> Answers;
    

    public static Question[] Initial()
    {
       Question[] QArray = new Question[3];

        

           return QArray;
            }

  }

   public class Answer 
        {
            //Values
           public string AnswerText {get; set;}
           public bool IsCorrect {get; set;}//each Answer has a bool value, either right or wrong
        }


  
  

  // public static List<Questions> GetAll() //don't know if i need this
  //   {
  //     return GlobalVariables.Questions;
  //   }

}


