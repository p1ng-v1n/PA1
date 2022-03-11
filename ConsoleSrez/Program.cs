using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DllLibrary;
using static DllLibrary.Class1;

namespace ConsoleSrez
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 2020;
            int group = 1281;
            string fio = "Лебедева Арина СЕргеевна";
            var r1 = DllLibrary.Class1.GetStudNumber(year, group, fio);
            Console.WriteLine(r1);
            Console.WriteLine("----------------------------");
            string[] mark = new string[] { "5", "2", "3", "н", "б" };
            double a = MinAVG(mark);
            Console.WriteLine(a);
            Console.WriteLine("----------------------------");
            Mark m1 = new Mark
            {
                Date = DateTime.Now,
                Estimation = "н"
            };
            Mark m2 = new Mark
            {
                Date = DateTime.Now,
                Estimation = "5"
            };
            Mark m3 = new Mark
            {
                Date = DateTime.Now,
                Estimation = "н"
            };
            Mark m4 = new Mark
            {
                Date = DateTime.Now.AddMonths(-1),
                Estimation = "н"
            };
            int[] result = Class1.GetCountTruancy(new List<Mark> { m1, m2, m3, m4 });
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.ReadKey();

            Console.WriteLine("----------------------------");
            Mark m5 = new Mark
            {
                Date = DateTime.Now,
                Estimation = "б"
            };
            Mark m6 = new Mark
            {
                Date = DateTime.Now,
                Estimation = "5"
            };
            Mark m7 = new Mark
            {
                Date = DateTime.Now,
                Estimation = "б"
            };
            Mark m8 = new Mark
            {
                Date = DateTime.Now.AddMonths(-1),
                Estimation = "б"
            };
            result = Class1.GetCountDisease(new List<Mark> { m5, m6, m7, m8 });
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.ReadKey();

            Student m9 = new Student
            {
                FIO = "qwe qwe qwe",
                GroupNumber = "qwe",
                Year = 2000
            };
            Student m10 = new Student
            {
                FIO = "zxc zxc zxc",
                GroupNumber = "zxc",
                Year = 2003
            };
            var r = Class1.GetMarks(DateTime.Now, new List<Student> { m9, m10 });
            foreach (var item in r)
            {
                Console.WriteLine($"{item.Student.FIO} - {item.Date} - {item.Estimation}");
            }
            Console.ReadKey();
        }
    }
}
