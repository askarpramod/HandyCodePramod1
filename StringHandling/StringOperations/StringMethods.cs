using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StringOperations
{
   public class StringMethods
    {
        public void CharNumberSpCharCountInString()
        {
            string str = "abc de12 34!@#";
            int totalCharacter = 0, totalLetterChar = 0, totalDigitChar = 0, totalSpecialChar = 0, whiteSpaceChar = 0;
            char[] strArray = str.ToCharArray();
            foreach (var item in strArray)
            {
                if (char.IsDigit(item))
                    totalDigitChar++;
                if (char.IsLetter(item))
                    totalLetterChar++;
                if (char.IsWhiteSpace(item))
                    whiteSpaceChar++;
                if (!char.IsLetterOrDigit(item))
                    totalSpecialChar++;
                totalCharacter++;
            }

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Entered String : " + str);
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Total Characters In String : " + totalCharacter);
            Console.WriteLine("Total Letter Character String : " + totalLetterChar);
            Console.WriteLine("Total Digit Character String : " + totalDigitChar);
            Console.WriteLine("Total Spaces Character String : " + whiteSpaceChar);
            Console.WriteLine("Total Special Character String : " + totalSpecialChar);
            Console.WriteLine("--------------------------------------------------------");
            Console.ReadKey();
        }

        public void CharOccuranceCountInString()
        {
            Console.Write("Enter the string : ");
            string message = Console.ReadLine();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char ch in message.Replace(" ", string.Empty))
            {
                if (dict.ContainsKey(ch))
                {
                    dict[ch] = dict[ch] + 1;
                }
                else
                {
                    dict.Add(ch, 1);
                }
            }
            foreach (var item in dict.Keys)
            {
                Console.WriteLine(item + " : " + dict[item]);
            }

            Console.WriteLine("**************** Using LINQ now ***********");
            
            Dictionary<char, int> dict2 = message.Replace(" ", string.Empty)
                                         .GroupBy(c => c)
                                         .ToDictionary(gr => gr.Key, gr => gr.Count());
            foreach (var item in dict2.Keys)
            {
                Console.WriteLine(item + " : " + dict[item]);
            }

            Console.WriteLine("**************** Using LINQ 2 now ***********");

            Dictionary<char, int> dict3 = message.GroupBy(c => c)
                                         .ToDictionary(gr => gr.Key, gr => gr.Count());
            foreach (var item in dict3.Keys)
            {
                Console.WriteLine(item + " : " + dict[item]);
            }

        }
        public void TyeMethods()
        {
          string  firstname = "Steven Clark";
          string  lastname = "Clark";

/*
            Console.WriteLine("Clone :" + firstname.Clone());
            // Make String Clone
            Console.WriteLine("CompareTo : " + firstname.CompareTo(lastname));
            //Compare two string value and returns 0 for true and             1 for false
            

             Console.WriteLine(firstname.Contains("ven")); //Check whether specified value exists or not in string

              Console.WriteLine(firstname.EndsWith("n")); //Check whether specified value is the last character of string
                        Console.WriteLine(firstname.Equals(lastname));
            //Compare two string and returns true and false


            Console.WriteLine("Returns HashCode of String : " + firstname.GetHashCode());
            //Returns HashCode of String

            Console.WriteLine(firstname.GetType());
            //Returns type of string

            Console.WriteLine(firstname.GetTypeCode());
            //Returns type of string

            Console.WriteLine(firstname.IndexOf("e")); //Returns the first index position of specified value
            the first index position of specified value


  Console.WriteLine(firstname.ToLower());
            //Covert string into lower case

            Console.WriteLine(firstname.ToUpper());
            //Convert string into Upper case

            Console.WriteLine(firstname.Insert(0, "Hello")); //Insert substring into string

            Console.WriteLine(firstname.IsNormalized());
            //Check Whether string is in Unicode normalization
            from C


               Console.WriteLine(firstname.LastIndexOf("e")); //Returns the last index position of specified value

            Console.WriteLine(firstname.Length);
            //Returns the Length of String

            Console.WriteLine(firstname.Remove(5));
            //Deletes all the characters from begining to specified index.

            Console.WriteLine(firstname.Replace('e', 'i')); // Replace the character

            string[] split = firstname.Split(new char[] { 'e' }); //Split the string based on specified value


            Console.WriteLine(split[0]);
            Console.WriteLine(split[1]);
            Console.WriteLine(split[2]);

            Console.WriteLine(firstname.StartsWith("S")); //Check wheter first character of string is same as specified value

            Console.WriteLine(firstname.Substring(2, 5));
            //Returns substring

            Console.WriteLine(firstname.ToCharArray());
            //Converts an string into char array.

            Console.WriteLine(firstname.Trim());
            //It removes starting and ending white spaces from
            */
        }
    }
}
