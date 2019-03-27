Task("Restore")
    .Does(() => DotNetCoreRestore(
        solutionPath,
        new DotNetCoreRestoreSettings
        {
            Sources = new[] { "https://api.nuget.org/v3/index.json" },
        }));