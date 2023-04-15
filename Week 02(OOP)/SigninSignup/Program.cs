using SigninSignup.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigninSignup
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrSize = 20;
            User[] u = new User[20];
            int userCount = 1;
            u[0] = new User();
            u[0].username = "hamza123";
            u[0].password = "abcd";
            u[0].roles = "Admin";
            LoadData(ref userCount, u);
            int option = 0; ;
            while (option != 4)
            {
                option = menu();
                if (option == 1)
                {
                    string pass;
                    string name;
                    string role = "Admin";
                    Console.Write("Ënter the username Employe/Customer  : ");
                    name = Console.ReadLine();
                    Console.Write("Enter the passward : ");
                    pass = Console.ReadLine();
                    while (role == "Admin")
                    {

                        Console.Write("Enter the role : ");
                        role = Console.ReadLine();
                        if (role == "Admin")
                        {
                            Console.WriteLine("You cannot signup as an Admin");
                            Console.ReadKey();
                        }

                    }
                   bool isValid =  SignUp(u, ref userCount, name, pass, role, arrSize);
                    if (isValid)
                    {
                        Console.WriteLine("Sign up Successfully");
                        Console.ReadKey();
                    }
                    if (!(isValid))
                    {
                        Console.WriteLine("User already present");
                        Console.ReadKey();
                    }
                }
                if(option == 2)
                {
                    string pass;
                    string name;
                    string role;
                    Console.Write("Ënter the username Employe/Customer  : ");
                    name = Console.ReadLine();
                    Console.Write("Enter the passward : ");
                    pass = Console.ReadLine();
                    role = SignIn(u, userCount, name, pass);
                    if(role == "Admin")
                    {
                        Console.WriteLine("Admin Interface ");
                        Console.ReadKey();
                    }
                    else if(role == "Employe")
                    {
                        Console.WriteLine("Employe Interface ");
                        Console.ReadKey();
                    }
                    else if (role == "Customer")
                    {
                        Console.WriteLine("Customer Interface ");
                        Console.ReadKey();
                    }
                }
            }
        }

        static int menu()
        {
            Console.Clear();
            Console.WriteLine("********************************************************************************************************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                                       PHARMACY    MANAGEMENT    SYSTEM                                               ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("********************************************************************************************************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("1.  SignUp ");
            Console.WriteLine("****************");
            Console.WriteLine("2.  SignIn ");
            Console.WriteLine("****************");
            Console.WriteLine("3.  Exist ");
            Console.WriteLine("****************");
            int option;
            Console.WriteLine("");
            Console.Write("Enter the option : ");
            Console.Write("___");
            option = int.Parse(Console.ReadLine());
            return option;
        }

        static bool SignUp(User[] u, ref int userCount, string name, string pass, string role, int arrSize)
        {
            u[userCount] = new User();
            bool isValid = false;
            for (int i = 0; i < userCount; i++)
            {
                if (u[i].username == name && u[i].password == pass)
                {
                    isValid = true;
                }
            }
            if (isValid == true)
            {
                return false;
            }
            if (userCount < arrSize)
            {
                u[userCount].username = name;
                u[userCount].password = pass;
                u[userCount].roles = role;
                userCount++;
                StoreData(userCount,u);
                isValid = true;
                return isValid;
            }
            else
            {
                return isValid;
            }
        }

        static string SignIn(User[] u, int userCount, string name, string pass)
        {
            for (int i = 0; i < userCount; i++)
            {
                if (u[i].username == name && u[i].password == pass)
                {
                    return u[i].roles;
                }
            }
            return "Undefined";
        }

        static void StoreData(int userCount,User[] u)
        {
            StreamWriter file = new StreamWriter("D:\\2nd semester OOP\\OOP labs\\Week 02(OOP)\\SigninSignup\\Data.txt");
            for (int i = 1; i < userCount; i++)
            {
                file.Write(u[i].username + ",");
                file.Write(u[i].password + ",");
                file.WriteLine(u[i].roles);
            }
            file.Close();

        }

        static void LoadData(ref int userCount,User[] u)
        {
            string path = "D:\\2nd semester OOP\\OOP labs\\Week 02(OOP)\\SigninSignup\\Data.txt";
            StreamReader file = new StreamReader(path);
            if (File.Exists(path))
            {
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    u[userCount] = new User();
                    u[userCount].username = parseData(record, 1);
                    u[userCount].password = parseData(record, 2);
                    u[userCount].roles = parseData(record, 3);
                    userCount++;
                }
                file.Close();
            }
            else
            {
                Console.WriteLine("File doesnot Exists");
            }

        }

        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[i];
                }
            }
            return item;
        }
    }


}
