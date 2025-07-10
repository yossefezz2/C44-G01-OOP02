
public class Employee
{
    internal int id { get; set; }
    internal string name { get; set; }
    internal double salary { get; set; }
    internal DateTime hieringDate { get; set; }
    internal Gender gender { get; set; }
    internal SecurityLevel securityLevel { get; set; }

    internal Employee(int id, string name, double salary, DateTime hieringDate, Gender gender, SecurityLevel securityLevel)
    {
        this.id = id;
        this.name = name;
        this.salary = salary;
        this.hieringDate = hieringDate;
        this.gender = gender;
        this.securityLevel = securityLevel;
    }

    public override string ToString()
    {
        return $"Employee Salary {string.Format("{0:C}", salary)}";
    }

    internal string GetHiringDateRemaining()
    {
        HiringDate hiringDate = new HiringDate(this.hieringDate.Day, this.hieringDate.Month, this.hieringDate.Year);
        return hiringDate.remaining(); 
    }
}
