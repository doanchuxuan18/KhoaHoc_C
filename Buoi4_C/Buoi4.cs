using System;
using System.Dynamic;

namespace Buoi4_C
{
    class Buoi4
    {
        static void Main()
        {//Function (Phương thức)
         //Phương thức 1 chiều:
         //Cấu trúc: Static void + [Tên phương thức](){[Lệnh cần làm]};
         //VÍ DỤ:
         //NhiemVu1();

            //Phương thức 2 chiều(Function):
            //Cấu trúc: Static + Kiểu dữ liệu đầu ra + [Tên phương thức](){[Lệnh cần làm]};
            //VÍ DỤ:
            //NhiemVu2();
            //Phương thức 2 chiều có kèm theo(Function);
            //Cấu trúc: Static + Kiểu dữ liệu đầu ra + [Tên phương thức]([kiểu dữ liệu] + Tên biến){[Lệnh cần làm]};
            //VÍ DỤ:
            string _KetQuaDauRa = NhiemVu3(5,6);

            Console.WriteLine("Tra ra ket qua tong 4+5 = {0}", _KetQuaDauRa);
            Console.ReadLine();
        }

        static void NhiemVu1()
        {
            Console.WriteLine("Day la nhiem vu 1!");
            Console.ReadLine();
        }

        static int NhiemVu2()
        {
           
            int _KetQuaDauRa = 0;
            _KetQuaDauRa = 4+5;
            Console.WriteLine("Tra ra ket qua tong 4+5 = {0}", _KetQuaDauRa);
            Console.ReadLine();
            return _KetQuaDauRa;
        }

        static string NhiemVu3(int _BienKemTheo)
        {
            string _KQDR = "";
            if (_BienKemTheo % 2 == 0)
            {
                _KQDR = "chan";
            }
            else
            {
                _KQDR = "le";
            }
            return _KQDR;
        }

        static string NhiemVu3(int _BienKemTheo1, int _BienKemTheo2)
        {
            int _KetQuaDauRa = 0;
            _KetQuaDauRa =_BienKemTheo1+_BienKemTheo2;
            Console.WriteLine("Tra ra ket qua tong 4+5 = {0}", _KetQuaDauRa);
            Console.ReadLine();
            return Convert.ToString(_KetQuaDauRa);
        }
    }
}
