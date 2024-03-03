using System;
namespace Constructor1
{
   public class Program
   {
        string name, designation;
        int bsalary, noofexp, insurance;
        float hra, ta, grosspay;
        public employee(string name, string designation, int bsalary, int noofexp, int insurance)
        {
            this.name = name;
            this.designation = designation;
            this.bsalary = bsalary;
            this.noofexp = noofexp;
            this.insurance = insurance;

        }
        public void salary()
        {
            hra = (20 / 100) * bsalary;
            ta = (10 / 100) * bsalary;
            grosspay = bsalary + hra + ta - insurance;
        }
        public void display()
        {
            Console.WriteLine("{0} working as {1} having experience of {2} years with a salary of {3}", this.name, this.designation, this.noofexp, this.grosspay);
        }
   }
   public class Exp3
   {
       static void Main(String[] args)
       {
            employee obj1 = new employee("Kousi", "Tester", 45000, 3, 1000);
            employee obj2 = new employee("Ronick", "Tester", 50000, 4, 1000);
            obj1.salary();
            obj2.salary();
            obj1.display();
            obj2.display();
       }
   }
}

