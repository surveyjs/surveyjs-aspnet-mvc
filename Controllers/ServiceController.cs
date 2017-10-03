using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace surveyjs_aspnet_mvc.Controllers {
    [Route("api/[controller]")]
    public class ServiceController : Controller {

        [HttpGet("getActive")]
        public JsonResult GetActive() {
            var db = new SessionStorage(HttpContext.Session);
            return Json(db.GetSurveys());
        }

        [HttpGet("getSurvey")]
        public string GetSurvey(string surveyId) {
            var db = new SessionStorage(HttpContext.Session);
            return db.GetSurvey(surveyId);
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
