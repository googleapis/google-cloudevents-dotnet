#!/bin/bash

set -e

export ContinuousIntegrationBuild=true
export Configuration=Release

echo Building...
dotnet build -nologo -clp:NoSummary -v quiet src

echo Testing...
dotnet test -nologo --no-build -v quiet src

echo Packing...
rm -rf nupkg
dotnet pack -nologo -v quiet src -o $PWD/nupkg

echo Created packages:
ls nupkg
