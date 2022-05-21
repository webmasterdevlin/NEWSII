namespace NEWSII.Helpers;

public static class BodyTemp
{
    public static string GetBodyTempInput()
    {
        var input = "";
        Console.WriteLine("Body Temp:");
        while (string.IsNullOrEmpty(input))
            input = Console.ReadLine();
        return input;
    }
    
    private static int GetScore(int bodyTemp)
    {
        return bodyTemp switch
        {
            >= 39 and <= 42 => 2,
            >= 38 and <= 39 => 1,
            >= 36 and <= 38 => 0,
            >= 35 and <= 36 => 1,
            >= 32 and <= 35 => 2,
            _ => throw new ArgumentOutOfRangeException($"Body temperature {bodyTemp} is out of range")
        };
    }
    
    public static void AddBodyTempScore(string bodyTempInput, ICollection<int> list)
    {
        if (int.TryParse(bodyTempInput, out var bt))
            list.Add(GetScore(bt));
        else
            throw new ArgumentException("Invalid body temperature input");
    }
}