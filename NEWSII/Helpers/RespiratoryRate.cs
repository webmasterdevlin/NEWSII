namespace NEWSII.Helpers;

public static class RespiratoryRate
{
    public static string GetRespiratoryRateInput()
    {
        var input = "";
        Console.WriteLine("Respiratory Rate:");
        while (string.IsNullOrEmpty(input))
            input = Console.ReadLine();
        return input;
    }
    
    public static int GetScore(int respiratoryRate)
    {
        return respiratoryRate switch
        {
            >= 24 and <= 60 => 3,
            >= 20 and <= 24 => 2,
            >= 11 and <= 20 => 0,
            >= 8 and <= 11 => 1,
            >= 3 and <= 8 => 3,
            _ => throw new ArgumentOutOfRangeException($"Respiratory rate {respiratoryRate} is out of range")
        };
    }
    
    public static void AddRespiratoryRateScore(string respiratoryRateInput, ICollection<int> list)
    {
        if (int.TryParse(respiratoryRateInput, out var bt))
            list.Add(GetScore(bt));
        else
            throw new ArgumentException("Invalid respiratory rate input");
    }
}