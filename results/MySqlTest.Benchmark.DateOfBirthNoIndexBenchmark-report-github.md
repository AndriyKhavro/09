```

BenchmarkDotNet v0.13.6, Windows 11 (10.0.22621.1992/22H2/2022Update/SunValley2)
AMD Ryzen 9 5900HX with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 7.0.306
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
|         Method |    Mean |   Error |  StdDev |
|--------------- |--------:|--------:|--------:|
| SelectionMonth | 19.46 s | 0.291 s | 0.243 s |
|  SelectionDate | 13.59 s | 0.269 s | 0.299 s |
