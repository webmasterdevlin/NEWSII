namespace NEWSII.Helpers;

public static class HeartRate
{
    public static string GetHeartRateInput()
    {
        var input = "";
        Console.WriteLine("Heart Rate:");
        while (string.IsNullOrEmpty(input))
            input = Console.ReadLine();
        return input;
    }
    
    public static int GetScore(int heartRate)
    {
        return heartRate switch
        {
            >= 130 and <= 220 => 3,
            >= 110 and <= 130 => 2,
            >= 90 and <= 110 => 1,
            >= 50 and <= 90 => 0,
            >= 40 and <= 50 => 3,
            >= 25 and <= 40 => 3,
            _ => throw new ArgumentOutOfRangeException($"Heart rate {heartRate} is out of range")
        };
    }
    public static void AddHeartRateScore(string heartRateInput, ICollection<int> list)
    {
        if (int.TryParse(heartRateInput, out var bt))
            list.Add(GetScore(bt));
        else
            throw new ArgumentException("Invalid heart rate input");
    }
}