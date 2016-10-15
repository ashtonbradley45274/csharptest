using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Person
    {
        private String firstName;
        private String lastName;
        private int age;
        private double weight;
        private int heightCm;

        public Person( String firstName , String lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Person(String firstName, String lastName , int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        
        }

        public Person()
        {


        }

        public override string ToString()
        {
            return this.heightCm + ":" + this.lastName + ":" +
                this.firstName + ":" + this.weight + ":" + this.age;
        }

        public override bool Equals(object obj)
        {
            Person temp = (Person)obj;
            if( temp.age != this.age)
            {
                return false;
            }

            return true;
           
        }

        public double getWeight()
        {
            return this.weight;

        }
        public void setWeight(double weight)
        {
            this.weight = weight;
        }

        public int get_setheightCm
        {
            get { return heightCm; }
            set { heightCm = value; }
        }

        public int get_setage 
         {
            get{return age;}
            set{age = value;}
        }


        

         

    }
}
