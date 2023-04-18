Learning C# and .NET!

run file with;

    dotnet run
    OR
    dotnet watch

create new project with:

    dotnet new <project_type> -n <name>

create complex projects with a solution file:

    dotnet new sln -o <name>

then add .csproj files to the solution:

    dotnet sln add ./path/to/.csproj

project type can be:
    
    ASP.NET Core Web App: webapp, razor
    Blazor Server App: blazorserver
    Class Library: classlib
    Console App: console
