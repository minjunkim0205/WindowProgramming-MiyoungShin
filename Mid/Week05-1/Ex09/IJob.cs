namespace Ex09;

public interface IJob
{
    public double getPay(double hour)
    {
        return hour * 8000;
    }
}