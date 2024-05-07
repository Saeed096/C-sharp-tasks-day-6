using task2;

namespace Task1
{
    internal class Program
    {
       public void isRich(Employee e)
        {
            
        }
        static void Main(string[] args)
        {


            Console.WriteLine("Hello, World!");
            Company c1 = new Company("vodafone", 100000.50f);

            Employee e1 = new Employee("saeed", 100.25f, Gender.male);
            Employee e2 = new Employee("basma", 200.50f, Gender.female);
            Employee e3 = new Employee("basem", 3000.25f, Gender.male);
            Employee e4 = new Employee("sayed", 4000.25f, Gender.male);

            c1.add(e1);
            c1.add(e2);
            c1.add(e3);
            c1.add(e4);

            Console.WriteLine(c1.budget);
            e1.increaseSalary(500);
            Console.WriteLine(c1.budget);



            List<Employee> RichEmployees = c1.filterEmployees(e => e.salary > 1000);
            Console.WriteLine("rich employees");
            for(int i = 0; i < RichEmployees.Count; i++)
            {
                Console.WriteLine(RichEmployees[i].ToString());
            }


            List<Employee> maleEmployees = c1.filterEmployees(e => e.gender == Gender.male );
            Console.WriteLine("male employees");
            for (int i = 0; i < maleEmployees.Count; i++)
            {
                Console.WriteLine(maleEmployees[i].ToString());
            }
        }
    }
}
