using System;

namespace NumberExample
{
    class Program
    {        
        public static void Main(string[] args)
        {


            PrimeNumber primeObj = new PrimeNumber();
            int numToCheckPrime = 47;
            Console.WriteLine($"Check whethere this number is Prime  : {numToCheckPrime}");
           // Console.WriteLine(@"Check whethere this number is Prime  : {numToCheckPrime}", numToCheckPrime); //Error 
            Console.WriteLine(@"Check whethere this number is Prime  : {0}", numToCheckPrime);

            if (primeObj.IsPrime(numToCheckPrime))
                Console.WriteLine( string.Format("{0} is Prime Number", numToCheckPrime));
            else
                Console.WriteLine(string.Format("{0} is not a Prime number",numToCheckPrime));


            


            /*
            // We will comment this and will make seperate class for each example
            Console.WriteLine((int)Math.Floor(Math.Sqrt(17)));
            if (FindPrime(47))
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
           

            */

            Console.ReadLine();
        }



        //This belolw method is static, as it is being called from static method.
        /// <summary>
        /// FindPrime(47) : true => Console.WriteLine("Prime");
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool FindPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var squareRoot = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= squareRoot; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

    }
}
