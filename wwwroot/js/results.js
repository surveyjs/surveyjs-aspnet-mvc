const heading = document.getElementById("surveyName");
const container = document.getElementById("resultsContainer");

(async () => {
    const surveyData = await getSurvey(surveyId);
    if (!surveyData) {
        heading.textContent = "Survey not found";
        return;
    }
    heading.textContent = "'" + surveyData.name + "' results";
    const data = await getResults(surveyId);
    if (data.length === 0) {
        container.innerHTML = "<div class='sjs-results-placeholder'>This survey doesn't have any answers yet</div>";
        return;
    }
    const survey = new Survey.Model(surveyData.json);
    const table = new SurveyAnalyticsTabulator.Tabulator(survey, data);
    table.render(container);
})();
