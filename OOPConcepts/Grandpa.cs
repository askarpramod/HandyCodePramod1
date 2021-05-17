using System;
using System.Collections.Generic;
using System.Text;

namespace OOPConcepts
{
    public interface IHuman
    {
        public void show(string str);
        public void show2(string str)
        {
            Console.WriteLine($"22str is : {str}");
        }
    }
    public class Human : IHuman
    {
        public void show(string str)
        {
            Console.WriteLine($"str is : {str}");
        }
        public void show2(string str)
        {
            Console.WriteLine($"22str is : {str}");
        }

        //void show(string str)
        //{
        //    Console.WriteLine($"str is : {str}");
        //}
    }
    class Grandpa
    {
        public Grandpa()
        {
            Console.WriteLine("Grandpa CTOR");
        }
        public Grandpa(int age)
        {
            Console.WriteLine("Grandpa CTOR Age is : "+age);
        }
        public void Show()
        {
            Console.WriteLine("Grandpa Show");
        }

        public virtual void print()
        {
            Console.WriteLine("Grandpa Print");
        }
    }
    class Papa : Grandpa
    {
        public Papa()
        {
            Console.WriteLine("Papa CTOR");
        }
        public Papa(int age) : base(age)
        {
            Console.WriteLine("Papa CTOR Age is : " + age);
        }
        // public void Show() //It hides inherited memebr , use New if hide is intended 
        public new void Show()
        {
            Console.WriteLine("Papa Show");
        }
        public override void print()
        {
            Console.WriteLine("Papa Print");
        }
    }
}
