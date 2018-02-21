using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace surveyjs_aspnet_mvc.Controllers
{

    public class ChangeSurveyModel
    {
        public string Id { get; set; }
        public string Json { get; set; }
        public string Text { get; set; }
    }

    public class PostSurveyResultModel
    {
        public string postId { get; set; }
        public string surveyResult { get; set; }
    }

    [Route("")]
    public class ServiceController : Controller
    {

        [HttpGet("getActive")]
        public JsonResult GetActive()
        {
            var db = new SessionStorage(HttpContext.Session);
            return Json(db.GetSurveys());
        }

        [HttpGet("getSurvey")]
        public string GetSurvey(string surveyId)
        {
            var db = new SessionStorage(HttpContext.Session);
            return db.GetSurvey(surveyId);
        }

        [HttpGet("create")]
        public JsonResult Create(string name)
        {
            var db = new SessionStorage(HttpContext.Session);
            db.StoreSurvey(name, "{}");
            return Json("Ok");
        }

        [HttpGet("changeName")]
        public JsonResult ChangeName(string id, string name)
        {
            var db = new SessionStorage(HttpContext.Session);
            db.ChangeName(id, name);
            return Json("Ok");
        }

        [HttpPost("changeJson")]
        public string ChangeJson([FromBody]ChangeSurveyModel model)
        {
            var db = new SessionStorage(HttpContext.Session);
            db.StoreSurvey(model.Id, model.Json);
            return db.GetSurvey(model.Id);
        }

        [HttpGet("delete")]
        public JsonResult Delete(string id)
        {
            var db = new SessionStorage(HttpContext.Session);
            db.DeleteSurvey(id);
            return Json("Ok");
        }

        [HttpPost("post")]
        public JsonResult PostResult([FromBody]PostSurveyResultModel model)
        {
            var db = new SessionStorage(HttpContext.Session);
            db.PostResults(model.postId, model.surveyResult);
            return Json("Ok");
        }

        [HttpGet("results")]
        public JsonResult GetResults(string postId)
        {
            var db = new SessionStorage(HttpContext.Session);
            return Json(db.GetResults(postId));
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
