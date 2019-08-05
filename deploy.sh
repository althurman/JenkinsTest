#!/bin/bash

dotnet nuget push ./ListFiles/bin/Debug/ListFiles.1.0.1.nupkg -k $nugetApiKey -s "https://api.nuget.org/v3/index.json"