using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS_MCLASSES_.BL;

namespace UAMS_MCLASSES_.DL
{
	public class DegreeprogramDL
	{
		public static List<DegreeProgram> programList = new List<DegreeProgram>();
		public static void addIntoDegreeList(DegreeProgram d)
		{
			programList.Add(d);
		}
		public static DegreeProgram isDegreeExists(string degreeName)
		{
			foreach(DegreeProgram d in programList)

				{
				if (d.degreeName == degreeName)
				{
					return d;
				}
			
			}
			return null;
		}
		public static void storeintofile(string path, DegreeProgram d)
        {
			StreamWriter f = new StreamWriter(path, true);
			string SubjectNames = "";
			for(int i = 0; i < d.subjects.Count-1;i++)
            {
				SubjectNames = SubjectNames + d.subjects[i].type + ";";
            }
			SubjectNames = SubjectNames + d.subjects[d.subjects.Count - 1].type;
			f.WriteLine(d.degreeName + "," + d.duration + "," + d.seats + "," + SubjectNames);
			f.Flush();
			f.Close();
        }
		public static bool readffromfile(string path)
        {
			StreamReader f = new StreamReader(path);
			string record;
			if(File.Exists(path))
            {
				while((record = f.ReadLine()) != null)
                {
					string[] splittedRecord = record.Split(',');
					string degreeName = splittedRecord[0];
					float degreeDuration = float.Parse(splittedRecord[1]);
					int seats = int.Parse(splittedRecord[2]);
					string[] splittedRecordForSubject = splittedRecord[3].Split(';');
					DegreeProgram d = new DegreeProgram(degreeName, degreeDuration, seats);
					for(int i = 0;i < splittedRecordForSubject.Length;i++)
                    {
						Subject s = SubjectDL.IsSubjectExists(splittedRecordForSubject[i]);
						if(s != null)
                        {
							d.AddSubject(s);
                        }
                    }
					addIntoDegreeList(d);
                }
				f.Close();
				return true;
            }
            else
            {
				return false;
            }


		}
	}
}
