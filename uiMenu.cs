using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManager
{
    public class uiMenu
    {
        inputMenu inputmenu;
        public bool programRunning = false;

        public uiMenu() 
        {
            this.programRunning = true;
            this.inputmenu = new inputMenu(this);
        }

        public void StartMenu()
        {
            while (programRunning)
            {
                mainMenu();
                MenuOption();
            }
        }

        public void MenuOption()
        {
            try
            {
                inputmenu.inputOption();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Input option wrong! Type an integer number.");
            }
        }

        public void mainMenu()
        {
            Console.WriteLine(" == Menu University Management == ");
            Console.WriteLine("1. Manage Students and Disciplines");
            Console.WriteLine("2. Add Grade");
            Console.WriteLine("3. Search Discipline");
            Console.WriteLine("4. Search Student");
            Console.WriteLine("5. Create Statistics");
            Console.WriteLine("6. Exit");
        }

        public void manageMenu()
        {
            Console.WriteLine(" == Menu Manage Students and Disciplines ==");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Discipline");
            Console.WriteLine("3. Delete Student");
            Console.WriteLine("4. Delete Discipline");
            Console.WriteLine("5. Update Student");
            Console.WriteLine("6. Update Discipline");
            Console.WriteLine("7. Show list with students.");
            Console.WriteLine("8. Show list with disciplines");
            Console.WriteLine("9. Back to Main Menu");
            Console.WriteLine("10. Exit");
        }

        public void StudentMenu()
        {
            Console.WriteLine(" == Student Menu == ");
            Console.WriteLine("1. Student ID");
            Console.WriteLine("2. Student Name");
        }

    }

    public class inputMenu
    {
        uiMenu menu;
        OptionLogic logicoption;
        int actualmenu;
        public inputMenu(uiMenu menu)
        {
            this.logicoption = new OptionLogic(menu,this);
            this.menu = menu;
            this.actualmenu = 0;
        }

        public void inputOption()
        {
            Console.Write("Type option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            this.actualmenu++;
            try
            {
                this.logicoption.ConvertOption(option, this.actualmenu);
            }
            catch (Exception ex)
            {

            }
            this.actualmenu--;
        }

        public void inputStudent()
        {
            int studentID = Convert.ToInt32(Console.ReadLine());
            String studentName = Console.ReadLine();
        }
    }

    public class OptionLogic
    {
        StudentLogic student;
        DisciplineLogic discipline;
        GradeLogic grade;
        Action[][] actionsMenu;
        uiMenu menu;
        inputMenu inputmenu;

        public OptionLogic(uiMenu menu, inputMenu imenu)
        {
            this.actionsMenu = new Action[][] { new Action[] {() => ManageMenuLogic(), () => AddGrade(), () => SearchDiscipline(), () => SearchStudent(), () => CreateStatistic(), () => ExitMenu() },
                                                new Action[] {() => AddStudent(), () => AddDiscipline(), () => RemoveStudent(), () => RemoveDiscipline(), () => ModifyStudent(), () => ModifyDiscipline(), () => ListStudent(), () => ListDiscipline(), () => BackMenu(), () => ExitMenu() } };
            this.inputmenu = imenu;
            this.menu = menu;
            this.discipline = new DisciplineLogic();
            this.student = new StudentLogic();
            this.grade = new GradeLogic();
        }

        public void ConvertOption(int option, int actualMenu)
        {
            Console.WriteLine("In option convert");
            option--;
            actualMenu--;
            if (actualMenu < this.actionsMenu.Length && option < this.actionsMenu[actualMenu].Length)
            {
                this.actionsMenu[actualMenu][option]();
            }
            else
            { }
        }

        public void ManageMenuLogic()
        {
            this.menu.manageMenu();
            this.menu.MenuOption();
        }

        public void AddGrade()
        {

        }

        public void SearchDiscipline()
        {

        }

        public void SearchStudent()
        {

        }
        public void CreateStatistic()
        {

        }
        public void ExitMenu()
        {
            Console.WriteLine("Exiting...");
            this.menu.programRunning = false;
        }

        //FOR Manage Menu

        public void AddStudent()
        {
            Console.WriteLine("inaddStudent");
            this.menu.StudentMenu();
            try
            {
                this.inputmenu.inputStudent();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Input student wrong! Type a valid input.");
            }
            
        }
        public void AddDiscipline()
        {
            Console.WriteLine("In Add Discipline");
        }
        public void RemoveStudent()
        {
            Console.WriteLine("in Remove Student");
        }
        public void RemoveDiscipline()
        {
            Console.WriteLine("In remove Discipline");
        }
        public void ModifyStudent()
        {
            Console.WriteLine("In Modify Student");
        }
        public void ModifyDiscipline()
        {
            Console.WriteLine("In Modify Discipline");
        }
        public void ListStudent()
        {
            Console.WriteLine("In list Student");
        }
        public void ListDiscipline()
        {
            Console.WriteLine("In List discipline");
        }
        public void BackMenu()  { }

    }
}
