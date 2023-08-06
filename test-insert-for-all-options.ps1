.\up.ps1 1
.\test.ps1
.\stop.ps1

Copy-Item -Path .\BenchmarkDotNet.Artifacts\results -Destination .\results\Insert12 -Recurse

.\up.ps1 2
.\test.ps1
.\stop.ps1

Copy-Item -Path .\BenchmarkDotNet.Artifacts\results -Destination .\results\Insert22 -Recurse

.\up.ps1 0
.\test.ps1
.\stop.ps1

Copy-Item -Path .\BenchmarkDotNet.Artifacts\results -Destination .\results\Insert02 -Recurse
