using System;
using System.Collections.Generic;
using System.Linq;
//bai1
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Sinh viên: Lê Việt Hưng");
        Console.WriteLine("MSV: 23115053122313");
        Console.WriteLine("Lớp: 225LTC01");
        Console.WriteLine("Bài 1: Lọc số chẵn\n");

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

        var soChan = numbers.Where(n => n % 2 == 0);

        Console.WriteLine("Các số chẵn:");
        foreach (var n in soChan)
        {
            Console.WriteLine(n);
        }
    }
}
