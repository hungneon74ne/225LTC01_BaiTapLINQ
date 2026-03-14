using System;
using System.Collections.Generic;
using System.Linq;
//bai2
class Program
{
    static void Main()
    {
        Console.WriteLine("Sinh viên: Lê Việt Hưng");
        Console.WriteLine("MSV: 23115053122313");
        Console.WriteLine("Lớp: 225LTC01");
        Console.WriteLine("Bài 2: Lọc số > 5\n");

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

        var ketQua = numbers.Where(n => n > 5);

        foreach (var n in ketQua)
        {
            Console.WriteLine(n);
        }
    }
}
