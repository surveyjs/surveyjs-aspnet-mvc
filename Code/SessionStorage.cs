using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace surveyjs_aspnet_mvc {
    public class SessionStorage {
        private ISession session;

        public SessionStorage(ISession session) {
            this.session = session;
        }

        public T GetFromSession<T>(string storageId, T defaultValue) {
            if(string.IsNullOrEmpty(session.GetString(storageId))) {
                session.SetString(storageId, JsonConvert.SerializeObject(defaultValue));
            }
            var value = session.GetString(storageId);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);            
        }

        public Dictionary<string, string> GetSurveys() {
            Dictionary<string, string> surveys = new Dictionary<string, string>();
            surveys["MySurvey1"] = @"{
                ""pages"": [
                 {
                  ""name"": ""page1"",
                  ""elements"": [
                   {
                    ""type"": ""radiogroup"",
                    ""choices"": [
                     ""item1"",
                     ""item2"",
                     ""item3""
                    ],
                    ""name"": ""question from survey1""
                   }
                  ]
                 }
                ]
               }";
            surveys["MySurvey2"] = @"{
                ""pages"": [
                 {
                  ""name"": ""page1"",
                  ""elements"": [
                   {
                    ""type"": ""checkbox"",
                    ""choices"": [
                     ""item1"",
                     ""item2"",
                     ""item3""
                    ],
                    ""name"": ""question from survey2""
                   }
                  ]
                 }
                ]
               }";
            return GetFromSession<Dictionary<string, string>>("SurveyStorage", surveys);
        }

        public string GetSurvey(string surveyId) {
            return GetSurveys()[surveyId];
        }
    }
}
