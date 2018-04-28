
using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoice
{
    static class QuizApp {

        private static QuizModel db = new QuizModel();

        private static List<Student> students= new List<Student>();
     /// <summary>
    /// 
    /// </summary>
    /// <param name="StudentName"></param>
    /// <param name="emailAddress"></param>
    /// <param name="subject"></param>
    /// <param name="grade"></param>
    /// <returns></returns>
        public static Student CreateAccount(string StudentName, string emailAddress, Subject subject)
        {
            var Student = new Student()
            {
                studentName = StudentName,
                emailAddress = emailAddress,
                
                Subjectname = subject
            };

            db.students.Add(Student);
            db.SaveChanges();


            return Student;

        }
        

    }
}
