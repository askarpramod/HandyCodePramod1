using System;
using System.Collections.Generic;
using System.Text;

namespace NumberExample
{
    public class PrimeNumber
    {
       public bool IsPrime(int number)
        {
           // bool isPrime = false;
            if (number == 1)  //Not a Prime number
                return false;
            if (number == 2)
                return true; //Yes it is Prime number 
            if (number % 2 == 0)
                return false; //Not a Prime number 
            int loopLimit = (int)Math.Floor(Math.Sqrt(number));
            for (int i =3; i<= loopLimit; i +=2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
