using System;
using System.Collections.Generic;
using System.Linq;

namespace surveyjs_aspnet_mvc
{
    [Serializable]
    public class SurveyResultsDefinition
    {
        public SurveyResultsDefinition()
        {
            data = new List<string>();
        }
        public string id { get; set; }
        public List<string> data { get; private set; }

        public static SurveyResultsDefinition FindById(IEnumerable<SurveyResultsDefinition> collection, string id)
        {
            return collection.Where(s => s.id == id).FirstOrDefault();
        }

        public static List<SurveyResultsDefinition> GetDefaultSurveyResults()
        {
            SurveyResultsDefinition surveyResults1 = new SurveyResultsDefinition { id = "1" };
            surveyResults1.data.AddRange(new string[] {
                @"{""Quality"":{""affordable"":""5"",""better then others"":""5"",""does what it claims"":""5"",""easy to use"":""5""},""satisfaction"":5,""recommend friends"":5,""suggestions"":""I am happy!"",""price to competitors"":""Not sure"",""price"":""low"",""pricelimit"":{""mostamount"":""100"",""leastamount"":""100""}}",
                @"{""Quality"":{""affordable"":""3"",""does what it claims"":""2"",""better then others"":""2"",""easy to use"":""3""},""satisfaction"":3,""suggestions"":""better support"",""price to competitors"":""Not sure"",""price"":""high"",""pricelimit"":{""mostamount"":""60"",""leastamount"":""10""}}"
            });
            SurveyResultsDefinition surveyResults2 = new SurveyResultsDefinition { id = "2" };
            surveyResults2.data.AddRange(new string[] {
                @"{""member_array_employer"":[{}],""partner_array_employer"":[{}],""maritalstatus_c"":""Married"",""member_receives_income_from_employment"":""0"",""partner_receives_income_from_employment"":""0""}",
                @"{""member_array_employer"":[{}],""partner_array_employer"":[{}],""maritalstatus_c"":""Single"",""member_receives_income_from_employment"":""1"",""member_type_of_employment"":[""Self employment""],""member_seasonal_intermittent_or_contract_work"":""0""}"
            });

            List<SurveyResultsDefinition> defaultSurveyResults = new List<SurveyResultsDefinition> { surveyResults1, surveyResults2 };
            return defaultSurveyResults;

        }

    }
}