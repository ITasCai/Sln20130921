using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _03集合
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList集合,类似于一个object数组

            //ArrayList arrayList = new ArrayList();

            ////增加元素
            //arrayList.Add(1);
            //arrayList.Add(99.9);
            //arrayList.Add("hello");
            //Person p = new Person();
            //p.Name = "张三";
            //arrayList.Add(p);
            //arrayList.Add(false);

            ////在指定索引处插入一个新元素
            //arrayList.Insert(0, "============");

            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //string[] names = new string[] { "乔丹", "科比", "韦德" };
            //arrayList.AddRange(arr);
            //arrayList.AddRange(names);
            //ArrayList arrList2 = new ArrayList();
            //arrList2.Add("中国");
            //arrList2.Add("美国");
            //arrList2.Add("韩国");

            ////通过调用AddRange()把另一个数组或者集合加到当前arrayList中。
            //arrayList.AddRange(arrList2);

            ////清空集合
            //arrayList.Clear();


            //Console.WriteLine("循环遍历集合中每一个元素的内容：");

            ////循环遍历元素
            ////ArrayList可以通过下标来访问，原因就是ArrayList中有一个索引器
            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.WriteLine(arrayList[i].ToString());
            //}






            ////默认创建好一个空的ArrayList后，Count是0.
            ////Count表示，集合中实际元素的个数。
            ////Capacity表示容量。
            //Console.WriteLine(arrayList.Count + "============" + arrayList.Capacity);
            //Console.ReadKey();


            //string[] n = new string[] { "a", "b", "c" };

            //Array.Clear(n, 0, n.Length);

            //Console.WriteLine(n.Length);
            //for (int i = 0; i < n.Length; i++)
            //{
            //    Console.WriteLine(n[i]+"★");
            //}
            //Console.ReadKey();


            //RemoveAt
            //集合初始化器
            //ArrayList arrList = new ArrayList() { 1, 2, 3, 4, 5, 6, "aaa", false, 99.9 };


            //arrList.RemoveAt(0);
            //arrList.RemoveAt(1);
            //arrList.RemoveAt(2);

            //for (int i = 0; i < arrList.Count; i++)
            //{
            //    Console.WriteLine(arrList[i]);
            //}



            ////要想清空集合，不能这么删除，因为集合的Count是可以动态改变大小的。
            //for (int i = 0; i < arrList.Count; i++)
            //{
            //    arrList.RemoveAt(i);
            //}







            //ArrayList arrList = new ArrayList() { 1, 2, 3, 4, 5, 6, "aaa", false, 99.9, new Person() { Name = "张三" } };



            ////把一个集合转换成一个数组
            //object[] objs = arrList.ToArray();


            ////根据元素内容来删除，内部是通过调用元素Equals()方法来实现的比较，所以只要Equals()方法返回值为true,则认为这两个值相等，值相等的，就可以被删除。
            //arrList.Remove(1);
            //arrList.Remove(2);
            //arrList.Remove(3);
            //string a = new string(new char[] { 'a', 'a', 'a' });
            //Person p1 = new Person() { Name = "张三" };

            //arrList.Remove(a);
            //arrList.Remove(p1);//这个元素没有删除？？


            //////Contains()方法内部判断两个值是否相等，也是通过Equals()方法来判断的。
            ////if (arrList.Contains(1))
            ////{

            ////}

            //for (int i = 0; i < arrList.Count; i++)
            //{
            //    Console.WriteLine(arrList[i]);
            //}

            ////Console.WriteLine(arrList.Count);//?????
            //Console.ReadKey();




            #endregion

            //string
            #region ArrayList的Sort排序方法

            ////ArrayList arr = new ArrayList() { 0, 8, 32, 3, 4, 2, 432, 5, 234, 54323, 875, 45 };
            ////ArrayList arr = new ArrayList() { "Alice", "Wayen", "Chris", "Jerry", "Tom", "John", "Bob", "James", "Steve" };

            //ArrayList arr = new ArrayList() {
            //new Person(){ Name="Alice Wang", Age=19},
            //new Person(){ Name="Wayen Li", Age=12},
            //new Person(){ Name="Chris Sun", Age=21},
            //new Person(){ Name="Jerry Huang", Age=22}
            //};

            //Console.WriteLine("排序之前：");
            //for (int i = 0; i < arr.Count; i++)
            //{
            //    Console.WriteLine(((Person)arr[i]).Name);
            //}
            ////IComparable
            ////升序排序
            //arr.Sort();

            ////反转
            ////arr.Reverse();

            //Console.WriteLine("排序之后：");
            //for (int i = 0; i < arr.Count; i++)
            //{
            //    Console.WriteLine(((Person)arr[i]).Name);
            //}
            //Console.ReadKey();

            #endregion



            #region 通过编写不同的比较器，实现ArrayList的Sort()方法的不同方式排序

            ArrayList arr = new ArrayList() {
            new Person(){ Name="Alice Wang", Age=19},
            new Person(){ Name="Wayen Li", Age=12},
            new Person(){ Name="Chris Sun", Age=21},
            new Person(){ Name="Jerry Huang", Age=22}
            };

            //按照年龄升序排序
            //arr.Sort(new PersonSortByAgeAsc());


            //按照年龄降序排序
            //arr.Sort(new PersonSortByAgeDesc());


            //按照姓名的长度升序排序
            //arr.Sort(new PersonSortByNameLengthAsc());


            //按照姓名长度降序排序
            arr.Sort(new PersonSortByNameLengthDesc());
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(((Person)arr[i]).Name);
            }
            Console.ReadKey();


            #endregion
        }
    }

    /// <summary>
    ///按照姓名长度降序排序 
    /// </summary>
    class PersonSortByNameLengthDesc : IComparer
    {

        #region IComparer 成员

        public int Compare(object x, object y)
        {
            Person p1 = x as Person;
            Person p2 = y as Person;
            if (p1 != null && p2 != null)
            {
                return p2.Name.Length - p1.Name.Length;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        #endregion
    }


    //class CarPaiLiangAsc:IComparer
    //{

    //    #region IComparer 成员

    //    public int Compare(object x, object y)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    #endregion
    //}


    /// <summary>
    /// 按照姓名长度升序排序
    /// </summary>
    class PersonSortByNameLengthAsc : IComparer
    {

        #region IComparer 成员

        public int Compare(object x, object y)
        {
            Person p1 = x as Person;
            Person p2 = y as Person;
            if (p1 != null && p2 != null)
            {
                return p1.Name.Length - p2.Name.Length;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        #endregion
    }

    /// <summary>
    /// 这个类就是一个比较器，这个比较器是一个按年龄进行升序排序的比较器
    /// </summary>
    class PersonSortByAgeAsc : IComparer
    {

        #region IComparer 成员

        public int Compare(object x, object y)
        {
            Person p1 = x as Person;
            Person p2 = y as Person;
            if (p1 != null && p2 != null)
            {
                return p1.Age - p2.Age;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        #endregion
    }

    /// <summary>
    /// 按照年龄降序排序的比较器
    /// </summary>
    class PersonSortByAgeDesc : IComparer
    {

        #region IComparer 成员

        public int Compare(object x, object y)
        {
            Person p1 = x as Person;
            Person p2 = y as Person;
            if (p1 != null && p2 != null)
            {
                return p2.Age - p1.Age;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        #endregion
    }

    class Person : IComparable
    {
        public string Name { get; set; }

        public int Age { get; set; }

        //public override bool Equals(object obj)
        //{
        //    Person pp = obj as Person;
        //    if (pp != null && pp.Name == this.Name)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        #region IComparable 成员

        public int CompareTo(object obj)
        {
            Person p = obj as Person;
            if (p == null)
            {
                throw new ArgumentException();
            }
            else
            {
                //return p.Age - this.Age;
                return this.Name.Length - p.Name.Length;
            }
        }

        #endregion
    }
}
