public static class Day3
{
  public static void PartA()
  {
    int sum = 0;

    var data = GetData();

    int xMax = data.GetLength(0);
    int yMax = data.GetLength(1);

    for (var y = 0; y < yMax; y++)
    {
      for (var x = 0; x < xMax; x++)
      {
        if (IsSymbol(data[y, x]))
        {

          // check top
          if (y > 0)
          {
            sum += int.Parse(GetNumber(data, y + 1, x) ?? "0");
          }

          // check top right
          if (y > 0 && x < xMax)
          {
            sum += int.Parse(GetNumber(data, y + 1, x + 1) ?? "0");
          }

          // check top left
          if (y > 0 && x > 0)
          {
            sum += int.Parse(GetNumber(data, y + 1, x - 1) ?? "0");
          }

          // check left
          if (x > 0)
          {
            sum += int.Parse(GetNumber(data, y, x - 1) ?? "0");
          }

          // check right
          if (x < xMax)
          {
            sum += int.Parse(GetNumber(data, y, x + 1) ?? "0");
          }

          // check bottom 
          if (y + 1 < yMax)
          {
            sum += int.Parse(GetNumber(data, y - 1, x) ?? "0");
          }

          // check bottom left 
          if (y + 1 < yMax && x > 0)
          {
            sum += int.Parse(GetNumber(data, y - 1, x - 1) ?? "0");
          }

          // check bottom right
          if (y + 1 < yMax && x < xMax)
          {
            sum += int.Parse(GetNumber(data, y - 1, x + 1) ?? "0");
          }
        }
      }
    }

    Console.WriteLine("Day3: {0}", sum);
  }

  public static string? GetNumber(char[,] arr, int y, int x)
  {
    var t = arr[y, x];
    if (!char.IsNumber(arr[y, x])) return null;

    string number = arr[y, x].ToString();
    arr[y, x] = '.';

    int rightIdx = x + 1, leftIdx = x - 1;
    while (rightIdx < arr.GetLength(0))
    {
      if (char.IsDigit(arr[y, rightIdx]))
      {
        number += arr[y, rightIdx].ToString();
        arr[y, rightIdx] = '.';
        rightIdx++;
      }
      else rightIdx = arr.GetLength(0) + 1;
    }

    while (leftIdx >= 0)
    {
      if (char.IsDigit(arr[y, leftIdx]))
      {
        number = arr[y, leftIdx].ToString() + number;
        arr[y, leftIdx] = '.';
        leftIdx--;
      }
      else leftIdx = -1;
    }

    return number;
  }

  private static char[,] GetData()
  {
    string fileContent = File.ReadAllText("input/day3.txt");

    var lines = fileContent.Split("\n");

    var arr = new char[lines[0].Length, lines.Length];

    for (int y = 0; y < lines[0].Length; y++)
    {
      for (int x = 0; x < lines.Length; x++)
      {
        arr[y, x] = lines[y][x];
      }
    }

    return arr;
  }

  public static bool IsSymbol(char c)
  {
    return !char.IsDigit(c) && c != '.';
  }
}

