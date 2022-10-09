using System;
using System.Text;

namespace String
{
    class Program
    {
          static void Main(string[] args)
          {
        //    int a = 5;
        //    int b = a;
        //    b = 18;
        //    Console.WriteLine(a + " " +b);

        //    int[] numbers1 = { 1, 3, 4, 5, 6, 7, 8 };
        //    int[] numbers2 = numbers1;
        //    numbers2[0] = 99;

        //    Console.WriteLine(numbers1[0]+" "+numbers2[0]);


        //    int num = 13;
        //    num += 3;
        //    ShowNum(num);
        //    num -= 2;
        //    Console.WriteLine(num);

        //    int num = 10;
        //    ShowNum(out num);
        //    num += 2;
        //    Console.WriteLine(num);

        //    int num = 10;
        //    ShowNum(ref num);
        //    num += 2;
        //    Console.WriteLine(num);


        //    string name1 = "Qosqar";
        //    string name2 = name1;
        //    name2 = "Cavid";
        //    Console.WriteLine(name1);
        //    Console.WriteLine(name2);

        //    string name;
        //    Checkstr(out name1);
        //    Console.WriteLine(name1);

        //    string str1 = "Cav";
        //    string str2 = "id";
        //    string name = str1 + str2;
        //    Console.WriteLine(name);

        //    StringBuilder str = new StringBuilder();

        //    str.Append("Cav");
        //    str.Append("id");

        //    Console.WriteLine(str);

        //    String name1 = new String("Lale");
        //    Console.WriteLine(name1);

        //    int num = 55;

        //    Boolean isMarried = new Boolean();

        //    string name = "Ramil";

        //    Console.WriteLine(name.Length);

        //    for (int i = 0; i < name.Length; i++)
        //    {
        //        Console.WriteLine(name[i]);
        //    }

        //    Console.WriteLine(name.Trim());
        //    Console.WriteLine(name.StartsWith("R"));
        //    Console.WriteLine(name.EndsWith("l"));

        //    string name = "Ramil";


        //    if (name.Trim().ToLower().StartsWith("R"))
        //    {
        //        Console.WriteLine("Yes");
        //    }
        //    else
        //    {
        //        Console.WriteLine("No");
        //    }

        //    Console.WriteLine(name.LastIndexOf("a"));
        //    Console.WriteLine(name.IndexOf("a"));

        //    Console.WriteLine(name.Replace("Ramil","Resul"));

        //    Console.WriteLine(name.Remove(4,3));

        //    Console.WriteLine((name.Substring(3));

        //    var result = name.Split("-");
        //    Console.WriteLine(result);

        //    foreach(var item in result )
        //    {
        //        Console.WriteLine(item);
        //    }

        //    string[] words = { "one", "two", "three" };

        //    Console.WriteLine(string.Join(" ",words));

              string text = "";

            //    if (string.IsNullOrEmpty(text))
            //    {
            //        Console.WriteLine("yes");
            //    }
            //    else
            //    {
            //        Console.WriteLine("no");
            //    }

            //    if (string.IsNullOrWhiteSpace(text))
            //    {
            //        Console.WriteLine("yes");
            //    }
            //    else
            //    {
            //        Console.WriteLine("no");
            //    }
            //}
            //---------------------------------------------------------------------------------------------------------
            //NEW METHODS
            //TASK1
            string s1 = "Qwerty";
            string s2 = "Qw";
            string s3 = "Asd";

            Console.WriteLine(s1.Contains(s2));
            Console.WriteLine(s1.Contains(s3));

            //Task2
            string s4 = "Mahir Safarov";
            Console.WriteLine(s1.PadLeft(2));
            Console.WriteLine(s1.PadLeft(10));
            Console.WriteLine(s1.PadLeft(20));

            //Task3
            string s5 = "MahirSafarov";
            string s6 = (String).s5.Clone();

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            //Task4
            string s7 = "Mahir ";
            string s8 = "Safarov";
            string s9;

            Console.WriteLine(s7);
            Console.WriteLine(s8);

            s9 = String.Concat(s7, s8);

            Console.WriteLine(s9);

            //Task 5
            String s10 "MahirSafarov";

            Console.WriteLine(s10);

            Console.WriteLine(s10.Insert(5," "));



            //public static void CheckStr(out string str)
            //{
            //    str = "Mahir";
            //    Console.WriteLine(str);
            //}

            //public static void ShowNum(ref int num)
            //{
            //    num += 2;
            //    Console.WriteLine(num);
            //}

            //public static void ShowNum(out int num)
            //{
            //    num = 100;
            //    num += 2;
            //    Console.WriteLine(num);
        }
    }
}
