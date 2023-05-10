using SignUpSignIn.BL;
using SignUpSignIn.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUpSignIn.UL
{
    public class MUserUI
    {
        public static MUser signUp()
        {
            Console.Write("Enter the user name : ");
            string name = Console.ReadLine();
            Console.Write("Enter the password : ");
            string password = Console.ReadLine();
            Console.Write("Enter the Role : ");
            string role = Console.ReadLine();
            MUser u = new MUser(name, password, role);
            return u;
        }
        public static string SignIn()
        {
            string role = "";
            Console.Write("Enter the user name : ");
            string name = Console.ReadLine();
            Console.Write("Enter the password : ");
            string password = Console.ReadLine();
            for (int i = 0; i < MUserCrud.user.Count; i++)
            {
                if (name == MUserCrud.user[i].username && password == MUserCrud.user[i].password)
                {
                    role = MUserCrud.user[i].role;
                    break;
                }
                else
                {
                    role =  "Undefined";
                }
            }
            return role;
        }
        public static void AddUserIntoList(MUser u)
        {
            MUserCrud.user.Add(u);
        }

    }
}
