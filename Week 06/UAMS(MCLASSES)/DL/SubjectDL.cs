using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS_MCLASSES_.BL;

namespace UAMS_MCLASSES_.DL
{
    public class SubjectDL
    {
        public static List<Subject> SubjectList = new List<Subject>();


        public static void addSubjectIntoList(Subject s)
        {
            SubjectList.Add(s);
        }
        public static Subject IsSubjectExists(string type)
        {
            foreach (Subject s in SubjectList)
            {
                if (s.type == type)
                {
                    return s;
                }
            }
            return null;
        }
        public static bool readffromfile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string code = splittedRecord[0];
                    string type = splittedRecord[1];
                    int creditHours = int.Parse(splittedRecord[2]);
                    int subjectfees = int.Parse(splittedRecord[3]);
                    string[] splittedRecordForSubject = splittedRecord[3].Split(';');
                    Subject s = new Subject(code, type, creditHours, subjectfees);
                    addSubjectIntoList(s);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }


        }
        public static void storeintofile(string path, Subject s)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(s.code + "," + s.type + "," + s.creditHours + "," + s.subjectFees);
            f.Flush();
            f.Close();

        }



    }
}
