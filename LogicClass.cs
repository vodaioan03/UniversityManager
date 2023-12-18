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
        classREPO studentRepo;
        public StudentLogic(uiMenu menu)
        {
            this.menu = menu;
            this.studentRepo = new classREPO();
        }

        public void AddStudent(int studentID, String studentName)
        {
            Console.WriteLine("inaddStudent");
            if (this.studentRepo.getRepo().ContainsKey(studentID))
            {
                Console.WriteLine($"[Student Add] Student {studentID} is already added!");
                return;
            }
            Student newStudent = new Student(studentID, studentName);
            this.studentRepo.addValueInData(newStudent);
        }

        public void RemoveStudent(int studentID)
        {
            Console.WriteLine("in Remove Student");
            if (this.studentRepo.getRepo().ContainsKey(studentID))
            {
                this.studentRepo.removeValueInData(studentID);
            }
            else
            {
                Console.WriteLine("[Student Remove] Student isn't in database.");
                return;
            }
            foreach (idObject student in this.studentRepo.getRepo().Values)
            {
                Console.WriteLine(student.ToString());
            }
        }
        public void ModifyStudent(int studentID,string NewStudentName)
        {
            Console.WriteLine("In Modify Student");
            
        }
        public void ListStudent()
        {
            Console.WriteLine("In list Student");
        }
        public bool VerifyIfExistStudent(int studentID)
        {
            return this.studentRepo.getRepo().ContainsKey(studentID);
        }
    }

    public class DisciplineLogic
    {
        uiMenu menu;
        classREPO disciplineRepo;
        public DisciplineLogic(uiMenu menu) 
        {
            this.menu = menu;
            this.disciplineRepo = new classREPO();
        }

        public void AddDiscipline(int disciplineID, string disciplineName)
        {
            Console.WriteLine("In Add Discipline");
            if (this.disciplineRepo.getRepo().ContainsKey(disciplineID))
            {
                Console.WriteLine($"[Discipline Add] Discipline {disciplineName} already exists in database!");
                return;
            }
            Discipline newDiscipline = new Discipline(disciplineID, disciplineName);
            this.disciplineRepo.addValueInData(newDiscipline);
        }

        public void RemoveDiscipline(int disciplineID)
        {
            Console.WriteLine("In remove Discipline");
            if (!this.disciplineRepo.getRepo().ContainsKey(disciplineID))
            {
                Console.WriteLine($"[Discipline Remove] Discipline {disciplineID} isn't in database!");
                return;
            }
            this.disciplineRepo.removeValueInData(disciplineID);
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
        classREPO gradeRepo;
        public GradeLogic(uiMenu menu) 
        {
            this.menu = menu;
            this.gradeRepo = new classREPO();
        }

        public void AddGrade()
        {

        }
    }
}
