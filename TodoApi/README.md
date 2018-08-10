## DotnetCore - Web API 

- $ dotnet new webapi -o TodoApi
- $ code TodoApi
- $ dotnet restore
- $ dotnet run

- "F5 if using visual code" - Open browser and enter the following - https://localhost:5001/api/values

## Steps to add TODO api

- add "Models" foler and add TodoItem.cs, TodoContext.cs
- add "TodoController.cs"

- "F5 if using visual code" - Open browser and enter the following - https://localhost:5001/api/todo

## Call Web Api with Jquery

- add below to serve static files in "Configure" of "Startup.cs"

    app.UseDefaultFiles();
    app.UseStaticFiles();

- inside "wwwroot" folder. 
        - Create (copy) the index.html
        - Create (copy) the site.js

- Copy CREATE, UPDATE, DELETE methods in the TodoController.cs

- Run/F5 the application. https://localhost:5001/

- Enter a value & "Add" to see the new todo values in  "https://localhost:5001/api/todo"

## Reference
- https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-vsc?view=aspnetcore-2.1

