﻿/*
 * Provide a menu-driven console-based user interface. Implementation details are up to you
    Employ layered architecture and classes
    Have at least 20 procedurally generated items for each domain class in your application at startup (e.g., at least 20 students, 20 disciplines and 20 grades)
    Provide specifications and PyUnit test cases for all non-UI classes and methods for the first functionality
    Implement and use your own exception classes.
    Deadline for maximum grade is week 11.
 * 
 *  Students Register Management
        A faculty stores information about:

        Student: student_id, name
        Discipline: discipline_id, name
        Grade: discipline_id, student_id, grade_value
        Create an application to:

        Manage students and disciplines. The user can add, remove, update, and list both students and disciplines.
        Grade students at a given discipline. Any student may receive one or several grades at any discipline. Deleting a student also removes their grades. Deleting a discipline deletes all grades at that discipline for all students.
        Search for disciplines/students based on ID or name/title. The search must work using case-insensitive, partial string matching, and must return all matching disciplines/students.
        Create statistics:
        All students failing at one or more disciplines (students having an average <5 for a discipline are failing it)
        Students with the best school situation, sorted in descending order of their aggregated average (the average between their average grades per discipline)
        All disciplines at which there is at least one grade, sorted in descending order of the average grade(s) received by all students
 * 
 */
using System;

namespace UniversityManager
{
    public class Program
    {

        static void Main(string[] args)
        {

            uiMenu menu = new uiMenu();
            menu.StartMenu();
        }

    }

}
