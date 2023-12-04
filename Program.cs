var watch = System.Diagnostics.Stopwatch.StartNew();

Day1.PartB();

watch.Stop();

var elapsedMs = watch.ElapsedMilliseconds;
Console.WriteLine("Total time: {0}", elapsedMs);