using System;
using System.Collections.Generic;
using System.Linq;
//bai5

class Program
{
    static void Main()
    {
        Console.WriteLine("Sinh viên: Lê Việt Hưng");
        Console.WriteLine("MSV: 23115053122313");
        Console.WriteLine("Lớp: 225LTC01");
        Console.WriteLine("Bài 5: Bình phương các số\n");

        List<int> numbers = new List<int> { 1, 2, 3 };

        var binhPhuong = numbers.Select(n => n * n);

        foreach (var n in binhPhuong)
        {
            Console.WriteLine(n);
        }
    }
}
