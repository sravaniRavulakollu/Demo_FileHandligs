using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Data_FileHandling
{
    class Hirareical_Democs
    {
    }
    class car
    {
        public string Engine_Type { get; set; }
        public int warranty { get; set; }
        public string name { get; set; }
        public void TopSpeed()
        {
            System.Console.WriteLine("Drive Safe");
        }
    }
    class Maruti : car
    {
        public void car_Message()
        {
            System.Console.WriteLine("Maruti: Drive Safe");
        }
    }
    class Hyundai : car
    {
        public void car_Display()
        {
            System.Console.WriteLine("Hyundai:Drive Safe");
        }
    }
    class Honda : car
    {
        public void display()
        {
            System.Console.WriteLine("Honda: Drive Safe");
        }
    }
    class KIA : Hyundai
    {
        public void display1()
        {
            System.Console.WriteLine("KIA: Drive Safe");
        }
    }
}



