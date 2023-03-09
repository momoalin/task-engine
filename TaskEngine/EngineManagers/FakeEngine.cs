using System.Diagnostics;

class FakestEngine
{
    protected void FakeEngineBeingBusy(int minute_X, int minute_Z)
    {
        Random rand = new Random(DateTime.Now.Millisecond);

        int minSeconds = minute_X * 30;//*60
        int maxSeconds = minute_Z * 30;//*60

        double sleepSeconds = rand.Next(minSeconds, maxSeconds);
        ShowStatus(sleepSeconds);
        
        Task.Factory.StartNew(() =>
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            while (stopwatch.Elapsed.TotalSeconds < sleepSeconds - 10) { 
                Interaction();
                ShowStatus(sleepSeconds - stopwatch.Elapsed.TotalSeconds);
            }
        });
        Thread.Sleep((int)sleepSeconds * 1000);
        Console.WriteLine($"\nTask execution finished");
    }

    private static void ShowStatus(double sleepSeconds)
    {
        Console.WriteLine($"Task execution finishes in {sleepSeconds / 60:0.####} minutes");
    }

    private static void Interaction()
    {
        Console.WriteLine("\nMeanwhile, please type something in to interact");
        var txt = Console.ReadLine();
        Console.WriteLine($"Got it, {txt}");
    }
}