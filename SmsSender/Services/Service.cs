namespace SmsSender.Services;

public class Service : IService
{
    private readonly ISmsSender _smsSender;

    public Service(ISmsSender smsSender)
    {
        _smsSender = smsSender;
    }

    public string Execute()
    {
       return _smsSender.Send();
    }
}