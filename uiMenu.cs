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
            Console.WriteLine("\n == Menu University Management == ");
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
            Console.WriteLine("\n == Menu Manage Students and Disciplines ==");
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
        public void AddGradeMenu()
        {
            Console.WriteLine(" == Grade Menu ==");
        }

        public void SearchStudent()
        {
            Console.WriteLine(" == Student Menu ==");
        }

        public void SearchDiscipline()
        {
            Console.WriteLine(" == Discipline Menu ==");
        }

        public void CreateStatistics()
        {
            Console.WriteLine(" == Statistics Menu ==");
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

        public void RemoveStudent()
        {
            Console.WriteLine(" == Student Menu == ");
            try
            {
                this.inputmenu.inputRemoveStudent();
            }
            catch (Exception)
            {
                Console.WriteLine("[Input Student Menu] Wrong option in Main Menu!");
            }
        }

        public void RemoveDiscipline()
        {
            Console.WriteLine(" == Discipline Menu == ");
            try
            {
                this.inputmenu.inputRemoveDiscipline();
            }
            catch (Exception)
            {
                Console.WriteLine("[Input Discipline Menu] Wrong option in Main Menu!");
            }
        }

        public void ModifyStudent()
        {
            Console.WriteLine(" == Student Menu == ");
            try
            {
                this.inputmenu.inputModifyStudent();
            }
            catch (Exception)
            {
                Console.WriteLine("[Input Student Menu] Wrong option in Main Menu!");
            }
        }
        public void ModifyDiscipline()
        {
            Console.WriteLine(" == Discipline Menu == ");
            try
            {
                this.inputmenu.inputModifyDiscipline();
            }
            catch (Exception)
            {
                Console.WriteLine("[Input Discipline Menu] Wrong option in Main Menu!");
            }
        }
        public void ListStudent()
        {
            Console.WriteLine(" == Student Menu ==");
        }
        public void ListDiscipline()
        {
            Console.WriteLine(" == Discipline Menu ==");
        }

        public void ExitMenu()
        {
            Console.WriteLine("Exiting...");
            this.programRunning = false;
        }

    }

    public class inputMenu
    {
        uiMenu menu;
        StudentLogic studentLogic;
        DisciplineLogic disciplineLogic;
        GradeLogic gradeLogic;
 
        public inputMenu(uiMenu menu)
        {
            this.menu = menu;
            this.disciplineLogic = new DisciplineLogic(this.menu);
            this.studentLogic = new StudentLogic(this.menu);
            this.gradeLogic = new GradeLogic(this.menu);
            
        }

        public void inputOptionMain()
        {
            Console.Write("[Main Menu]Choose option :");
            int optionMainMenu = Convert.ToInt32(Console.ReadLine()) - 1;
            Action[] actionMenuMain = new Action[] {() => this.menu.manageMenu(), () => this.menu.AddGradeMenu(), ()  => this.menu.SearchDiscipline(), () => this.menu.SearchStudent(), () => this.menu.CreateStatistics(), () => this.menu.ExitMenu()};
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
            Action[] actionManageMenu = new Action[] { () => this.menu.StudentMenu(), () => this.menu.DisciplineMenu(), () => this.menu.RemoveStudent(), () => this.menu.RemoveDiscipline(), () => this.menu.ModifyStudent(), () => this.menu.ModifyDiscipline(), () => this.menu.ListStudent(), () => this.menu.ListDiscipline(), () => { }, () => this.menu.ExitMenu() };
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
            this.studentLogic.AddStudent(studentID, studentName);
        }

        public void inputDiscipline()
        {
            Console.Write("[Discipline Menu] Type Discipline ID(needs to be unique) :");
            int studentID = Convert.ToInt32(Console.ReadLine());
            Console.Write("[Discipline Menu] Type Discipline Name : ");
            String studentName = Console.ReadLine();
            Console.WriteLine("Discipline Added to the list!");
        }

        public void inputRemoveStudent()
        {
            Console.Write(" Type ID for delete student: ");
            int studentID = Convert.ToInt32(Console.ReadLine());

        }

        public void inputRemoveDiscipline()
        {
            Console.Write(" Type ID for delete discipline: ");
            int studentID = Convert.ToInt32(Console.ReadLine());

        }

        public void inputModifyStudent()
        {
            Console.Write(" Type ID for modify student: ");
            int studentID = Convert.ToInt32(Console.ReadLine());

        }

        public void inputModifyDiscipline()
        {
            Console.Write(" Type ID for modify discipline: ");
            int studentID = Convert.ToInt32(Console.ReadLine());

        }
    }
}
