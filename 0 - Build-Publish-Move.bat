@echo off

dotnet restore

dotnet build --no-restore -c Release

move /Y Panosen.Math\bin\Release\Panosen.Math.*.nupkg D:\LocalSavoryNuget\

pause