using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Sinh viên: Lê Việt Hưng");
        Console.WriteLine("MSV: 23115053122313");
        Console.WriteLine("Lớp: 225LTC01");
        Console.WriteLine("Bài 19: Tìm số xuất hiện nhiều nhất\n");

        List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 4, 5 };

        var ketQua = numbers
            .GroupBy(n => n)
            .OrderByDescending(g => g.Count())
            .First();

        Console.WriteLine("Số xuất hiện nhiều nhất: " + ketQua.Key);
        Console.WriteLine("Số lần xuất hiện: " + ketQua.Count());
    }
}
