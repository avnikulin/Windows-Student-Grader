using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace project6
{
    public class StudentDB
    {
        private const string dir = @"C:\C#.NET\Files\";
        private const string path = dir + "StudentScores.txt";

        public static void SaveStudents(List<Student> students)
        {
            StreamWriter textOut =
                new StreamWriter(
                new FileStream(path, FileMode.Create, FileAccess.Write));

            foreach (Student student in students)
            {
                string scoresList = "";

                for (int i = 0; i < student.ScoreList.Count(); i++)
                {
                    int value = student.ScoreList[i];

                    scoresList += (value + ",");
                }

                textOut.Write(student.Name + "|");
                textOut.WriteLine(scoresList.TrimEnd(','));
            }
            textOut.Close();
        }

        public static List<Student> GetStudents()
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            StreamReader textIn =
                new StreamReader(
                new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            List<Student> students = new List<Student>();

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');
                Student student = new Student();

                List<int> scoreList = new List<int>();

                if (columns[1] != "")
                {
                    int[] scoreArray = columns[1].Split(',').Select(n => Convert.ToInt32(n)).ToArray();

                    scoreList = scoreArray.ToList();
                    student.ScoreList = scoreList;
                }
                else
                {
                    student.ScoreList = new List<int>();
                }

                student.Name = columns[0];
                students.Add(student);

            }

            textIn.Close();

            return students;
        }

        public static void LoadSampleStudents()
        {
            
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            if (!File.Exists(path))
            {

                StreamWriter textOut =
                new StreamWriter(
                new FileStream(path, FileMode.Create, FileAccess.Write));

                textOut.WriteLine("Joel Murach|97,71,83");
                textOut.WriteLine("Doug Lowe|99,93,97");
                textOut.WriteLine("Anne Prince|100,100,100");

                textOut.Close();
            }
        }
    }
}
