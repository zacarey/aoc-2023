public static class Day1
{
  public static void Run()
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
}