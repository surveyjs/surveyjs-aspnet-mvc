const surveysList = document.getElementById("surveysList");

function renderSurvey(survey) {
    const row = document.createElement("tr");
    const title = document.createElement("td");
    title.textContent = (survey.json && survey.json.title) || survey.name;
    const actions = document.createElement("td");
    for (const [text, page] of [["Run", "run.html"], ["Edit", "edit.html"], ["Results", "results.html"]]) {
        const link = document.createElement("a");
        link.className = "sjs-button";
        link.href = page + "?id=" + encodeURIComponent(survey.id);
        link.textContent = text;
        actions.appendChild(link);
    }
    const remove = document.createElement("button");
    remove.type = "button";
    remove.className = "sjs-button sjs-remove-btn";
    remove.textContent = "Remove";
    remove.onclick = async () => {
        await getJson("api/delete?id=" + encodeURIComponent(survey.id));
        row.remove();
    };
    actions.appendChild(remove);
    row.append(title, actions);
    surveysList.appendChild(row);
}

document.getElementById("addSurvey").onclick = async () => {
    renderSurvey(await getJson("api/create"));
};

(async () => {
    (await getJson("api/getActive")).forEach(renderSurvey);
})();
