using System;
using System.Linq;
using System.IO;
using System.Web.Http;
using System.Web.Http.Results;

namespace Service.Controllers
{
    public class PicturesController : ApiController
    {
        [HttpGet]
        [Route("api/pictures/all")]
        public JsonResult<string[]> TestImages()
        {
            string[] Samples = Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Samples"))
                .Select(Path.GetFileName)
                .ToArray();

            return Json(Samples);
        }
    }
}
