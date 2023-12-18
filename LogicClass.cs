using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManager
{
    public class StudentLogic
    {
        uiMenu menu;
        public StudentLogic(uiMenu menu)
        {
            this.menu = menu;
        }

        public void AddStudent(int studentID, String studentName)
        {
            Console.WriteLine("inaddStudent");
            Student newStudent = new Student(studentID, studentName);
        }

        public void RemoveStudent()
        {
            Console.WriteLine("in Remove Student");
        }
        public void ModifyStudent()
        {
            Console.WriteLine("In Modify Student");
        }
        public void ListStudent()
        {
            Console.WriteLine("In list Student");
        }
    }

    public class DisciplineLogic
    {
        uiMenu menu;
        public DisciplineLogic(uiMenu menu) 
        {
            this.menu = menu;
        }

        public void AddDiscipline()
        {
            Console.WriteLine("In Add Discipline");
           
        }

        public void RemoveDiscipline()
        {
            Console.WriteLine("In remove Discipline");
        }
        public void ModifyDiscipline()
        {
            Console.WriteLine("In Modify Discipline");
        }
        public void ListDiscipline()
        {
            Console.WriteLine("In List discipline");
        }
    }

    public class GradeLogic
    {
        uiMenu menu;
        public GradeLogic(uiMenu menu) 
        {
            this.menu = menu;
        }

        public void AddGrade()
        {

        }
    }
}
