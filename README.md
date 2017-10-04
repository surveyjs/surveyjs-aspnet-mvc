# surveyjs-aspnet-mvc
Sample .NET Core backend for SurveyJS library


### Prerequisites
- Install [.NET Core](https://www.microsoft.com/net/download/core) on your computer
- Clone this repository in the `surveyjs-aspnet-mvc` folder
- Build surveyjs-aspnet-mvc application via `dotnet build` command in the `surveyjs-aspnet-mvc` folder
- Start applucation via `dotnet run` command

At this point demo surveyjs-php service will be available at the `http://localhost:5000` address.
If everything is ok, you should see project home page with list of available surveys and links to `Survey` and `Editor` pages.

You can continue with survey via `Run` page, go through the survey and post results to the custom service.
You can continue with editor via `Edit` page, change the survey and store survey JSON to the custom service.

### In order to post survey results it is needed to:
- initialize survey json with a post id
```
    var surveyJson = {
        surveyPostId: '3ce10f8b-2d8a-4ca2-a110-2994b9e697a1',
```
- to set up custom service URL
```
    Survey.dxSurveyService.serviceUrl = "http://localhost:5000/api/Service";
```
These changed are demoinstrated in the [/wwwroot/survey.js](https://github.com/surveyjs/surveyjs-aspnet-mvc/blob/master/wwwroot/survey.js) file of this repo.
