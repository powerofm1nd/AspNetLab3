namespace WebApplicationLab3.Services;

public class TimeService : ITimeService
{
    public string GetTimeOfDay()
    {
        switch (DateTime.Now.Hour)
        {
            case >= 0 and < 6:
                return "Зараз ніч";
            case >= 6 and <= 11:
                return "Зараз ранок";
            case >= 12 and < 18:
                return "Зараз день";
            case >= 18 and <= 23:
                return "Зараз вечір";
            default:
                return "Помилка визначення часу!";
        }
    }
}