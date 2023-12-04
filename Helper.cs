public static class Helper
{
  public static char[,] GetDataArray(string file)
  {
    string fileContent = File.ReadAllText(file);

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

  public static string[] GetDataLines(string file)
  {
    string fileContent = File.ReadAllText(file);

    var lines = fileContent.Split("\n");

    return lines;
  }
}