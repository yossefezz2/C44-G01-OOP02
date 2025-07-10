
internal class HiringDate
{
    private int day;
    private int month;
    private int year;
    internal HiringDate(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    internal string remaining()
    {
        DateTime currentDate = DateTime.Now;
        DateTime hiringDate = new DateTime(this.year, this.month, this.day);
        TimeSpan remainingTime = hiringDate - currentDate;
        if (remainingTime.TotalDays < 0)
        {
            return "Hiring date is in the past";
        }
        return $"Remaining days until hiring date: {remainingTime.Days} days";
    } 

}

