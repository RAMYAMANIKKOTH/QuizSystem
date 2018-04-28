using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************");
            Console.WriteLine("**Welcome to Quiz App**");
            while (true)
            {
                Console.WriteLine("0. Quit");
                Console.WriteLine("1. Create a new student account");
                Console.Write("Please select an option from above: ");
                var option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        Console.WriteLine("Thank you for visiting!");
                        return;
                    case "1":
                        Console.Write("Email Address: ");
                        var emailAddress = Console.ReadLine();
                        Console.Write("Student Name: ");
                        var StudentName = Console.ReadLine();
                        Console.WriteLine("Subjecct: ");
                        var Subjects = Enum.GetNames(typeof(Subject));
                        for (var i = 0; i < Subjects.Length; i++)
                        {
                            Console.WriteLine($"{i}. {Subjects[i]}");
                        }
                        Console.Write("Your choice: ");
                        var subject = (Subject)Enum.Parse(typeof(Subject), Console.ReadLine());

                           

                        var account = QuizApp.CreateAccount(StudentName, emailAddress, subject);
                                              
                        break;




                }
            }
        }
    }
}
