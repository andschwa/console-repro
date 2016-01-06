# Build with dotnet-cli

```sh
dotnet restore
dotnet publish --framework dnxcore50 --runtime ubuntu.14.04-x64 --output bin
```

Note that dotnet-cli does not use the DNX host. Theoretically, the built DLL
should also run with `corerun`, but building CoreFX and CoreCLR on Linux is
quite an experience.

Also, `dotnet run` requires a `DOTNET_HOME` environment variable, but
publishing eliminates this.

# Run

The binary will be called the same as `pwd`.

```sh
./bin/console-repro
```
