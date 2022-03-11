using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DllLibrary
{
    public class Class1
    {
        public static double MinAVG(string[] marks)
        {
            int[] markinmas = marks.Where(x => int.TryParse(x, out int result)).Select(x => int.Parse(x)).ToArray();
            double avg = Math.Floor(markinmas.Average());
            return avg;
        }
        public class Mark
        {
            public DateTime Date { get; set; }
            public string Estimation { get; set; }
            public Student Student { get; set; }
        }

        public class Student
        {
            public string FIO { get; set; }
            public int Year{ get; set; }
            public string GroupNumber{ get; set; }
        }

        public static string GetStudNumber(int year, int group, string fio)
        {
            string[] initial = fio.Split(' ');
            return $"{year}.{group}.{initial[0][0]}{initial[1][0]}{initial[2][0]}";

        }
        public static int[] GetCountTruancy(List<Mark> marks)
        {
            
            int[] estimation = new int[11];
            for (int i = 0; i < estimation.Length; i++)
            {
                estimation[i] = 0;
            }
            foreach (var item in marks)
            {
                if (item.Estimation == "н")
                {
                    estimation[item.Date.Month-1] += 1;
                }
            }
            return estimation;
        }

       public static int[] GetCountDisease(List<Mark> marks)
       {
            int[] estimation = new int[11];
            for (int i = 0; i < estimation.Length; i++)
            {
                estimation[i] = 0;
            }
            foreach (var item in marks)
            {
                if (item.Estimation == "б")
                {
                    estimation[item.Date.Month - 1] += 1;
                }
            }
            return estimation;
       }

        public static List<Mark> GetMarks(DateTime now, List<Student> students)
        {
            
            List<Mark> result = new List<Mark>();
            foreach (var student in students)
            {
                DateTime currentDate = now.Date;
                for (int i = 0; i < 11; i++)
                {
                    result.Add(new Mark
                    {
                        Date = currentDate,
                        Estimation = new Random().Next(2, 5).ToString(),
                        
                        Student = student
                    });
                    currentDate = currentDate.AddDays(1);
                }
            }
            return result;
        }
    }
}
