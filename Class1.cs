public class Employee
{
    private int _salary;

    public int Salary
    {
        get { return _salary; }
        set { _salary = value; }
    }
}

public class Student
{
    private int _marks;

    public int Marks
    {
        get { return _marks; }
        set { _marks = value; }
    }
}

public class Print
{
    public void PrintValue<T>(T obj) where T : class
    {
        if (obj.GetType() == typeof(Student))
        {
            Student temp = obj as Student; //obj must be downcasted(safety with 'as') because obj is Object type as parameter
            Console.WriteLine(temp.Marks);
        }
        else if (obj.GetType() == typeof(Employee))
        {
            Employee temp = obj as Employee;
            Console.WriteLine(temp.Salary);
        }
    }
}
