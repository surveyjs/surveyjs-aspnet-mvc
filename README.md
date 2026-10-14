# SurveyJS + .NET Core Demo Example

This demo shows how to integrate [SurveyJS](https://surveyjs.io/) components with a .NET Core backend.

[View Demo Online](https://surveyjs-aspnet-mvc.demos.surveyjs.io/)

## Disclaimer

This demo must not be used as a real service as it doesn't cover such real-world survey service aspects as authentication, authorization, user management, access levels, and different security issues. These aspects are covered by backend-specific articles, forums, and documentation.

## Run the Application

Install [.NET 10](https://dotnet.microsoft.com/en-us/download) or later on your machine. After that, run the following commands:

```bash
git clone https://github.com/surveyjs/surveyjs-aspnet-core.git
cd surveyjs-aspnet-core
dotnet build
dotnet run
```

Open http://localhost:5000 in your web browser.

## Client-Side App

The client side is a set of plain HTML pages in `wwwroot` that need no npm or build step. SurveyJS scripts and styles come from the official [SurveyJS NuGet packages](https://www.nuget.org/profiles/SurveyJS) referenced in `surveyjs-aspnet-core.csproj`. ASP.NET Core serves them as static web assets under `_content/SurveyJS.*/`.

| Page | SurveyJS component | NuGet package |
|---|---|---|
| `index.html` | Survey list: add and remove surveys | - |
| `run.html?id=...` | [Form Library](https://surveyjs.io/form-library/documentation/overview) runs the survey | `SurveyJS` |
| `edit.html?id=...` | [Survey Creator](https://surveyjs.io/survey-creator/documentation/overview) edits the survey | `SurveyJS.Creator` |
| `results.html?id=...` | [Dashboard](https://surveyjs.io/dashboard/documentation/overview) Table View shows the responses | `SurveyJS.Analytics` |

To update SurveyJS, update the packages to the same version, for example: `dotnet add package SurveyJS.Creator`. The Table View also needs [Tabulator](https://tabulator.info/), which `results.html` loads from a CDN.

Survey Creator and Dashboard are commercial products and display a license banner until you [set up your license key](https://surveyjs.io/remove-alert-banner). The Form Library is MIT-licensed.

When you run the app from the build output, the `_content/` assets are only served in the `Development` environment. `dotnet run` sets it through `Properties/launchSettings.json`. Published output (`dotnet publish`) includes the assets and works in any environment.

The backend keeps the same `/api` endpoints as before, so the [surveyjs-react-client](https://github.com/surveyjs/surveyjs-react-client) React application also works with it.

## Other Resources

The [Endatix Platform](https://endatix.com/?utm_source=surveyjs&utm_medium=partner+link) is an open-source solution that provides a fully integrated server-side API for managing SurveyJS forms and their results within .NET environments. Endatix provides a complete backend application structure, from API requests to database integration and admin management, allowing users to quickly implement a fully operational server environment with minimal coding. Endatix is an ideal choice for developers looking for an efficient way to implement SurveyJS without extensive server-side development. 

**Endatix Platform repo:** https://github.com/endatix/endatix

