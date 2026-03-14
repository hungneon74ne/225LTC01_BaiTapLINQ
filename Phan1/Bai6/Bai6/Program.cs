using System;
using System.Collections.Generic;
using System.Linq;
//bai6
class Program
{
    static void Main()
    {
        Console.WriteLine("Sinh viên: Lê Việt Hưng");
        Console.WriteLine("MSV: 23115053122313");
        Console.WriteLine("Lớp: 225LTC01");
        Console.WriteLine("Bài 6: Đếm số chẵn\n");

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

        int dem = numbers.Count(n => n % 2 == 0);

        Console.WriteLine("Số lượng số chẵn: " + dem);
    }
}
