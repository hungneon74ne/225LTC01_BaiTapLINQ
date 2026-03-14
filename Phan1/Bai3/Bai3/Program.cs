using System;
using System.Collections.Generic;
using System.Linq;
//bai3
class Program
{
    static void Main()
    {
        Console.WriteLine("Sinh viên: Lê Việt Hưng");
        Console.WriteLine("MSV: 23115053122313");
        Console.WriteLine("Lớp: 225LTC01");
        Console.WriteLine("Bài 3: Sắp xếp tăng dần\n");

        List<int> numbers = new List<int> { 8, 3, 1, 6, 2, 7, 5, 4 };

        var tangDan = numbers.OrderBy(n => n);

        foreach (var n in tangDan)
        {
            Console.WriteLine(n);
        }
    }
}
