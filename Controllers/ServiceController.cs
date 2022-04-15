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

        [HttpGet("getActive")]
        public JsonResult GetActive()
        {
            var db = new SessionStorage(HttpContext.Session);
            return Json(db.GetSurveys());
        }

        [HttpGet("getSurvey")]
        public JsonResult GetSurvey(string surveyId)
        {
            var db = new SessionStorage(HttpContext.Session);
            return Json(db.GetSurvey(surveyId));
        }

        [HttpGet("create")]
        public JsonResult Create(string name)
        {
            var db = new SessionStorage(HttpContext.Session);
            return Json(db.CreateSurvey(name));
        }

        [HttpGet("changeName")]
        public JsonResult ChangeName(string id, string name)
        {
            var db = new SessionStorage(HttpContext.Session);
            db.ChangeName(id, name);
            return Json("Ok");
        }

        [HttpPost("changeJson")]
        public JsonResult ChangeJson([FromBody] ChangeSurveyModel model)
        {
            var db = new SessionStorage(HttpContext.Session);
            db.StoreSurvey(model.id, model.text);
            return Json(db.GetSurvey(model.id));
        }

        [HttpGet("delete")]
        public JsonResult Delete(string id)
        {
            var db = new SessionStorage(HttpContext.Session);
            db.DeleteSurvey(id);
            return Json(new { id = id });
        }

        [HttpPost("post")]
        public JsonResult PostResult([FromBody] PostSurveyResultModel model)
        {
            var db = new SessionStorage(HttpContext.Session);
            db.PostResults(model.postId, model.surveyResultText);
            return Json(new { });
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
