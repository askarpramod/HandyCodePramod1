using System;
using System.Text;
//using System.Text;

namespace StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            //DateTime 
            DateTimeClass dtObj = new DateTimeClass();
            // dtObj.ShowDiffFormat();
            //https://dotnettutorials.net/lesson/how-to-find-the-angle-between-hour-and-minutehands-of-a-clock-at-any-given-time/
            dtObj.GetAngleBetweenHourAndMinuteHand1(); 
            dtObj.GetAngleBetweenHourAndMinuteHand2();
            Console.ReadKey();
            //count char from string 
            StringMethods strObj = new StringMethods();            
            strObj.CharNumberSpCharCountInString();
            //https://dotnettutorials.net/lesson/character-occurrence-in-a-string-csharp/
            strObj.CharOccuranceCountInString();
            //
            findallsubstring("car");
            //

            //Reverse the string 
            ReverseString reverseObj = new ReverseString();
            reverseObj.CallMethod();

            //  System.Text.StringBuilder sb = new System.Text.StringBuilder();

            //https://stackoverflow.com/questions/756055/listing-all-permutations-of-a-string-integer
            //String word Permutation to form possible words
            PermutationWords PermWordObj = new PermutationWords();
            PermWordObj.CallMethod();


          //  StringMethods strObj = new StringMethods();
            strObj.TyeMethods();
            
           
        }

        internal static void findallsubstring(string str)
        {
            for (int i = 0; i < str.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(str.Length - i);
                for (int j = i; j < str.Length; ++j)
                {
                    subString.Append(str[j]);
                    Console.Write(subString + " ");
                }
            }
            Console.ReadKey();
        }

    }
}
