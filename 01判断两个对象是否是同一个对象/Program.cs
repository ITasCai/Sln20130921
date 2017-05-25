using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace _01判断两个对象是否是同一个对象
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 判断两个对象是否是同一个对象

            //Person p1 = new Person();
            //p1.Name = "闫刘盘";
            //p1.Age = 16;

            //Person p2 = new Person();
            //p2.Name = "闫刘盘";
            //p2.Age = 16;

            ////p1与p2是否是同一个对象？No


            //Person p3 = p1;
            ////p1与p3是同一个对象吗？Yes

            //Console.ReadKey();
            #endregion


            #region 字符串池特性
            //Person p1 = new Person();
            //p1.Name = "闫刘盘";
            //p1.Age = 16;

            //Person p2 = new Person();
            //p2.Name = "闫刘盘";
            //p2.Age = 16;

            //默认情况下可以调用对象的Equals方法来验证两个对象是否是同一个对象，但是由于该方法是可以重写的，所以子类有可能把该方法重写，当子类把该方法重写后，则通过该方法验证两个对象是否是同一个对象就不准确了，所以不要依赖Equals方法或==来判断两个对象是否是同一个对象，不准确！！！！！
            //Console.WriteLine(p1.Equals(p2)); //false
            // Console.WriteLine(p1 == p2); //f/t
            //  Console.ReadKey();
            //


            //string[] names = new string[] { "张三", "李四", "王五" };
            //string[] names1 = new string[] { "张三", "李四", "王五" };
            //Console.WriteLine(names.Equals(names1));//???
            //Console.WriteLine(names == names1);//????
            //Console.ReadKey();


            //string s1 = new string(new char[] { 'a', 'b', 'c' });
            //string s2 = new string(new char[] { 'a', 'b', 'c' });


            //在字符串类中，Equals()与==都是判断字符串的内容是否相同而不是判断字符串的地址。
            //并且==也进行了运算符重载，==内部就是调用的Equals()方法来进行判断的。
            //Console.WriteLine(s1.Equals(s2));//????
            //Console.WriteLine(s1 == s2);//???
            //Console.ReadKey();




            ////判断两个对象是否是同一个对象的方法：
            ////object.ReferenceEquals(p1, p2)标准的判断对象是否是同一个对象的方法
            //string s1 = new string(new char[] { 'a', 'b', 'c' });
            //string s2 = new string(new char[] { 'a', 'b', 'c' });
            //Console.WriteLine(object.ReferenceEquals(s1, s2));


            //Person p1 = new Person();
            //p1.Name = "闫刘盘";
            //p1.Age = 16;

            //Person p2 = new Person();
            //p2.Name = "闫刘盘";
            //p2.Age = 16;
            //Console.WriteLine(object.ReferenceEquals(p1, p2));
            //Console.ReadKey();

            //string s1 = new string(new char[] { 'a', 'b', 'c' });
            //string s2 = new string(new char[] { 'a', 'b', 'c' });

            ////针对字符串常量的暂存池特性，对于相同的字符串常量，每次使用的时候并不会重新创建一个内存来存储，而是在第一次创建的时候，将字符串作为键，将字符串的地址作为值来存储，下次再用到的时候先去键值对中查找，如果有则直接返回上次创建字符串的地址。 这个特性依赖于字符串的另外一个特性才能存在：字符串的不可变性。
            ////string s3 = "abc";
            ////string s4 = "abc";
            ////string s5 = "a" + "b" + "c";
            //string a = "a";
            //string b = "b";
            //string c = "c";
            //string s1 = "abc";
            //string s2 = a + b + c;
            //Console.ReadKey();

            ////string msg = "abcabcabcabcabcabcabcabcabcabcabc";

            #endregion


            //int n = 10;


            #region 字符串的不可变性，字符串一旦创建，就不可以改变

            //string s1 = "abc";
            //s1 = "cba";
            //Console.WriteLine(s1);
            //Console.ReadKey();


            ////由于字符串的不可变性，所以造成了当多个字符串进行拼接的时候，造成内存的浪费以及时间的消耗（因为每次创建对象都要消耗时间，创建对象也是有成本的。）
            //string s = "a";
            //s = s + "b";
            //s = s + "c";
            //s = s + "d";
            //Console.WriteLine(s);
            //Console.ReadKey();


            //string s1 = "abc";
            //string s2 = new string(new char[] { 'a', 'b', 'c' });

            #endregion


            #region 字符串的拼接
            //00:00:07.1317142
            //00:00:06.3386025
            //00:00:06.6813519

            //string msg = string.Empty;
            //string[] lines = File.ReadAllLines("sbTest.txt", Encoding.Default);
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //for (int i = 0; i < lines.Length; i++)
            //{
            //    msg = msg + lines[i];
            //}
            //watch.Stop();
            //Console.WriteLine(watch.Elapsed);
            //Console.WriteLine("ok");
            //Console.ReadKey();



            #endregion


            #region StringBuilder进行字符串拼接


            ////StringBuilder 每次修改都是修改同一个块内存中的值，不会重复创建大量对象，也不会产生垃圾内存，所以大大提高了字符串拼接的效率。建议大量字符串拼接的时候首选StringBuilder 
            //StringBuilder msg = new StringBuilder();
            //string[] lines = File.ReadAllLines("sbTest.txt", Encoding.Default);
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //for (int i = 0; i < lines.Length; i++)
            //{
            //    msg.Append(lines[i]);
            //}
            //watch.Stop();
            //Console.WriteLine(watch.Elapsed);

            ////把StringBuilder 转换为string 类型。
            //string s = msg.ToString();
            //Console.WriteLine("ok");
            //Console.ReadKey();
            #endregion






        }
    }

    class Person
    {
        public int Age
        {
            get;
            set;

        }

        public string Name { get; set; }


        public override bool Equals(object obj)
        {
            Person p = obj as Person;
            if (p != null)
            {
                if (p.Age == this.Age && p.Name == this.Name)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
    }
}
