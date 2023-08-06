using BenchmarkDotNet.Attributes;
using System.Diagnostics;
using MySqlTest.Library;

namespace MySqlTest.Benchmark;

public class DateOfBirthHashIndexBenchmark
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
            _userRepository.CreateHashIndex();
        }
        catch
        {
            Console.WriteLine($"Failed to create HASH index after {sw.ElapsedMilliseconds}ms.");
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
    public IReadOnlyCollection<User> SelectionMonth()
    {
        return _userRepository.SelectUsersForMonth();
    }

    [Benchmark]
    public IReadOnlyCollection<User> SelectionDate()
    {
        return _userRepository.SelectUsersForSpecificDate();
    }
}