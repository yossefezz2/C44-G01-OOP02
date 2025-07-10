
internal class Company
{
    internal Employee[] employees;
    internal Company(int size)
    {
        employees = new Employee[size];
    }
    public override string ToString()
    {
        return $"First Employee Name : {employees[0].name}\nSecond Employee Name : {employees[1].name}\nThird Employee Name : {employees[2].name}";
    }

}

