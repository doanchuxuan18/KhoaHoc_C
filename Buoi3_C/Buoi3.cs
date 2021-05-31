using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3_C
{
    class Buoi3
    {
        static void Main(string[] args)
        {
           BaiTap();
        }

        static void phan1()
        {
            //1:Kiểu dữ liệu
            Console.Write("\'\"\\ \0 \a \b");
            Console.ReadLine();
        }
        static void Phan2()
        {//2:Ép kiểu dữ liệu
            //2.1: Ép kiểu Ngầm định
            short x = 10;
            int y = x;
        }
        static void BaiTap()
        {
            Console.WriteLine("Nhap thong tin sinh vien:");
            NhapDiem();
        }
        static void NhapDiem()
        {
            Console.WriteLine("Ho va ten cua ban la:");
            string _Hoten = Console.ReadLine();
            if (_Hoten != "" && _Hoten != " ") //cách 1: kiểm tra rỗng
            {
                if (!char.IsNumber(_Hoten, 0)) //Kiểm tra nó là số hay không
                {

                }
                else
                {
                    Console.WriteLine("ban chua nhap ho ten cua ban!");
                    NhapDiem();
                }
            }
            else
            {
                Console.WriteLine("ban chua nhap ho ten cua ban!");
                NhapDiem();
            }
            //if (string.IsNullOrEmpty(_Hoten) && string.IsNullOrWhiteSpace(_Hoten))
            //{

            //}
        }
    }
}
