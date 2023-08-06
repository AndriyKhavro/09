using BenchmarkDotNet.Running;
using MySqlTest.Benchmark;

BenchmarkRunner.Run<DateOfBirthNoIndexBenchmark>();
BenchmarkRunner.Run<DateOfBirthBtreeIndexBenchmark>();
BenchmarkRunner.Run<DateOfBirthHashIndexBenchmark>();