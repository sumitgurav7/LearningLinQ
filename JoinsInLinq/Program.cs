using System;
using System.Collections.Generic;
using System.Linq;

namespace JoinsInLinq
{
    class Program
    {
        List<Student> students = new List<Student>();
        List<Department> departments = new List<Department>();
        IEnumerable<joinedLists> joinedList;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.InitializeLists();
            program.joinTheseLists();
            program.departmentPopulation();


            Console.ReadKey();
        }

        private void departmentPopulation()
        {
            IEnumerable<string> mechCount = from student in joinedList
                                            where student.DeptId == 1
                                            select student.DeptName;
            Console.WriteLine(mechCount.ElementAt(0) + "  " + mechCount.Count());

            IEnumerable<string> eleCount = from student in joinedList
                                            where student.DeptId == 2
                                            select student.DeptName;
            Console.WriteLine(eleCount.ElementAt(0) + "  " + eleCount.Count());

            IEnumerable<string> cseCount = from student in joinedList
                                            where student.DeptId == 3
                                            select student.DeptName;
            Console.WriteLine(cseCount.ElementAt(0) +"  "+ cseCount.Count());
        }

        private void joinTheseLists()
        {
            

            joinedList = from student in students
                         join department in departments
                         on student.Department equals department.DeptId
                         select new joinedLists{ rollNo= student.rollNo, Name = student.Name, DeptName = department.DeptName, DeptId= department.DeptId };
            foreach(joinedLists obj in joinedList)
            {
                Console.WriteLine(obj);
            }
        }

        private void InitializeLists()
        {
            students.Add(new Student(1, "prashob", 2));
            students.Add(new Student(2, "Vishal", 3));
            students.Add(new Student(3, "Sumit", 1));
            students.Add(new Student(4, "Swetha", 3));
            students.Add(new Student(5, "Sudha", 3));
            students.Add(new Student(6, "Tejas", 2));
            students.Add(new Student(7, "Vamasi", 2));
            students.Add(new Student(8, "shubham", 3));
            students.Add(new Student(9, "vidya", 3));



            departments.Add(new Department(1, "Mechanical Engineering"));
            departments.Add(new Department(2, "Electronic, Electrical Engineering"));
            departments.Add(new Department(3, "Computer Science and Engineering"));
        }
    }
}
