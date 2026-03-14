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
        Console.WriteLine("Bài 15: Loại bỏ phần tử trùng\n");

        List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

        var ketQua = numbers.Distinct();

        Console.WriteLine("Danh sách sau khi loại trùng:");
        foreach (var n in ketQua)
        {
            Console.WriteLine(n);
        }
    }
}
