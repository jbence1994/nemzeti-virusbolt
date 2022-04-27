#!/usr/bin/bash

cd ../NemzetiVirusbolt.Desktop.Tests

rm -rf ./coverage

dotnet test

dotnet tool install -g dotnet-reportgenerator-globaltool

dotnet test --collect:"XPlat Code Coverage"

reportgenerator "-reports:./**/coverage.cobertura.xml" "-targetdir:./coverage" "-reporttypes:Html"
