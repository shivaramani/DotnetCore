## DotnetCore 2.1 samples

- $ dotnet new DotnetCorePractice - dotnet new creates an up-to-date Hello.csproj project file with the dependencies necessary to build a console app. It also creates a Program.cs, a basic file containing the entry point for the application.

- $ dotnet restore - dotnet restore calls into NuGet (.NET package manager) to restore the tree of dependencies.

- $ dotnet run - dotnet run calls dotnet build to ensure that the build targets have been built, and then calls dotnet <assembly.dll> to run the target application.