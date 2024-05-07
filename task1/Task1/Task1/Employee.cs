using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace task2
{
    enum Gender          // why cannot navigate enum >> its interfaces >> something common between it and int to make same signature >> func take enum , other take int salary?????
    {
        male = 0,
        female = 1,
    }
    internal class Employee 
    {
        public Gender gender { get; set; }
        public string name { get; set; }
        public float salary { get; set; }

        public Action<float> salaryIncreased;
        public Employee(string name, float salary , Gender gender) 
        {
            this.name = name;
            this.salary = salary;
            this.gender = gender;
        }

        public void increaseSalary (float amount)
        {
            this.salary += amount;
            salaryIncreased(amount);
        }
        public override string ToString()
        {
            return $"this is a description for employee his name is {name} , salary is {salary} and gender is {gender}";
        }
    }
}
