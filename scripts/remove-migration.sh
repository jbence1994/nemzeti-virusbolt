#!/usr/bin/bash

cd ../NemzetiVirusbolt.Api

rm -rf ./uploads

dotnet ef database update 0

dotnet ef migrations remove
