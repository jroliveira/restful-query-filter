#load "local:?path=build/build.cake"
#load "local:?path=build/clean.cake"
#load "local:?path=build/pack.cake"
#load "local:?path=build/restore.cake"
#load "local:?path=build/test.cake"

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");

var solutionPath = "./Http.Query.Filter.sln";
var artifactsDirectory = Directory($"./artifacts");

Task("Default")
    .IsDependentOn("Restore")
    .IsDependentOn("Build")
    .IsDependentOn("Test");

Task("Deploy")
    .IsDependentOn("Clean")
    .IsDependentOn("Restore")
    .IsDependentOn("Build")
    .IsDependentOn("Test")
    .IsDependentOn("Pack");

RunTarget(target);