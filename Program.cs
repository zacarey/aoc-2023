var watch = System.Diagnostics.Stopwatch.StartNew();

Day4.PartA();

watch.Stop();

var elapsedMs = watch.ElapsedMilliseconds;
Console.WriteLine("Total time: {0}", elapsedMs);