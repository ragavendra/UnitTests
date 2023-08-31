using Xunit;
using UnitTests.Helpers;
using Polly;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;
namespace UnitTests.Sorting;

public class GeneralTests
{
    // Test to check if an array is sorted
    [Fact]
    public void CheckPolly()
    {
        List<Action> la = new List<Action>();
        la.Add(ThrowExcpn);
        la.Add(PrintLine);
        // la.Add(new Action(() => throw new ArgumentException("Arg excpn!")));
        // la.Add(new Action(() => Console.WriteLine("Line write")));

        var policy = Policy.Handle<SocketException>()
        .WaitAndRetryForever(
        // retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)),
        sleepDurationProvider: retryAttempt => TimeSpan.FromSeconds(3),
        onRetry: (exception, timespan, context) =>
        {
            Console.WriteLine("Attempt {0} - Trying to run in {1} s.", timespan, context);
            // Logger.LogInformation("Context is {0}", context);
            // lets not have this
            /*
                            if (la.Remove(ch))
                            {
                            }

                            foreach(var ele in la)
                            {
                                Console.WriteLine("Ele in " + ele.Target);
                            }*/
        });

        // foreach (var item in la)
        Parallel.ForEach(la, ch =>
        {

            Console.WriteLine("Pinging {0} now.");

            // on fail, this is running again*
            policy.Execute(ch
            );
        });
    }

    private void ThrowExcpn()
    {
        Console.WriteLine("Will thrw expn.");
        throw new SocketException(1);
    }

    private void PrintLine()
    {
        Console.WriteLine("Line write");
    }

    [Fact]
    public void CheckTask()
    {
        Task task = new Task(SomeTask);
        task.Start();
        Console.WriteLine("Out of task now");
    }

    private void SomeTask()
    {
        Task.Delay(TimeSpan.FromSeconds(6));
        Console.WriteLine("In task now");
    }

    [Fact]
    public void CheckTask_()
    {
        SomeTask_();
        Console.WriteLine("Out of task now");
    }

    private async void SomeTask_()
    {
        // no await, task will run async
        await Task.Delay(TimeSpan.FromSeconds(6));

        // Thread.Sleep(TimeSpan.FromSeconds(6));
        Console.WriteLine("In async task now");
    }
}