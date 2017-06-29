using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();

            book.NameChanged += OnNameChanged;
            
            


            book.Name = "Balach's Grade Book";
            book.Name = "Grade Book";

            book.Name = null;
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", (int)stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);

        }
        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade Book changing name from {args.ExistingName} to {args.NewName}");
        }
       
        static void WriteResult(string descprition, int result)
        {
            Console.WriteLine(descprition + ": " + result);
        }
        static void WriteResult(string descprition, float result)
            {
                Console.WriteLine($"{descprition}: {result:f2}", descprition, result);
            }
    }
}
