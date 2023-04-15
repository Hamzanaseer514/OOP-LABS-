using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn___SignUp_menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            int userCount = 1;
            int arrsize = 15;
            string[] username = new string[15];
            string[] passwards= new string[15];
            string[] roles= new string[15];
            username[0] = "hamza123";
            passwards[0] = "abcd";
            roles[0] = "Admin";
            LoadData(ref userCount, username, passwards, roles);
            int option = 0;
            // Menu();
            while (option != 3)
            {
                Console.Clear();
                option = Menu();
                if (option == 1)
                {

                    string password;
                    string name;
                    string role = "Admin";

                    Console.Write("Enter the User name : ");
                    name = Console.ReadLine();

                    Console.Write("Enter the passward : ");
                    password = Console.ReadLine();
                    while (role == "Admin")
                    {
                        Console.Write("Enter the role : ");
                        role = Console.ReadLine();
                        if (role == "Admin")
                        {
                            Console.WriteLine("You cannot signin as an Admin");
                            Console.ReadKey();
                        }

                    }
                    bool isValid = signup(name, password, role, username, ref index, ref userCount, passwards, ref arrsize, roles);
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


                if (option == 2)
                {
                    string password;
                    string name;
                    string role;
       

                    Console.Write("Enter the User name : ");
                    name = Console.ReadLine();

                    Console.Write("Enter the passward : ");
                    password = Console.ReadLine();

                    role = Signin(name, password,userCount, username, passwards, roles);

                    // storeData();
                    if (role == "Admin")
                    {
                        Console.WriteLine("ja var para");
                        Console.ReadKey();
                    }
                    else if (role == "Employe")
                    {

                    }
                    else if (role == "Customer")
                    {

                    }
                    else if (role == "Undefined")
                    {

                    }

                }
            }
       
        }
         static int Menu()
        {
            int option;
            Console.WriteLine("1.  SignUp");
            Console.WriteLine("2.  SignIn");
            Console.WriteLine("3.  Exit");
            Console.WriteLine("Enter the option : ");
            option = int.Parse(Console.ReadLine());
            return option;
        }

       static bool signup(string name, string password, string role, string[] username, ref int index, ref int userCount, string[] passwards, ref int arrsize,string[] roles)
        {
            bool isPresent = false;

            for (int i = 0; i < userCount; i++)
            {
                if (username[i] == name && passwards[i] == password)
                {
                    isPresent = true;
                    break;
                }
            }
            if (isPresent == true)
            {
                return false;

             //   Console.WriteLine("User Already exit! please Enter a new one....");

            }
            else if (userCount < arrsize)
            {
                username[userCount] = name;
                passwards[userCount] = password;
                roles[userCount] = role;
                userCount++;
                StoreData(userCount, username, passwards, roles);
                
                return true;
            }
            else
            {
                return false;
            }
        }

      static string Signin(string name,string password,int userCount,string[] username,string[] passwards,string[] roles)
        {
            for (int index = 0; index < userCount; index++)
            {
              //  storeData();
                if (username[index] == name && passwards[index] == password)
                {
                    return roles[index];
                }
            }

            return "Undefined";
        }

        static void StoreData(int userCount, string[] username, string[] passwards, string[] roles)
        {
          StreamWriter file = new StreamWriter("D:\\2nd semester OOP\\OOP labs\\Week 01\\SignIn & SignUp menu\\Data.txt");
            for(int i = 1;i < userCount;i++)
            {
                file.Write(username[i] + ",");
                file.Write(passwards[i]+ ",");
                file.WriteLine(roles[i]);
            }
            file.Close();
          
        }  
        
        static void LoadData(ref int userCount, string[] username, string[] passwards, string[] roles)
        {
            string path = "D:\\2nd semester OOP\\OOP labs\\Week 01\\SignIn & SignUp menu\\Data.txt";
            StreamReader file = new StreamReader(path);
           if(File.Exists(path))
            {
                string record;
                while((record  = file.ReadLine()) != null)
                {
                    username[userCount] = parseData(record, 1);
                    passwards[userCount] = parseData(record, 2);
                    roles[userCount] = parseData(record, 3);
                    userCount++;
                }
               file.Close();
            }
            else
            {
                Console.WriteLine("File doesnot Exists");
            }
          
        }

        static string parseData(string record,int field)
        {
            int comma = 1;
            string item = ""; 
            for(int i = 0;i < record.Length; i++)
            {
                if(record[i] == ',')
                {
                    comma++;
                }
                else if(comma == field)
                {
                    item = item + record[i];
                }
            }
            return item;
        }
    }
}


    

       