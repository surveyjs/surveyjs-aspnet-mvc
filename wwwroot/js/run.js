const container = document.getElementById("surveyContainer");

(async () => {
    const surveyData = await getSurvey(surveyId);
    if (!surveyData) {
        container.textContent = "Survey not found";
        return;
    }
    container.textContent = "";
    const survey = new Survey.Model(surveyData.json);
    if (!survey.title) {
        const heading = document.getElementById("surveyName");
        heading.textContent = surveyData.name;
        heading.hidden = false;
    }
    survey.onComplete.add((sender) => {
        postJson("api/post", { postId: surveyId, surveyResultText: JSON.stringify(sender.data) });
    });
    survey.render(container);
})();
