set shell := ["nu", "-c"]

test:
    dotnet test

watch-tests:
    watch . { dotnet test } --glob=**/*.cs
