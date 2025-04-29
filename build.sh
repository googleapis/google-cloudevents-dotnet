#!/bin/bash

set -e

# Make sure that SourceLink uses the GitHub repo, even if that's not where
# our origin remote points at.
git remote add github https://github.com/googleapis/google-cloudevents-dotnet.git
export GitRepositoryRemoteName=github

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

# Remove the github remote so that if there are multiple iterations
# against the same clone, the "git remote add" earlier will work.
git remote remove github
