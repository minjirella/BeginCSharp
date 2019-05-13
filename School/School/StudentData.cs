using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class StudentData
    {
        private static SchoolDBEntities1 CreateContext()
        {
            SchoolDBEntities1 context = new SchoolDBEntities1();
            context.Database.Log = PrintToConsoleWindow;
            return context;

        }
        //public static Student GetStudent(int studentId)
        //{
        //}

        //public static void Update(Student student)
        //{

        //}

        public static int GetCount()
        {
            using(var context = CreateContext())
            {
                return context.Students.Count();
            }
        }

        public static Student GetByPK(int studentID)
        {
            using (var context = CreateContext())
            {
                return context.Students.FirstOrDefault(x => x.StudentID == studentID);
            }
        }

        private static void PrintToConsoleWindow(string log)
        {
            Console.WriteLine(log);
        }

    }
}
