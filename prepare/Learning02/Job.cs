public class Job
{
    public string _jobCompany = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_jobCompany}) {_startYear}-{_endYear}");
    }
}
