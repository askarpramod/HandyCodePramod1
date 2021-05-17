using System;
using System.Collections.Generic;
using System.Text;

namespace OOPConcepts
{
    //public class ConstructorCall
    // {
    // }
    class ConstructorCall1
    {
        static ConstructorCall1()
        {
            Console.WriteLine("Static consturctot A \n");
        }

        public ConstructorCall1()
        {
            Console.WriteLine("Class consturctot A \n");
        }
    }

    class Base
    {
        public Base()
        {
            Console.WriteLine("Base class constructor \n");
        }

    }
    class ConstructorCall2 : Base
    {
        //public ConstructorCall2()
        //{
        //    Console.WriteLine(" class constructor \n");
        //}
        public ConstructorCall2() : this(string.Empty)
        {
            Console.WriteLine(" class constructor \n");
        }

        public ConstructorCall2(string name)
        {
            Console.WriteLine(" 2nd constructor \n");
        }

    }

    ///// BAse class variable initialization through child class constructor
    class BaseVar
    {
       String str="P1"; // First property is initialized then constructor
       string str2 { get; set; }
        static string str3 = "Pramod1";

        public BaseVar(String s1)
        {
            this.str = s1;
            this.str2 = s1;
         
        }
        public void display()
        {
            Console.Write(str);
        }
    }
    class ChildVar : BaseVar
    {
        
        public ChildVar(String s)
            : base(s)
        {
            Console.Write(s);
        }
    }

}
