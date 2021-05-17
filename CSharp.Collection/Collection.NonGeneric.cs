using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Collection
{
    /// <summary>
    /// C# ArrayList
    /// ArrayList class is a collection that can be used for any types or objects.
    /// Arraylist is a class that is similar to an array, but it can be used to store values of various types.
    /// An Arraylist doesn't have a specific size.
    ///Any number of elements can be stored
    /// </summary>
    public class CollectionArrayList
    {
        //  public class ArrayList : ICollection, IEnumerable, IList, ICloneable
        public void CallMe()
        {
            ArrayList al = new ArrayList();
            string str = "Pramod Arraylist";
            int x = 7;
            DateTime d = DateTime.Parse("8-oct-1985");
            al.Add(str);
            al.Add(x);
            al.Add(d);

            foreach (object o in al)
            {
                Console.WriteLine(" " + o);
            }
        }
    }

    /// <summary>
    /// HashTable is similar to arraylist but represents the items as a combination of a key and value
    /// Different type data is fine
    /// </summary>
    public class HashTable
    {
        //public class Hashtable : ICollection, IEnumerable, IDictionary, ICloneable, IDeserializationCallback, ISerializable
        public void CallMe()
        {
            //https://www.c-sharpcorner.com/blogs/difference-between-dictionary-and-hashtable-in-c-sharp
            Dictionary<int, int> dicObj = new Dictionary<int, int>(); //faster than Hashtable


            Hashtable ht = new Hashtable();
            ht.Add("ora", "oracle");
            ht.Add("vb", "vb.net");
            ht.Add("cs", "cs.net");
            ht.Add(2, "asp.net");

            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + " " + d.Value);
                Console.WriteLine();

            }
        }
    }

    /// <summary>
    /// Same type data to be added
    /// </summary>
    public class SortedListClass
    {
        //public class SortedList : ICollection, IEnumerable, IDictionary, ICloneable
        public void CallMe()
        {
            SortedList sl = new SortedList();
            sl.Add("ora", "oracle");
            sl.Add("1", "vb.net");
            sl.Add("cs", "cs.net");
            // sl.Add(2, "asp.net"); : Exception : System.InvalidOperationException: 'Failed to compare two elements in the array : ...it must be of string etc
            sl.RemoveAt(1);
            foreach (DictionaryEntry d in sl)
            {
                Console.WriteLine(d.Key + " " + d.Value);
                Console.WriteLine();
            }
            //public class SortedList : ICollection, IEnumerable, IDictionary, ICloneable
            SortedList s2 = new SortedList();
            /*   s2.Add(1, "oracle");
               sl.Add(2, "vb.net"); */ //ArgumentException: Object must be of type String
                                       //Exception : System.InvalidOperationException: 'Failed to compare two elements in the array : ...it must be of string etc

            foreach (DictionaryEntry d in s2)
            {
                Console.WriteLine(d.Key + " " + d.Value);
                Console.WriteLine();
            }
        }
    }

    public class StackClass
    {
        public void CallMe()
        {
            Stack stk = new Stack();
            stk.Push("stack1 cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("sqlserver");

            foreach (object o in stk)
            {
                Console.WriteLine("stack " + o);
            }
        }
    }

    public class QueueClass
    {
        public void CallMe()
        {
            Queue q = new Queue();
            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sqlserver");

            foreach (object o in q)
            {
                Console.WriteLine("queue " + o);
            }
        }
        /*
        public class aaa12
        {
            public void CallMe()
            {

            }
        }

        public class a1aa
        {
            public void CallMe()
            {

            }
        }
        */

    }

}
