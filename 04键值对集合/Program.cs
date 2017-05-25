using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _04键值对集合
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 键值对集合介绍


            //int[] nums = new int[] { 23, 123, 223, 323, 425, 567 };
            ////1.要查找该数组中是否包含323这个数字

            //int number = 323;
            ////////方法1：
            ////for (int i = 0; i < nums.Length; i++)
            ////{
            ////    if (nums[i] == number)
            ////    {
            ////        Console.WriteLine("包含!");
            ////        break;
            ////    }
            ////}
            ////Console.ReadKey();


            //////方法2：
            //int index = number / 100;
            //if (index < nums.Length)
            //{
            //    if (nums[index] == number)
            //    {
            //        Console.WriteLine("包含！");
            //    }
            //    else
            //    {
            //        Console.WriteLine("不包含！");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("不包含！");
            //}


            //Console.ReadKey();

            #endregion


            #region 键值对集合使用，Hashtable

            //1.创建一个集合对象
            Hashtable hash = new Hashtable();
            //增加内容
            hash.Add("ylp", "闫刘盘");
            hash.Add("lsx", "刘尚鑫");
            hash.Add("ljj", "李晶晶");
            hash.Add("cc", "陈超");
            hash.Add("bsy", "鲍守营");
            hash.Add("pll", "彭莉莉");



            ////循环遍历键值对集合中的每个元素
            //for (int i = 0; i < hash.Count; i++)
            //{
            //    //键值对集合不能使用for循环遍历，因为无法根据索引获取内容，只能根据键来获取内容。
            //    Console.WriteLine(hash[i]);
            //}

            ////通过foreach循环来遍历
            ////遍历键值对集合的所有的键
            //foreach (object item in hash.Keys)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            ////遍历所有的值
            //foreach (object item in hash.Values)
            //{
            //    Console.WriteLine(item);//遍历所有的值
            //}


            //直接遍历
            foreach (DictionaryEntry item in hash)
            {
                //直接遍历键值对
                Console.WriteLine(item.Key + "     " + item.Value);
            }
            Console.ReadKey();





            ////键值对集合的一个特点：键不能重复。
            ////hash.Add("ylp","有老婆");

            ////判断集合中是否已经存在某个键了
            //if (hash.ContainsKey("ylp"))
            //{
            //    Console.WriteLine("已经存在ylp了。");
            //}
            //else
            //{
            //    hash.Add("ylp", "燕刘盼");
            //}


            ////根据键获取值
            //Console.WriteLine(hash["ylp"]);
            //Console.WriteLine(hash["lsx"]);


            //修改
            //hash["key"]="修改";

            //根据键删除某个元素
            //hash.Remove("key");
            Console.ReadKey();



            #endregion



        }
    }
}
