using System;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Other.Example
{
    class Program
    {
        static async void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Async Await
            //By using Asynchronous programming, the Application can continue with the other work that does not depend on the completion of the entire task.
            //https://www.c-sharpcorner.com/article/async-and-await-in-c-sharp/#:~:text=Async%20and%20await%20in%20C%23%20are%20the%20code%20markers%2C%20which,for%20understanding%20the%20programming%20concept.

            /*  //Exmple 1
            Task task = new Task(CallMethod);
            task.Start();
            task.Wait();
            */
            //Example2
           await callMethod();
            Console.ReadLine();



        }

        //Example1
        static async void CallMethod()
        {
            string filePath = "C:\\Data\\ReadMe1.txt";
            Task<int> task = ReadFile(filePath);
            // int length = await task;
            Console.WriteLine(" Other Work 1");
            Console.WriteLine(" Other Work 2");
            Console.WriteLine(" Other Work 3");


            // int length = await task;
            // Console.WriteLine(" Total length: " + length);

            Console.WriteLine(" After work 1");
            Console.WriteLine(" After work 2");
        }

        static async Task<int> ReadFile(string file)
        {
            int length = 0;

            Console.WriteLine(" File reading is stating");
            using (StreamReader reader = new StreamReader(file))
            {
                // Reads all characters from the current position to the end of the stream asynchronously    
                // and ret//urns them as one string.    
                // string s =  reader.ReadToEndAsync();
                string s = await reader.ReadToEndAsync();

                length = s.Length;
            }
            Console.WriteLine(" File reading is completed");
            return length;
        }

        //Example2
        public static async Task callMethod()
        {
            Console.WriteLine(" Method 1 started");
            var abc = await Method1();
           
            var count = await Method2();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" Before Count  of Method2: " + i);
            }
           
            var bb = await Method4();
            Method3(count);
            Console.WriteLine(" Method 1 ends and returns abc = " + abc);
            Console.WriteLine(" Method 4 returns bb = " + bb);
        }

        public static async Task<int> Method2()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(" Method 2.1-" + i);
                    count += 1;
                    Thread.Sleep(1000);
                }
            });


           int count2 = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(" Method 2.2-" + i);
                    count2 += 1;
                    Thread.Sleep(1000);
                }
            });
            return count2;
        }

        public static async Task<int> Method1()
        {
            int count = 0;
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 1 : " + i);
                count++;
                System.Threading.Thread.Sleep(1000);
            }
            return count;
        }

        public static void Method3(int count)
        {
            Console.WriteLine("Method 3 Total count is " + count);
        }

        public static async Task<int> Method4()
        {
            int count = 0;
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 4 : " + i);
                count++;
                Thread.Sleep(1000);
            }
            return count;

        }
    }
}
