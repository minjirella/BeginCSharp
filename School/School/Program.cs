using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SchoolDBEntities1();
            context.Database.Log = PrintToDebugWindow;

            var students = context.Students.GroupBy(s => s.StandardId);

            foreach (var groupItem in students)
            {
                Console.WriteLine(groupItem.Key);

                foreach (var stud in groupItem)
                {
                    Console.WriteLine(stud.StudentID);
                }
            }
        }

        private static void PrintToDebugWindow(string log)
        {
            Debug.WriteLine(log);
        }


    }
}
