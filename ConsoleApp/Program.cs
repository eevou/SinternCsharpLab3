namespace lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee emp1 = new Employee();
            Console.Write("ID: ");
            emp1.Id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            emp1.Name = Console.ReadLine();
            Console.Write("Age: ");
            emp1.Age = int.Parse(Console.ReadLine());
            Console.Write("Salary: ");
            emp1.Salary = int.Parse(Console.ReadLine());
            emp1.Display();
            Console.WriteLine($"Total Employees Created: {Employee.GetCount()}");


            Employee[] employees = new Employee[3];

            // Read Employees from user
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Enter Employee {i + 1} data:");

                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Salary: ");
                int salary = int.Parse(Console.ReadLine());

                employees[i] = new Employee(id, name, age, salary);
            }

            Console.WriteLine("\nEmployees Data:");
            foreach (var emp in employees)
            {
                emp.Display();
            }

            Console.WriteLine($"\nTotal Employees Created: {Employee.GetCount()}");
        }
    }
}

