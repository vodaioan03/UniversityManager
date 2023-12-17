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
            try
            {
                this.inputmenu.inputOptionMain();
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong option in Main Menu!");
            }
            
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
            try
            {
                this.inputmenu.inputOptionManage();
            }
            catch (Exception)
            {
                Console.WriteLine("[Manage Menu] Wrong option in Main Menu!");
            }
        }

        public void StudentMenu()
        {
            Console.WriteLine(" == Student Menu == ");
            Console.WriteLine("     Type data for new student!");
            try
            {
                this.inputmenu.inputStudent();
            }
            catch (Exception)
            {
                Console.WriteLine("[Input Student Menu] Wrong option in Main Menu!");
            }
        }

        public void DisciplineMenu()
        {
            Console.WriteLine(" == Discipline Menu == ");
            Console.WriteLine("     Type data for new discipline!");
            try
            {
                this.inputmenu.inputDiscipline();
            }
            catch (Exception)
            {
                Console.WriteLine("[Input Discipline Menu] Wrong option in Main Menu!");
            }
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

        public void inputOptionMain()
        {
            Console.Write("[Main Menu]Choose option :");
            int optionMainMenu = Convert.ToInt32(Console.ReadLine()) - 1;
            Action[] actionMenuMain = new Action[] {() => this.logicoption.ManageMenuLogic(), () => this.logicoption.AddGrade(), ()  => this.logicoption.SearchDiscipline(), () => this.logicoption.SearchStudent(), () => this.logicoption.CreateStatistic(), () => this.logicoption.ExitMenu()};
            if (optionMainMenu < actionMenuMain.Length) 
            {
                actionMenuMain[optionMainMenu]();
            }
            else
            {
                throw new Exception("[Main Menu] Option menu is invalid!");
            }
        }

        public void inputOptionManage()
        {
            Console.Write("[Manage Menu] Type option: ");
            int optionManageMenu = Convert.ToInt32(Console.ReadLine()) -1 ;
            Action[] actionManageMenu = new Action[] { () => this.logicoption.AddStudent(), () => this.logicoption.AddDiscipline(), () => this.logicoption.RemoveStudent(), () => this.logicoption.RemoveDiscipline(), () => this.logicoption.ModifyStudent(), () => this.logicoption.ModifyDiscipline(), () => this.logicoption.ListStudent(), () => this.logicoption.ListDiscipline(), () => this.logicoption.BackMenu(), () => this.logicoption.ExitMenu() };
            if (optionManageMenu < actionManageMenu.Length)
            { actionManageMenu[optionManageMenu](); }
            else { throw new Exception("[Manage Menu] Invalid Option! Type another one!"); }
        }

        public void inputStudent()
        {
            Console.Write("[Student Menu] Type Student ID(needs to be unique) :");
            int studentID = Convert.ToInt32(Console.ReadLine());
            Console.Write("[Student Menu] Type Student Name : ");
            String studentName = Console.ReadLine();
            Console.WriteLine("Student Added to the list!");
        }

        public void inputDiscipline()
        {
            Console.Write("[Discipline Menu] Type Discipline ID(needs to be unique) :");
            int studentID = Convert.ToInt32(Console.ReadLine());
            Console.Write("[Discipline Menu] Type Discipline Name : ");
            String studentName = Console.ReadLine();
            Console.WriteLine("Discipline Added to the list!");
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
           this.inputmenu = imenu;
            this.menu = menu;
            this.discipline = new DisciplineLogic();
            this.student = new StudentLogic();
            this.grade = new GradeLogic();
        }

        public void ManageMenuLogic()
        {
            this.menu.manageMenu();
        }

        public void AddGrade()
        {
            this.menu.StudentMenu();
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
            
        }
        public void AddDiscipline()
        {
            Console.WriteLine("In Add Discipline");
            this.menu.DisciplineMenu();
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
