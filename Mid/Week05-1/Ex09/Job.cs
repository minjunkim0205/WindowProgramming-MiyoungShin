namespace Ex09;

public class Job : IJob
{
    public double getPay(double hour)
    {
        return hour * 8000;
    }
}