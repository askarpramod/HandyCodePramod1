using System;
using System.Collections.Generic;
using System.Text;

namespace StringOperations
{
    public class ReverseString
    {
        public void CallMethod()
        {
            string str = "Pramod";
            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string reversedstring = new string(charArray);
            Console.WriteLine(reversedstring);
        }
    //  

    }
}
