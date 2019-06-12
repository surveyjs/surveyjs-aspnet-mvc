# surveyjs-aspnet-mvc
Sample .NET Core backend for SurveyJS: Survey Library and Survey Creator

### Disclaimer
This demo illustrates how to integrate SurveyJS libraries with PHP backend. This demo doesn't cover all of real survey service application aspects, such as authentication, authorization, user management, access levels and different security issues. These aspects are covered by backend-specific articles, forums and documentation. This demo demos is just intergration one and can't be used as a real service.

## [SurveyJS Home Page](https://surveyjs.io/Examples/Service/)

## [Live Online Survey + Survey Creator Demo](https://surveyjs-aspnet-mvc.azurewebsites.net/)


### Prerequisites
- Install [.NET Core](https://www.microsoft.com/net/download/core) on your computer
- Clone this repository in the `surveyjs-aspnet-mvc` folder
- Build surveyjs-aspnet-mvc application via `dotnet build` command in the `surveyjs-aspnet-mvc` folder
- Start applucation via `dotnet run` command

At this point demo surveyjs-php service will be available at the `http://localhost:5000` address.
If everything is ok, you should see project home page with list of available surveys and links to `Survey` and `Survey Creator` pages.

You can continue with survey via `Run` page, go through the survey and post results to the custom service.
You can continue with Survey Creator via `Edit` page, change the survey and store survey JSON to the custom service.
