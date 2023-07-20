public class Program
{
    static void Main()
    {
        Print print = new();

        print.PrintValue(new Student() { Marks = 5 });
        print.PrintValue(new Employee() { Salary = 1000 });
    }
}