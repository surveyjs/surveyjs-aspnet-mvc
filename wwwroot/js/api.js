// Calls to the ASP.NET Core backend (Controllers/ServiceController.cs)
const surveyId = new URLSearchParams(location.search).get("id");

async function getJson(url) {
    const response = await fetch(url);
    const text = await response.text();
    return text ? JSON.parse(text) : null;
}

// Returns { id, name, json } with json as an object, or null if the survey doesn't exist
async function getSurvey(id) {
    const survey = await getJson("api/getSurvey?surveyId=" + encodeURIComponent(id));
    if (survey && typeof survey.json === "string") {
        survey.json = JSON.parse(survey.json);
    }
    return survey;
}

// Returns an array of response objects
async function getResults(id) {
    const results = await getJson("api/results?postId=" + encodeURIComponent(id));
    return results ? results.data.map((item) => typeof item === "string" ? JSON.parse(item) : item) : [];
}

function postJson(url, data) {
    return fetch(url, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(data)
    });
}
