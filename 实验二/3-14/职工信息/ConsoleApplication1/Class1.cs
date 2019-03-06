using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Person
    {
        private String name = "张三";
        private int age = 12;
        public void Display()
        {
            Console.WriteLine("姓名：{0},年龄：{1}", name, age);
        }
        public Person(string Name, int Age)
        {
            name = Name;
            age = Age;
        }
    }

    class Employee : Person
    {
        private string department;
        private decimal salary;
        public Employee(string Name, int Age, string D, decimal S)
            : base(Name, Age)
        {
            department = D;
            salary = S;

        }
        public new void Display()
        {
            base.Display();
            Console.WriteLine("部门：{0},薪金：{1}", department, salary);
        }
    }
}