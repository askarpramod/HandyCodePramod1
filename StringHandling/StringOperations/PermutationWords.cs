using System;
using System.Collections.Generic;
using System.Text;

namespace StringOperations
{
  public  class PermutationWords
    {
        public void CallMethod()
        {          

            //Solution 1
            Console.WriteLine("Enter Text to create all possible words from it!!");
            string str = Console.ReadLine();
            //string str = "car";
            char[] arr = str.ToCharArray();
            GetPer(arr);
            Console.ReadKey();
        }

        private static void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            var temp = a;
            a = b;
            b = temp;
        }

        public static void GetPer(char[] list)
        {
            int x = list.Length - 1;
            GetPer(list, 0, x);
        }

        private static void GetPer(char[] list, int k, int m)
        {
            if (k == m)
            {
                Console.Write(list);
                Console.Write("\t");
            }
            else
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    GetPer(list, k + 1, m);
                    Swap(ref list[k], ref list[i]);
                }
        }

        //
        /*
                Console.WriteLine("Enter Text");

                // Define .NET Strings  
                // String of characters  
                System.String authorName = Console.ReadLine();

                int len = authorName.Length;
                // String made of an Integer  
                System.String age = "33";

                // String made of a double  
                System.String numberString = "33.23";

                // Write to Console.  
                Console.WriteLine("Name: {0}", authorName);
                Console.WriteLine("Age: {0}", age);
                Console.WriteLine("Number: {0}", numberString);
                //Console.ReadKey();

                string sentence = "Mahesh Chand is an author and founder of C# Corner";
                char[] charArr = sentence.ToCharArray();
                foreach (char ch in charArr)
                {
                    Console.WriteLine(ch);
                }

        */
        //
    }
}
