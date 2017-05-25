using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02垃圾回收
{
    class Program
    {
        static void Main(string[] args)
        {

            #region MyRegion

            //////int n = 100;
            ////M1();

            //Person p = new Person();
            //p.Age = 19;
            //p.Name = "张三";

            //p = null;
            ////GC.Collect();

            ////Person p1 = p;

            ////p = null;
            ////p1 = new Person();

            ////Person[] pp = new Person[10];
            ////pp[0] = p;

            ////p = null;

            ////pp[0].Name

            ////手动调用垃圾回收。
            ////GC.Collect();

            ////.........
            ////....
            ////.........

            #endregion




            #region 垃圾回收 机制，代。一共有3代



            Console.WriteLine(GC.MaxGeneration);

            //GC.Collect();

            #endregion



            Console.WriteLine("ok");
            Console.ReadKey();
        }

        static void M1()
        {
            //值类型变量是不需要垃圾回收的，当执行完毕后立刻出栈就释放了。垃圾回收只回收堆中的内存资源。
            int x = 100;
            x++;
            Console.WriteLine(x);


            Person p = new Person();
            p.Age = 19;
            p.Name = "张三";


        }

    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
