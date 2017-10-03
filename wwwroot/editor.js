Survey.dxSurveyService.serviceUrl = "http://localhost:5000/api/Service";
var accessKey = "";
var editor = new SurveyEditor.SurveyEditor("editor");
var url = new URL(document.URL);
var surveyId = url.searchParams.get("id");        
editor.loadSurvey(surveyId);
editor.saveSurveyFunc = function (saveNo, callback) {
    var xhr = new XMLHttpRequest();
    xhr.open('POST', Survey.dxSurveyService.serviceUrl + '/changeJson?accessKey=' + accessKey);
    xhr.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
    xhr.onload = function () {
        var result = xhr.response ? JSON.parse(xhr.response) : null;
        if(xhr.status === 200) {
            callback(saveNo, true)
        }
    };
    xhr.send(JSON.stringify({ Id: surveyId, Json: editor.text, Text: editor.text }));
};
editor.isAutoSave = true;
editor.showState = true;
editor.showOptions = true;
