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
        Console.WriteLine("Bài 16: Tính tổng\n");

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        int tong = numbers.Sum();

        Console.WriteLine("Tổng các số: " + tong);
    }
}
