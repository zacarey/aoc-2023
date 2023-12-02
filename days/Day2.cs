public static class Day2
{
  private static int red = 12;
  private static int green = 13;
  private static int blue = 14;

  public static void Part1()
  {
    string fileContent = File.ReadAllText("input/day2.txt");

    var sum = 0;
    var lines = fileContent.Split("\n");

    for (int idx = 0; idx < lines.Length; idx++)
    {
      var game = lines[idx].Substring(lines[idx].IndexOf(":") + 1);
      var draws = game.Split(";");
      var marbles = new List<string>();
      foreach (var d in draws)
      {
        marbles.AddRange(d.Split(","));
      }

      var possible = true;

      foreach (var m in marbles)
      {
        if ((m.Contains("green") && GetNumber(m) > green)
          || (m.Contains("blue") && GetNumber(m) > blue)
          || (m.Contains("red") && GetNumber(m) > red))
        {
          possible = false;
          break;
        }
      }

      if (possible) sum += idx + 1;
    }

    Console.WriteLine("Day2: {0}", sum);
  }

  public static void Part2()
  {
    string fileContent = File.ReadAllText("input/day2.txt");

    var sum = 0;
    var lines = fileContent.Split("\n");

    for (int idx = 0; idx < lines.Length; idx++)
    {
      var game = lines[idx].Substring(lines[idx].IndexOf(":") + 1);
      var draws = game.Split(";");
      var marbles = new List<string>();
      var r = 1;
      var b = 1;
      var g = 1;
      foreach (var d in draws)
      {
        marbles.AddRange(d.Split(","));

        foreach (var m in marbles)
        {
          if (m.Contains("red") && GetNumber(m) > r) r = GetNumber(m);
          if (m.Contains("blue") && GetNumber(m) > b) b = GetNumber(m);
          if (m.Contains("green") && GetNumber(m) > g) g = GetNumber(m);
        }
      }

      sum += (r * b * g);
    }

    Console.WriteLine("Day2: {0}", sum);
  }

  private static int GetNumber(string s)
  {
    return int.Parse(s.Where(c => char.IsDigit(c)).ToArray());
  }
}