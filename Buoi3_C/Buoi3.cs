using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
           //string _Hoten = NhapTen();
           //Console.WriteLine("Xin chao ban "+_Hoten);
           double _DiemHoa = NhapDiem("Hóa");
           double _DiemLy = NhapDiem("Lý");
           double _DiemToan = NhapDiem("Toán");
           Console.WriteLine("Diem mon hoa cua ban la :{0}đ ", _DiemHoa);
           Console.WriteLine("Diem mon hoa cua ban la :{0}đ ", _DiemLy);
           Console.WriteLine("Diem mon hoa cua ban la :{0}đ ", _DiemToan);
           double _DTb = (_DiemToan + _DiemLy + _DiemHoa) / 3;
           string _HocLuc = DanhGiaHocLuc(_DTb);
           Console.WriteLine("Hoc luc cua ban la : {0}",_HocLuc);
           Console.ReadLine();
        }
        static string NhapTen()
            
       {
            Console.WriteLine("Ho va ten cua ban la:");
            string _Hoten = Console.ReadLine();
            if (_Hoten != "" && _Hoten != " ") //cách 1: kiểm tra rỗng
            {
                if (!char.IsNumber(_Hoten, 0)) //Kiểm tra nó là số hay không
                {
                    if (_Hoten.Length > 3)//kiểm tra nhập quá ngắn
                    {
                        return _Hoten;
                    }
                    else
                    {
                        Console.WriteLine("Ten qua ngan!");
                        NhapTen();
                    }
                }
                else
                {
                    Console.WriteLine("Vui long khong nhap so vao ho ten!");
                    NhapTen();
                }
            }
            else
            {
                Console.WriteLine("ban chua nhap ho ten cua ban!");
                NhapTen();
            }
            //if (string.IsNullOrEmpty(_Hoten) && string.IsNullOrWhiteSpace(_Hoten))
            //{

            //}
            return "";
        }
        static double NhapDiem(string _TenMonHoc)
        {
            double _dbl_Diem = 0.0;
            Console.Write("Diem mon {0} cua ban la: ",_TenMonHoc);
            string _str_Diem = Console.ReadLine();
            if (_str_Diem != "" && _str_Diem != " ")//Kiểm tra rỗng
            {
                if (char.IsNumber(_str_Diem, 0))//Kiểm tra có là số hay không
                {
                    _dbl_Diem = double.Parse(_str_Diem);
                    if (_dbl_Diem >= 0)//Kiểm tra số âm
                    {
                        if (_dbl_Diem <= 10)//Kiểm tra phạm vi điểm
                        {
                            return _dbl_Diem;
                        }
                        else
                        {
                            Console.WriteLine("Diem nhap khong hop ly!");
                            NhapDiem(_str_Diem);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ban phai nhap so duong");
                        NhapDiem(_str_Diem);
                    }
                }
                else
                {
                    Console.WriteLine("Ban phai nhap so!");
                    NhapDiem(_TenMonHoc);
                }
            }
            else
            {
                Console.WriteLine("Ban chua nhap diem!");
                NhapDiem(_TenMonHoc);
            }
            return _dbl_Diem;
        }

        static string DanhGiaHocLuc(double _Dtb)
        {
            string _HocLuc = "";
            if (_Dtb >= 0 && _Dtb < 5)
            {
                _HocLuc = "Trung bình";
            }
            else if(_Dtb>=5&&_Dtb<7)
            {
                _HocLuc = "Khá";
            }
            else if (_Dtb >=7  && _Dtb <= 10)
            {
                _HocLuc = "Giỏi";
            }
            return _HocLuc;
        }
    }
}
