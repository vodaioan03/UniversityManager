using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManager
{
    public class Student
    {
        int studentID;
        String studentName;
        public Student(int id, String name) 
        { 
            this.studentID = id;
            this.studentName = name;
        }
    }

    public class Discipline
    {
        int disciplineID;
        String disciplineName;
        public Discipline(int disciplineID, string disciplineName)
        {
            this.disciplineID = disciplineID;
            this.disciplineName = disciplineName;
        }
    }

    public class Grade
    {
        int studentID;
        int disciplineID;
        int gradeValue;
        public Grade(int studentID, int disciplineID, int gradeValue)
        {
            this.studentID = studentID;
            this.disciplineID = disciplineID;
            this.gradeValue = gradeValue;
        }
    }
}
