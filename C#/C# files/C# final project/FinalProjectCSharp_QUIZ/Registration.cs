using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectCSharp_QUIZ
{
    public class Menus
    {
        struct ValueStruct
        {
            public string Password;
            public DateTime DateOfBirthday; 
        }
        private static Dictionary<string, ValueStruct> people = new Dictionary<string, ValueStruct>();
        // First menu
        public void RegistrationOrLoginMenu()
        {
             
            Console.WriteLine("1. Login\n" +
                              "2. SignUp\n" + 
                              "--->>>\t"); 
            int ChoiceOp = Int32.Parse(Console.ReadLine());
            switch (ChoiceOp)
            {
                case 1:
                    System.Console.Clear();
                    Login();
                    break;
                case 2:
                    System.Console.Clear();
                    SignUp();
                    break; 
                default:
                    System.Console.Clear();
                    Console.WriteLine("Error! Enter 1 or 2 !");
                    // requse
                    RegistrationOrLoginMenu();
                    break;
            } 
        } 
       
        // Main menu
        public void MainMenu()
        {
            Account account = new Account();
            Console.WriteLine("1. Start quiz\n" +
                              "2. Watch last quizes\n" +
                              "3. Top-20\n" +
                              "4. Change Settings\n" +
                              "5. Exit\n" +
                              "--->>>\t");
            int ChoiceOp = Int32.Parse(Console.ReadLine());
            switch (ChoiceOp)
            {
                case 1:
                    System.Console.Clear();
                    StartQuiz();
                    break;
                case 2:
                    System.Console.Clear();
                    account.WatchHistory();
                    break;
                case 3:
                    System.Console.Clear();
                    Console.WriteLine("----<_ Watch top 20 _>----");
                    break;
                case 4:
                    System.Console.Clear();
                    account.ChangeSettings();
                    break;
                case 5:
                    System.Console.Clear();
                    Console.WriteLine("Exit");
                    
                    break;

                default:
                    System.Console.Clear();
                    Console.WriteLine("Error! Enter 1 or 2 !");
                    // requse
                    RegistrationOrLoginMenu();
                    break;
            }
        }


        // Top-20
        public static void WatchTop_20Players()
        {
            Console.WriteLine("top-20");
        }




        // Start Quiz
        public void StartQuiz()
        {
            Console.WriteLine("Quiz");
        }

        // Login
        public void Login()
        { 
            Console.WriteLine("Enter login --->\n");
            string login = Console.ReadLine();

            if (people.ContainsKey(login))
            {
                Console.WriteLine("Enter password --->\n");
                string password;
                int flag = 0;
                do
                {
                    if (flag > 0) Console.WriteLine("Error! Wrong password,try again!!!");
                    password = Console.ReadLine();
                    flag++;
                } while (password != people[login].Password);
                Console.WriteLine("GOOD");

            }
            else {
                System.Console.Clear();
                Console.WriteLine("We don\'t have user with this login!\nPlease,get registration");
                RegistrationOrLoginMenu();
            }
        }

        // SignUp
        public void SignUp()
        {
            string login;
            do
            {
                
                Console.WriteLine("Create login: " +
                    "\n( low than 10 and more 0 elements! )");
                login = Console.ReadLine();   
                
            } while (people.ContainsKey(login));

            // Create struct of password and date
            ValueStruct val = new(); 

            // Set password
            Console.WriteLine("Create password: ");
            string password;
            int flag = 0;
            do
            {
                if (flag > 0) Console.WriteLine("Error! Your password have to be more than 3 and less than 13 simbols!!!");
                password = Console.ReadLine();
                flag++;
            } while (password.Length < 3 && password.Length > 13);
            val.Password = password;


            // Set day,month,year
            Console.WriteLine("Enter day of birthday:: ");
            int day = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter month of birthday:: ");
            int month = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter year of birthday:: ");
            int year = Int32.Parse(Console.ReadLine());
            
            DateTime date = new(year,month,day);

            // Set date
            val.DateOfBirthday = date;

            // Adding element of dictionary
            Console.WriteLine(val.DateOfBirthday);
            Console.WriteLine(val.Password);
            Console.WriteLine(login);
            people.Add(login, val);
            System.Console.Clear();
            Console.WriteLine("You succesfuly registrd! Good job! \nNow ,please,login:");
            Login();
        }
    }
    
}
