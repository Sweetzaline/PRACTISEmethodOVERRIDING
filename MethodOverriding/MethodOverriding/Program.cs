using System;

namespace MethodOverriding
{
    class Class1
    {
         public void Show()
        {
            Console.WriteLine("Parent's Show method is called.");
        }
        public virtual void Test()// this method is overridable.the parent class is giving permission to the child class for over riding.
        {
            Console.WriteLine("Parent's Test method is called.");
        }
    }

    class Class2 : Class1
    {
        public void Show(int i) //OverLoading Parent's method under child class, No permission is needed.
        {
            Console.WriteLine("Child's Show method is called.");
        }
        public override void Test()//OverRiding Parent'method in child class, with permission(virtual keyword), and override keyword.
        {
            Console.WriteLine("Child's Test method is called, by Overriding.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Let's learn Method Overriding.\n");
            Class2 obj = new Class2();
            obj.Show();
            obj.Show(10);
            obj.Test();
            obj.Test();
            Console.ReadLine();
        }
        
    }
}
