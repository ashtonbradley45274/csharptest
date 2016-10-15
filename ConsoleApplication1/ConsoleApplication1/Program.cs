using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {

            Person A = new Person("Ashton", "Bradley");
            Person B = new Person();
            A.get_setage = 45;
            A.get_setheightCm = 89;
            A.setWeight(900);
            String temp = A.ToString();
           Console.WriteLine(A.ToString());
            Console.WriteLine(temp);

            Console.ReadLine(); 



        }
    }
}
