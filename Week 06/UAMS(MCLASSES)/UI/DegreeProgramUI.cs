using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS_MCLASSES_.BL;
using UAMS_MCLASSES_.DL;

namespace UAMS_MCLASSES_.UI
{
    public class DegreeProgramUI
    {
        public static DegreeProgram takeInputForDegree()
        {
            string degreeName;
            float duration;
            int seats;
            Console.Write("Enter the degree name : ");
            degreeName = Console.ReadLine();
            Console.WriteLine("Enter the degree duration : ");
            duration = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the seats for the degree : ");
            seats = int.Parse(Console.ReadLine());


            DegreeProgram degProg = new DegreeProgram(degreeName, duration, seats);
            Console.WriteLine("Enter how many subjects you want to enter : ");
            int count = int.Parse(Console.ReadLine());

            for(int i = 0;i < count;i++)
            {
                Subject s = SubjectUI.takeInputForSubject();
                if(degProg.AddSubject(s))
                {
                    if(!(SubjectDL.SubjectList.Contains(s)))
                    {
                        SubjectDL.addSubjectIntoList(s);
                        SubjectDL.storeintofile("Subject.txt", s);
                    }
                    Console.WriteLine("Subject Added");
                }
                else
                {
                    Console.WriteLine("Subject not Added ");
                    Console.WriteLine("20 credit hours limit exceeded");
                }
            }
            return degProg;
        }

        public static void viewDegreeProgram()
        {
            foreach(DegreeProgram dp in DegreeprogramDL.programList)
            {
                Console.WriteLine(dp.degreeName);
            }
        }
    }
}
