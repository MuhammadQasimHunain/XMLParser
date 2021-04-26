using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using XMLParserService.Model;
using XMLParserService.Services;

namespace TodoApi.Controllers
{
    #region snippet_TodoController
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class FileparserController : ControllerBase
    {

        #endregion

        public FileparserController()
        {

        }

        #region snippet_GetAll
        [HttpGet]
        public ActionResult<IActionResult> GetAll()
        {
            return new JsonResult(new object());
        }


        [HttpPost]
        public async Task<IActionResult> Validate(IFormFile formFile)
        {
            string filePath = string.Empty;
            if (formFile != null)
            {
                if (formFile.Length > 0)
                {

                    filePath = Path.Combine(Directory.GetCurrentDirectory() + @"\files",
                        Path.GetRandomFileName() + "." + formFile.FileName.Split(".")[1]);

                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }
            var xmlParserService = new XmlParserService();
            var result = xmlParserService.ParseXML(
                new ParserRequest
                {
                    FileName = filePath
                });
            return new JsonResult(result);
        }
        #endregion

    }
}