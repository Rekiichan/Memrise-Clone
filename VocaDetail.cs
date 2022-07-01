using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memrise_net5
{
    public class VocaDetail
    {
        public static int count { get; set; }
        public int ID { get; set; }
        public string Eng { set; get; }
        public string Viet { set; get; }
        public string TypeWord { set; get; }
        public VocaDetail()
        {
            Console.Clear();
            ID = count++;
            Console.WriteLine($"Tu thu {ID + 1}");
            Console.Write("nhap nghia tieng anh:  ");
            Eng = Console.ReadLine();
            Console.WriteLine();
            Console.Write("nhap nghia tieng viet: ");
            Viet = Console.ReadLine();
            Console.WriteLine();
            Console.Write("nhap loai tu:          ");
            Console.WriteLine();
            Console.WriteLine($"(1) Danh tu");
            Console.WriteLine($"(2) Dong tu");
            Console.WriteLine($"(3) Tinh tu");
            Console.WriteLine($"(4) Trang tu");
            Console.Write("Nhap Lua Chon: ");
        ERROR1:
            int key = int.Parse(Console.ReadLine());
            switch (key) 
            {
                case 1:
                {
                    TypeWord = "Danh tu";
                    break;
                }
                case 2:
                {
                    TypeWord = "Dong tu";
                    break;
                }
                case 3:
                {
                    TypeWord = "Tinh tu";
                    break;
                }
                case 4:
                {
                    TypeWord = "Trang tu";
                    break;
                }
                default:
                {
                    Console.WriteLine("Yeu cau nhap so tu 1 -> 4");
                    goto ERROR1;
                }
            }
        }
        public void ShowDetail()
        {
            //Console.Clear();
            //Console.WriteLine($"ID              : {ID}");
            Console.WriteLine($"Nghia tieng anh :   {Eng}\n");
            Console.WriteLine($"Nghia tieng viet:   {Viet}\n");
            Console.WriteLine($"Loai tu         :   {TypeWord}");
        }
    }
}
