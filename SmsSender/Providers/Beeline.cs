namespace SmsSender.Providers;

public class Beeline : ISmsSender
{
    public string Send()
    {
        return "Hello From Beeline";
    }
}