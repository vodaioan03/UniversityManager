using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManager
{
    public class idObject
    {
        int _id;
        public idObject(int _id) 
        {
            this._id = _id; 
        }

        public int getID()
        {
            return this._id;
        }
    }
    public class Student : idObject
    {
        int studentID;
        String studentName;
        public Student(int id, String name) : base(id) 
        { 

            this.studentID = id;
            this.studentName = name;
        }

        public string getStudentName() {
            return this.studentName;
        }

        public override string ToString()
        {
            return $"Student ID: {this.studentID} | Name: {this.studentName}";
        }
    }

    public class Discipline : idObject
    {
        int disciplineID;
        String disciplineName;
        public Discipline(int disciplineID, string disciplineName) : base(disciplineID)
        {
            this.disciplineID = disciplineID;
            this.disciplineName = disciplineName;
        }

        public override String ToString() {
            return $"Discipline ID : {this.disciplineID} | Name: {this.disciplineName}";
        }
    }

    public class Grade : idObject
    {
        int studentID;
        int disciplineID;
        int gradeValue;
        int gradeID;
        public Grade(int gradeID, int studentID, int disciplineID, int gradeValue) : base(gradeID) 
        {
            this.gradeID = gradeID;
            this.studentID = studentID;
            this.disciplineID = disciplineID;
            this.gradeValue = gradeValue;
        }

        public override string ToString()
        {
            return $"Grade ID: {this.gradeID} | Student ID {this.studentID} | Discipline ID {this.disciplineID} | Grade Value {this.gradeValue}";
        }
    }
}
