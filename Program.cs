namespace Assignment_10._2._2
{
    public  class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employee = new List<Employee>()
           {
               new Employee() { FirstName = "Jake", LastName = "Wislon", Salary = 5000, Age = 29},
               new Employee() { FirstName = "Tyler", LastName = "Schoonover", Salary = 5500, Age = 48},
               new Employee() { FirstName = "Roger", LastName = "Lukes", Salary = 4500, Age = 65},
               new Employee() { FirstName = "Derrick", LastName = "Bostic", Salary = 5900, Age = 29},
               new Employee() { FirstName = "John", LastName = "Farris", Salary = 5500, Age = 28}
           };
            var topEmployee = from list in Employee where list.Salary >= 5000 && list.Age < 30 select list;

            foreach (var emp in topEmployee)
            {
                Console.WriteLine(emp.FirstName);
            }
        }
       
    }
}
