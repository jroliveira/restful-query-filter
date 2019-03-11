#load "local:?path=tasks/build.cake"
#load "local:?path=tasks/clean.cake"
#load "local:?path=tasks/pack.cake"
#load "local:?path=tasks/restore.cake"
#load "local:?path=tasks/test.cake"

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");

var solutionPath = $"./../Http.Query.Filter.sln";
var artifactsDirectory = Directory($"./../artifacts");

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