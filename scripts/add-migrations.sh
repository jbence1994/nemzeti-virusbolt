#!/usr/bin/bash

cd ../NemzetiVirusbolt.Api

read -p "Migration name: " migrationName

dotnet ef migrations add $migrationName --output-dir Persistence/Migrations
