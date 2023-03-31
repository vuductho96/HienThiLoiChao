using System;
namespace Program;

class HienThiLoiChAO
{

    static void Main(string[] args)
    {

        Console.WriteLine("Nhap Ten Cua Ban : ");
        Console.WriteLine("------------------:");
        Console.WriteLine("Nhap Tuoi Cua Ban :");
        Console.WriteLine("------------------:");
        Console.WriteLine("Nhap Sdt Cua Ban :");
        Console.WriteLine("------------------:");
        Console.WriteLine("Nhap D/C Cua Ban :");
        Console.WriteLine("------------------:");
        string Yourname, Age, Dc;
        int Sdt;
        Yourname = Console.ReadLine();
        Age = Console.ReadLine();
        Sdt = int.Parse(Console.ReadLine());
        Dc = Console.ReadLine();
        Console.WriteLine("--------Your Profile---------:");
        Console.WriteLine("Xin Chao :   " + Yourname);
        Console.WriteLine("Tuoi cua ban :   " + Age);
        Console.WriteLine("Sdt cua baN :   " + Sdt);
        Console.WriteLine("D/c la :   " + Dc);

    }


}







