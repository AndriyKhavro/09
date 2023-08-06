```

BenchmarkDotNet v0.13.6, Windows 11 (10.0.22621.1992/22H2/2022Update/SunValley2)
AMD Ryzen 9 5900HX with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 7.0.306
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
|         Method |       Mean |     Error |     StdDev |     Median |
|--------------- |-----------:|----------:|-----------:|-----------:|
| SelectionMonth | 218.422 ms | 8.4898 ms | 24.7652 ms | 210.977 ms |
|  SelectionDate |   3.429 ms | 0.0451 ms |  0.0400 ms |   3.430 ms |
