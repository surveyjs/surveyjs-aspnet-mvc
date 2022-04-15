using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace surveyjs_aspnet_mvc
{
    public class SessionStorage
    {
        private ISession session;

        public SessionStorage(ISession session)
        {
            this.session = session;
        }

        public T GetFromSession<T>(string storageId, T defaultValue)
        {
            if (string.IsNullOrEmpty(session.GetString(storageId)))
            {
                session.SetString(storageId, JsonConvert.SerializeObject(defaultValue));
            }
            var value = session.GetString(storageId);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }

        public List<SurveyDefinition> GetSurveys()
        {
            return GetFromSession<List<SurveyDefinition>>("SurveyStorage", SurveyDefinition.GetDefaultSurveys());
        }

        public List<SurveyResultsDefinition> GetResults()
        {
            return GetFromSession<List<SurveyResultsDefinition>>("ResultsStorage", SurveyResultsDefinition.GetDefaultSurveyResults());
        }

        public SurveyDefinition GetSurvey(string surveyId)
        {
            return SurveyDefinition.FindById(GetSurveys(), surveyId);
        }

        public SurveyDefinition CreateSurvey(string name)
        {
            var storage = GetSurveys();
            var survey = SurveyDefinition.Create();
            if (!String.IsNullOrEmpty(name))
            {
                survey.name = name;
            }
            storage.Add(survey);
            session.SetString("SurveyStorage", JsonConvert.SerializeObject(storage));
            return survey;
        }

        public void StoreSurvey(string surveyId, string jsonString)
        {
            var storage = GetSurveys();
            var survey = SurveyDefinition.FindById(storage, surveyId);
            survey.json = jsonString;
            session.SetString("SurveyStorage", JsonConvert.SerializeObject(storage));
        }

        public void ChangeName(string id, string name)
        {
            var storage = GetSurveys();
            var survey = SurveyDefinition.FindById(storage, id);
            survey.name = name;
            session.SetString("SurveyStorage", JsonConvert.SerializeObject(storage));
        }

        public void DeleteSurvey(string surveyId)
        {
            var storage = GetSurveys();
            var survey = SurveyDefinition.FindById(storage, surveyId);
            storage.Remove(survey);
            session.SetString("SurveyStorage", JsonConvert.SerializeObject(storage));
        }

        public void PostResults(string postId, string resultJson)
        {
            var storage = GetResults();
            var results = SurveyResultsDefinition.FindById(storage, postId);
            if (results == null)
            {
                results = new SurveyResultsDefinition { id = postId };
                storage.Add(results);
            }
            results.data.Add(resultJson);
            session.SetString("ResultsStorage", JsonConvert.SerializeObject(storage));
        }

        public SurveyResultsDefinition GetResults(string postId)
        {
            var storage = GetResults();
            var results = SurveyResultsDefinition.FindById(storage, postId);
            return results;
        }
    }
}
