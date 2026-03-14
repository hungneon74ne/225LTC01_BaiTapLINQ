using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SinhVien
{
    public int Id { get; set; }
    public string Ten { get; set; }
    public int Tuoi { get; set; }
    public string Khoa { get; set; }
    public double DiemTB { get; set; }
    public int NamHoc { get; set; }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Sinh viên: Lê Việt Hưng");
        Console.WriteLine("MSV: 23115053122313");
        Console.WriteLine("Lớp: 225LTC01\n");

        Random rd = new Random();

        string[] ten = { "An", "Bình", "Chi", "Dũng", "Hà", "Lan", "Minh", "Nam", "Phúc", "Trang" };
        string[] khoa = { "Công nghệ số", "Kinh tế", "Quản trị", "Marketing" };

        List<SinhVien> ds = new List<SinhVien>();

        // Tạo 30 sinh viên random
        for (int i = 1; i <= 30; i++)
        {
            ds.Add(new SinhVien
            {
                Id = i,
                Ten = ten[rd.Next(ten.Length)],
                Tuoi = rd.Next(18, 25),
                Khoa = khoa[rd.Next(khoa.Length)],
                DiemTB = Math.Round(rd.NextDouble() * 10, 2),
                NamHoc = rd.Next(1, 5)
            });
        }

        // 1. Max tuổi, Min tuổi
        Console.WriteLine("1. Tuổi lớn nhất: " + ds.Max(s => s.Tuoi));
        Console.WriteLine("   Tuổi nhỏ nhất: " + ds.Min(s => s.Tuoi));
        Console.WriteLine();

        // 2. Kiểm tra sinh viên thuộc khoa Công nghệ số
        bool coCNT = ds.Any(s => s.Khoa == "Công nghệ số");

        Console.WriteLine("2. Có sinh viên thuộc khoa Công nghệ số không: " + coCNT);
        Console.WriteLine();

        // 3. Lấy 10 sinh viên điểm cao nhất
        var top10 = ds
            .OrderByDescending(s => s.DiemTB)
            .Take(10);

        Console.WriteLine("3. Top 10 sinh viên điểm trung bình cao nhất:");

        foreach (var s in top10)
        {
            Console.WriteLine($"{s.Id} - {s.Ten} - {s.DiemTB}");
        }

        Console.WriteLine();

        // 4. Bỏ sinh viên năm cuối (năm 4)
        var khongNamCuoi = ds.Where(s => s.NamHoc < 4);

        Console.WriteLine("4. Danh sách sinh viên không phải năm cuối:");

        foreach (var s in khongNamCuoi)
        {
            Console.WriteLine($"{s.Id} - {s.Ten} - Năm {s.NamHoc}");
        }
    }
}
