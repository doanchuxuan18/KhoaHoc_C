using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_C
{
    class Buoi2
    {
        static void Main(string[] args)
        {
            //phan1_2();
           // phan1_1();
           phan1_3();
        }

        static void phan1_1()
        {
            //Buổi 2: Biến, hằng và các toán tử.
            //Console.Write("chao mung den trung tam lap trinh spec");
            //Khai báo biến
            string _str = "abc";
            int _int1 = 2;
            int _int2 = 2;
            double _dou = 2.2;
            //TH1 : In Chuỗi
            Console.WriteLine("Chuoi vua khai bao :" + _str);
            //TH2: In số thực, số nguyên
            Console.WriteLine("so vua khai bao:{0} va {1}", _int1, _dou);
            Console.ReadLine();
        }

        //cấu trúc: static void TenFunction(){Vùng code;};
        static void phan1_2()
        {
            //Nhập và đọc chuỗi vừa nhập vào màn hình.
            Console.WriteLine("Ho va ten cua ban la gi? Ten minh la: ");
            string _Hoten = Console.ReadLine();
            Console.WriteLine("Xin chao ban:" + _Hoten + "\n");
            Console.WriteLine("So ky tu trong ten cua ban la:{0}\n", _Hoten.Length);
            Console.WriteLine("ho ten in thuong:{0}\n", _Hoten.ToLower());
            Console.WriteLine("HO TEN IN HOA:{0}\n", _Hoten.ToUpper());
            Console.WriteLine("Kiem tra co chu T:{0}", _Hoten.Contains("Tuan"));
            Console.ReadLine();
        }

        static void phan1_3()
        {
            //Toán tử
            Console.WriteLine("Moi nhap so nguyen can kiem tra, N= ");
            string _str_SoNguyen = Console.ReadLine(); //đọc ký tự mà mình vừa ghi ra màn hình.
            int _int_SoNguyen = Convert.ToInt32(_str_SoNguyen); //chuyển dạng biến từ chuỗi string sang số nguyên int
            //Toán tử 3 ngôi 
            //a) Kiểm tra chẵn lẽ:
            string _KetQua_A = (_int_SoNguyen % 2 == 0) ? "so chan" : "so le";
            Console.WriteLine("So N = {0} la {1}", _int_SoNguyen, _KetQua_A);
            //b) kiểm tra âm dương:
            string _KetQua_B = (_int_SoNguyen > 0) ? "so duong" : "so am";
            Console.WriteLine("So N = {0} la {1}", _int_SoNguyen, _KetQua_B);
            Console.ReadLine();
        }
    }
}
