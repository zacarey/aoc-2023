
public static class Day4
{
  public static void PartA()
  {
    int sum = 0;

    var lines = Helper.GetDataLines("input/day4.txt");

    for (int idx = 0; idx < lines.Length; idx++)
    {
      var lotto = lines[idx].Substring(lines[idx].IndexOf(":") + 1);
      var lottoSplit = lotto.Split("|");

      var winning = lottoSplit[0].Split(" ");
      var yours = lottoSplit[1].Split(" ");
      var count = yours.Where(i => winning.Contains(i) && i != "").Count();

      sum += GetScore(count);
    }

    Console.WriteLine("Total: {0}", sum);
  }

  public static void PartB()
  {
    int sum = 0;


    Console.WriteLine("Total: {0}", sum);
  }

  public static int GetScore(int total)
  {
    if (total == 0) return 0;
    if (total == 1) return 1;
    total--;
    var score = 1;
    for (int i = 1; i < total + 1; i++)
    {
      score = score * 2;
    }
    return score;
  }
}

