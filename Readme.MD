## Setup steps

1. Start MySQL (the parameter is for innodb_flush_log_at_trx_commit):
```powershell
.\up.ps1 1
```
2. Run CreateTable.sql script.

3. Generate 40M users (will take a while):
```
dotnet run --project .\MySqlTest.DataGenerator\MySqlTest.DataGenerator.csproj
```

4. Run benchmarks for selections:
```
dotnet run -c Release --project .\MySqlTest.Benchmark\MySqlTest.Benchmark.csproj
```

5. Run benchmarks for insertions for different innodb_flush_log_at_trx_commit options:
```powershell
.\test-insert-for-all-options.ps1
```

6. Stop MySql:
```powershell
.\stop.ps1
```

## Results:

[Selections without index](./results/MySqlTest.Benchmark.DateOfBirthNoIndexBenchmark-report-github.md)

[Selections with BTREE](./results/MySqlTest.Benchmark.DateOfBirthBtreeIndexBenchmark-report-github.md)

[Selections with HASH (BTREE index was created, so the results are the same)](./results/MySqlTest.Benchmark.DateOfBirthHashIndexBenchmark-report-github.md)

[Insertions with innodb_flush_log_at_trx_commit = 0](./results/Insert0/MySqlTest.BenchmarkInsert.InsertBenchmark-report-github.md)

[Insertions with innodb_flush_log_at_trx_commit = 1](./results/Insert1/MySqlTest.BenchmarkInsert.InsertBenchmark-report-github.md)

[Insertions with innodb_flush_log_at_trx_commit = 2](./results/Insert2/MySqlTest.BenchmarkInsert.InsertBenchmark-report-github.md)
