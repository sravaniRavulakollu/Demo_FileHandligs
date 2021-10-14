using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Data_FileHandling
{
    class Class1
    {
    }
    class A
    {
        public void display()
        {
            System.Console.WriteLine(" Hi I am Parent class Method");
        }
    }
    class B : A
    {
        public void display1()
        {
            base.display();
            System.Console.WriteLine("I am child class method");
        }
    }

}
