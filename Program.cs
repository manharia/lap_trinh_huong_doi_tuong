using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// tạo 1 lớp animal có cân nặng và chiều cao , in ra giá trị chiều cao và cân nặng của chó và mèo trong lớp animal đó 
namespace class_trong_c_sharp_vd1
{
        class animal
        {

            public double weight;
            public double height;

            public animal()
            {
                // Khởi tạo các thuộc tính
                weight = 0;
                height = 0;
            }
            // khởi tạo phương thức cho animal 
            public void info()
            {
                Console.WriteLine("chieu cao " + height + " can nang " + weight);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                animal Dog = new animal();
                Dog.height = 50;
                Dog.weight = 2;

                animal Cat = new animal();
                Cat.height = 30;
                Cat.weight = 1;
                // gọi phương thức
                Dog.info();
                Cat.info();

                Console.ReadKey();
            }
        }
    }

