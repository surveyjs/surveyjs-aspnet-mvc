// Show the predefined themes in the Themes tab
SurveyCreatorCore.registerSurveyTheme(SurveyTheme);

const creator = new SurveyCreator.SurveyCreator({
    showLogicTab: true,
    showThemeTab: true,
    showTranslationTab: true,
    autoSaveEnabled: true
});

creator.saveSurveyFunc = async (saveNo, callback) => {
    const response = await postJson("api/changeJson", { id: surveyId, text: creator.text });
    callback(saveNo, response.ok);
};

(async () => {
    const surveyData = await getSurvey(surveyId);
    if (!surveyData) {
        document.getElementById("creatorContainer").textContent = "Survey not found";
        return;
    }
    creator.JSON = surveyData.json;
    creator.render(document.getElementById("creatorContainer"));
})();
