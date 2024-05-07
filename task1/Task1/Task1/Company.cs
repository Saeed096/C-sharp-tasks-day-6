using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2;

namespace Task1
{
    internal class Company
    {
        public string Name { get; set; }
        public float budget { get; set; }

       public List<Employee> workingEmplyees = new List<Employee>();

        public Company(string name , float budget) 
        {
          this.Name = name;
          this.budget = budget;
        } 
        
        public void add(Employee e)
        {
            e.salaryIncreased = decreaseBudget;
            workingEmplyees.Add(e);
        }

        void decreaseBudget(float amount)
        {
            this.budget -= amount;
        }


         public List<Employee> filterEmployees(Func<Employee,bool> filter) // how employee without override???  can deal with custom types
        {
            List<Employee> filteredEmployees = new List<Employee>();
          for(int i = 0; i < workingEmplyees.Count; i++)
           {
                if (filter(workingEmplyees[i]))
                {
                    filteredEmployees.Add(workingEmplyees[i]);
                }
           }
          return filteredEmployees;
        }
    }
}
