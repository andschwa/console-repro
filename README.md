# Build with dotnet-cli

```sh
dotnet restore --no-cache
dotnet publish --framework dnxcore50 --output bin
```

Or `./build.sh` after `dotnet restore`.

Note that dotnet-cli does not use the DNX host. Theoretically, the built DLL
should also run with `corerun`, but building CoreFX and CoreCLR on Linux is
quite an experience.

Also, `dotnet run` requires a `DOTNET_HOME` environment variable, but
publishing eliminates this.

# Run

The binary will be called `repro`.

```sh
./bin/repro
```
