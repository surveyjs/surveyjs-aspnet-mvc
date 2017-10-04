function getParams() {
    var url = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
    var result = {};
    url.forEach(function(item) {
        var param = item.split("=");
        result[param[0]] = param[1];
    });
    return result;
}
  
function SurveyManager(baseUrl, accessKey) {
    var self = this;
    var url = new URL(document.URL);
    self.surveyId = getParams()["id"];
    self.results = ko.observableArray();

    self.loadResults = function () {
        var xhr = new XMLHttpRequest();
        xhr.open('GET', baseUrl + '/results?postId=' + self.surveyId);
        xhr.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
        xhr.onload = function () {
            var result = xhr.response ? JSON.parse(xhr.response) : {};
            self.results(result);
        };
        xhr.send();
    }

    self.loadResults();
}

ko.applyBindings(new SurveyManager("http://localhost:5000/api/Service"), document.getElementById("results"));