using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _05集合练习1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 案例：两个（ArrayList）集合{ “a”,“b”,“c”,“d”,“e”}和{ “d”, “e”, “f”, “g”, “h” }，把这两个集合去除重复项合并成一个。

            //ArrayList arr1 = new ArrayList() { "a", "b", "c", "d", "e" };
            //ArrayList arr2 = new ArrayList() { "d", "e", "f", "g", "h" };

            //ArrayList arr3 = new ArrayList();
            ////arr3.Add(arr1);
            //arr3.AddRange(arr1);
            //for (int i = 0; i < arr2.Count; i++)
            //{
            //    if (!arr3.Contains(arr2[i]))
            //    {
            //        arr3.Add(arr2[i]);
            //    }
            //}

            //for (int i = 0; i < arr3.Count; i++)
            //{
            //    Console.WriteLine(arr3[i]);
            //}
            //Console.ReadKey();




            #endregion



            #region 案例：随机生成10个1-100之间的数放到ArrayList中，要求这10个数不能重复，并且都是偶数(添加10次，可能循环很多次。)

            //Random random = new Random();
            //ArrayList list = new ArrayList();

            //while (list.Count < 10)
            //{
            //    int n = random.Next(1, 101);

            //    if (n % 2 == 0 && !list.Contains(n))
            //    {
            //        list.Add(n);
            //    }
            //}

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            //Console.ReadKey();

            #endregion


            #region 练习：有一个字符串是用空格分隔的一系列整数，写一个程序把其中的整数做如下重新排列打印出来：奇数显示在左侧、偶数显示在右侧。比如”2 7 8 3 22 9 5 11”显示成”7 3 9 2 8 22….”。

            //string strs = "2 7 8 3 22 9 5 11";
            //string[] nums = strs.Split(' ');

            ////奇数
            //ArrayList arrOdd = new ArrayList();

            ////偶数
            //ArrayList arrEven = new ArrayList();
            ////循环nums数组
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (Convert.ToInt32(nums[i]) % 2 == 0)
            //    {
            //        arrEven.Add(nums[i]);
            //    }
            //    else
            //    {
            //        arrOdd.Add(nums[i]);
            //    }
            //}

            ////把奇数集合与偶数集合合并到一起
            //arrOdd.AddRange(arrEven);

            ////拼接字符串
            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < arrOdd.Count; i++)
            //{
            //    sb.Append(arrOdd[i] + " ");
            //}
            //Console.WriteLine(sb.ToString().Trim());
            //Console.ReadKey();

            #endregion
        }
    }
}
