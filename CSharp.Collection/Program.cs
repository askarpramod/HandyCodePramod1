using System;

namespace CSharp.Collection
{
    /// <summary>
    ///  https://www.c-sharpcorner.com/UploadFile/736bf5/collection-in-C-Sharp/
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
                     
            //ArrayList
            CollectionArrayList objArrayList = new CollectionArrayList();
         //   objArrayList.CallMe();

            //HashTable
            HashTable htObj = new HashTable();
          htObj.CallMe();

            SortedListClass slObj = new SortedListClass();
            slObj.CallMe();

            StackClass stackObj = new StackClass();
            stackObj.CallMe();

            QueueClass QObj = new QueueClass();
            QObj.CallMe();
        }
    }
}
