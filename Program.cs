using System;

namespace Demo_Data_FileHandling
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!\n");
            B b = new B();
            b.display();
            b.display1();
            car obj = new car();
            obj.TopSpeed();
            Maruti obj1 = new Maruti();
            obj1.Engine_Type = "Manual";
            obj1.name = "Audi";
            obj1.warranty = 10;
            System.Console.WriteLine("Features of Maruti:\n {0}\n{1}\n{2}\n", obj1.Engine_Type, obj1.name, obj1.warranty);
            Hyundai obj2 = new Hyundai();
            obj2.TopSpeed();
            obj2.Engine_Type = "Automatic";
            obj2.warranty = 5;
            obj2.name = "BMW";
            System.Console.WriteLine("Features of Hyundai:\n Engine_Type: {0}\n Warranty: {1}\n car name:{2}\n", obj2.Engine_Type, obj2.warranty, obj2.name);
            KIA obj3 = new KIA();
            obj3.Engine_Type = "Automatic";
            obj3.TopSpeed();
            obj3.name = "RangeRover";
            System.Console.WriteLine("Features of KIA:\n Engine_Type: {0}\n car name:{1}\n Warranty:{2}\n", obj3.Engine_Type, obj3.name, obj3.warranty);
            System.Console.WriteLine("Multiple Inheritance using Interfaces\n");
            Animal a = new Animal();
            a.speak();
            a.Food();
            Speak s = a;
            s.message();
        }

    }
}
        










  
