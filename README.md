# SurveyJS + .NET Core Demo Example

This demo shows how to integrate [SurveyJS](https://surveyjs.io/) components with a .NET Core backend.

[View Demo Online](https://surveyjs-aspnet-core.azurewebsites.net/)

## Disclaimer

This demo must not be used as a real service as it doesn't cover such real-world survey service aspects as authentication, authorization, user management, access levels, and different security issues. These aspects are covered by backend-specific articles, forums, and documentation.

## Run the Application

Install [.NET](https://dotnet.microsoft.com/en-us/download) on your machine. After that, run the following commands:

```bash
git clone https://github.com/surveyjs/surveyjs-aspnet-mvc.git
cd surveyjs-aspnet-mvc
dotnet build
dotnet run
```

Open http://localhost:5000 in your web browser.

## Client-Side App

The client-side part is the `surveyjs-react-client` React application. The current project includes only the application's build artifacts. Refer to the [surveyjs-react-client](https://github.com/surveyjs/surveyjs-react-client) repo for full code and information about the application.