public static class Day1
{
  public static void PartA()
  {
    string fileContent = File.ReadAllText("input/day1.txt");

    var sum = 0;
    var lines = fileContent.Split("\n");

    foreach (string i in lines)
    {
      var num = i.First(char.IsDigit).ToString() + i.Last(char.IsDigit).ToString();
      sum += int.Parse(num);
    }

    Console.WriteLine("Day1: {0}", sum);
  }

  private static string[] numbers = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];

  public static void PartB()
  {
    string fileContent = File.ReadAllText("input/day1.txt");

    var sum = 0;
    var lines = fileContent.Split("\n");

    foreach (string i in lines)
    {
      string? number = null, first = null, last = null;
      for (var idx = 0; idx < i.Length; idx++)
      {
        var str = i.Substring(idx, i.Length - idx);
        number = StartsWithNumber(str);

        if (number != null)
        {
          if (first == null) first = number;
          last = number;
        }
      }

      sum += int.Parse(first + last);
    }

    Console.WriteLine("Day1: {0}", sum);
  }

  private static string? StartsWithNumber(string s)
  {
    string? result = null;

    if (s.Length <= 0) return result;

    if (char.IsDigit(s[0]))
    {
      return s[0].ToString();
    }

    for (var i = 0; i < numbers.Length; i++)
    {
      if (s.StartsWith(numbers[i]))
      {
        return i.ToString();
      }
    }

    return result;
  }
}