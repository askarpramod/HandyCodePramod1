using System;

namespace OOPConcepts
{
    class Program
    {
        static void Main(string[] args)
        {


            //Error CS7036  There is no argument given that corresponds to the required formal parameter 's' of 'BaseVar.BaseVar(string)'   OOPConcepts C:\Data\Project\DotNetMVCProject\MVCSoln\OOPConcepts\Program.cs 10  Active
            // BaseVar obj00 = new BaseVar(); // above comile err : empty ctor not there so try to match to other 1 param ctor
            //BaseVar obj02 = new ChildVar(); //There is no argument given that corresponds to the required formal parameter 's' of 'ChildVar.ChildVar(string)'

            //BAse class variable initialization through child class constructor  
            BaseVar obj0 = new BaseVar("P0");
            BaseVar obj2 = new ChildVar("P0");
            ChildVar obj3 = new ChildVar("P0");


            Console.ReadKey();
            //  if a class have static constructor then on creation of an object of the class static constructor will be called then class constructor.
            ConstructorCall1 obj = new ConstructorCall1();

            //In inheritance C# oops relationship, when we create object of a derived or child class then first base class constructor then derived class constructor get called.
            //Base class constructor
            //2nd constructor
            //class constructor
            ConstructorCall2 obj1 = new ConstructorCall2();


            // https://www.c-sharpcorner.com/UploadFile/8a67c0/method-overloading-and-method-overriding-in-C-Sharp/
            Console.WriteLine("You cannot create method overloaded vary only by return type!");
            // Console.WriteLine("Signature includes 

            Overload objOverload = new Overload();
            Console.WriteLine("Add with two int parameter :" + objOverload.Add(3, 2));
            Console.WriteLine("Add with two float parameter :" + objOverload.Add(3M, 22M));
            Console.WriteLine("Add with three int parameter :" + objOverload.Add(3, 2, 8));
            Console.WriteLine("Add with two float parameter :" + objOverload.Add(3F, 22F));
            Console.WriteLine("Add with two string parameter :" + objOverload.Add("hello", "world"));
            Console.ReadLine();

            //////////////////  Inheritance  ///////////////////////////
            Console.WriteLine("********************Inheritance Grandpa grpaObj =    new Grandpa() ");

            Grandpa grpaObj = new Grandpa();
            grpaObj.Show();

            Console.WriteLine("********************  Grandpa grpaObj =   new Grandpa(80) ");
            grpaObj = new Grandpa(54);
            grpaObj.Show();

            Console.WriteLine("********************  Grandpa grpaObj =   new Papa() ");
            grpaObj = new Papa();
            grpaObj.Show();

            Console.WriteLine("********************  Grandpa grpaObj =   new Papa(54) "); // Generally Parent class method gets call, only if Vertual/Override method available then only child method get called 
            grpaObj = new Papa(54);
            grpaObj.Show();
            grpaObj.print();

            Console.WriteLine("********************  Papa papaObj =   new Papa(54) ");
            Papa papaObj = new Papa(54);
            papaObj.Show();
            papaObj.print();

            //https://www.interviewsansar.com/order-of-constructor-and-destructor-call-in-csharp-interview-qa/

            //Constructor calling is from Top to bottom + Destructor calling sequence is from bottom to top 

            /*********************************
             ********************Inheritance Grandpa grpaObj =    new Grandpa()
            Grandpa CTOR
            Grandpa Show
            ********************  Grandpa grpaObj =   new Grandpa(80)
            Grandpa CTOR Age is : 54
            Grandpa Show
            ********************  Grandpa grpaObj =   new Papa()
            Grandpa CTOR
            Papa CTOR
            Grandpa Show
            ********************  Grandpa grpaObj =   new Papa(54)
            Grandpa CTOR Age is : 54
            Papa CTOR Age is : 54
            Grandpa Show  //Papa Show method made new still calls Grandpa Show method 
            Papa Print
            ********************  Papa papaObj =   new Papa(54)
            Grandpa CTOR Age is : 54
            Papa CTOR Age is : 54
            Papa Show
            Papa Print
             * ******************************/

            //   Console.WriteLine("********************  Papa papaObj =  (papa) new Grandpa(54) ");
            //   papaObj =  new Grandpa(54);  // Error Compile eror : Can not implicitly convert type Grandpa to Papa 
            //papaObj = (Papa)new Grandpa(54);  // Runtime Error : Invalid to cast 
            //papaObj.Show();
            //papaObj.print();

            Console.ReadKey();
        }
    }
}
