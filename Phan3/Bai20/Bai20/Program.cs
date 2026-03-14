using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Score { get; set; }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Sinh viên: Lê Việt Hưng");
        Console.WriteLine("MSV: 23115053122313");
        Console.WriteLine("Lớp: 225LTC01");
        Console.WriteLine("Bài 20: Top 3 sinh viên điểm cao nhất\n");

        List<Student> students = new List<Student>()
        {
            new Student{Id=1, Name="An", Score=8},
            new Student{Id=2, Name="Binh", Score=6},
            new Student{Id=3, Name="Chi", Score=9},
            new Student{Id=4, Name="Dung", Score=7},
            new Student{Id=5, Name="Hoa", Score=8.5}
        };

        var top3 = students
            .OrderByDescending(s => s.Score)
            .Take(3);

        Console.WriteLine("Top 3 sinh viên điểm cao nhất:");

        foreach (var s in top3)
        {
            Console.WriteLine($"{s.Name} - {s.Score}");
        }
    }
}
