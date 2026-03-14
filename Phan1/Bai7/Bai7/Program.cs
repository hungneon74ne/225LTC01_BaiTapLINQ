using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//bai7
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Sinh viên: Lê Việt Hưng");
        Console.WriteLine("MSV: 23115053122313");
        Console.WriteLine("Lớp: 225LTC01");
        Console.WriteLine("Bài 7: Kiểm tra có số > 10\n");

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

        bool ketQua = numbers.Any(n => n > 10);

        Console.WriteLine("Có số > 10 không: " + ketQua);
    }
}
