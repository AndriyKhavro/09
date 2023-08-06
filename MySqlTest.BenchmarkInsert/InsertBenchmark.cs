using System.Diagnostics;
using BenchmarkDotNet.Attributes;
using MySqlTest.Library;

namespace MySqlTest.BenchmarkInsert;

public class InsertBenchmark
{
    private readonly UserRepository _userRepository = new(ConnectionStrings.MySql);


    [GlobalSetup]
    public void GlobalSetup()
    {
        _userRepository.OpenConnection();
        var sw = new Stopwatch();
        sw.Start();
        try
        {
            _userRepository.CreateBtreeIndex();
        }
        catch
        {
            Console.WriteLine($"Failed to create index after {sw.ElapsedMilliseconds}ms.");
            throw;
        }
    }

    [GlobalCleanup]
    public void GlobalCleanup()
    {
        _userRepository.DropIndex();
        _userRepository.Dispose();
    }

    [Benchmark]
    public void Insert()
    {
        var user = new User("qwerty", "qwerty@gmail.com", "John", "Doe", new DateTime(2002, 8, 4));
        _userRepository.InsertOne(user);
    }
}