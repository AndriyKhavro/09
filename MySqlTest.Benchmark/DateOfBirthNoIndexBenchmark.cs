using BenchmarkDotNet.Attributes;
using MySqlTest.Library;

namespace MySqlTest.Benchmark;

public class DateOfBirthNoIndexBenchmark
{
    private readonly UserRepository _userRepository = new(ConnectionStrings.MySql);

    [GlobalSetup]
    public void GlobalSetup()
    {
        _userRepository.OpenConnection();
    }

    [GlobalCleanup]
    public void GlobalCleanup()
    {
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