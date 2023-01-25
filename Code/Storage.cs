using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace surveyjs_aspnet_mvc {
    public interface IStorage {
        T GetFromSession<T>(string storageId, T defaultValue);
        List<SurveyDefinition> GetSurveys();
        List<SurveyResultsDefinition> GetResults();
        SurveyDefinition GetSurvey(string surveyId);
        SurveyDefinition CreateSurvey(string name);
        void StoreSurvey(string surveyId, string jsonString);
        void ChangeName(string id, string name);
        void DeleteSurvey(string surveyId);
        void PostResults(string postId, string resultJson);
        SurveyResultsDefinition GetResults(string postId);
    }
}
