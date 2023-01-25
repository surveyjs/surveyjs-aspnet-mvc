using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace surveyjs_aspnet_mvc.Controllers
{

    public class ChangeSurveyModel
    {
        public string id { get; set; }
        public string text { get; set; }
    }

    public class PostSurveyResultModel
    {
        public string postId { get; set; }
        public string surveyResultText { get; set; }
    }

    [Route("/api")]
    public class ServiceController : Controller
    {

        private IStorage storage;
        public ServiceController(IStorage storage) {
            this.storage = storage;
        }

        [HttpGet("getActive")]
        public JsonResult GetActive() {
            return Json(storage.GetSurveys());
        }

        [HttpGet("getSurvey")]
        public JsonResult GetSurvey(string surveyId) {
            return Json(storage.GetSurvey(surveyId));
        }

        [HttpGet("create")]
        public JsonResult Create(string name) {
            return Json(storage.CreateSurvey(name));
        }

        [HttpGet("changeName")]
        public JsonResult ChangeName(string id, string name) {
            storage.ChangeName(id, name);
            return Json("Ok");
        }

        [HttpPost("changeJson")]
        public JsonResult ChangeJson([FromBody] ChangeSurveyModel model) {
            storage.StoreSurvey(model.id, model.text);
            return Json(storage.GetSurvey(model.id));
        }

        [HttpGet("delete")]
        public JsonResult Delete(string id) {
            storage.DeleteSurvey(id);
            return Json(new { id = id });
        }

        [HttpPost("post")]
        public JsonResult PostResult([FromBody] PostSurveyResultModel model) {
            storage.PostResults(model.postId, model.surveyResultText);
            return Json(new { });
        }

        [HttpGet("results")]
        public JsonResult GetResults(string postId) {
            return Json(storage.GetResults(postId));
        }

        // // GET api/values/5
        // [HttpGet("{id}")]
        // public string Get(int id)
        // {
        //     return "value";
        // }

        // // POST api/values
        // [HttpPost]
        // public void Post([FromBody]string value)
        // {
        // }

        // // PUT api/values/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody]string value)
        // {
        // }

        // // DELETE api/values/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }
    }
}
