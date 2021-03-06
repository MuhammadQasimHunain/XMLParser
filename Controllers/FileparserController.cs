using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using XMLParserService.Model;
using XMLParserService.Services;

namespace WebTools.Controllers
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
        [Route("GetAllFiles")]
        public IActionResult GetAllFiles()
        {
            var xmlParserService = new XmlParserService();
            var result = xmlParserService.GetXMLFiles();
            return new JsonResult(result);
        }

        [HttpGet]
        [Route("GetAllLearner")]
        public IActionResult GetAllLearner()
        {
            var xmlParserService = new XmlParserService();
            var result = xmlParserService.GetLearners();
            return new JsonResult(result);
        }

        [HttpPost]
        [Route("Validate")]
        public async Task<IActionResult> Validate(IFormFile formFile)
        {
            try
            {
                string filePath = string.Empty;
                if (formFile != null)
                {
                    if (formFile.Length > 0)
                    {

                        filePath = Path.Combine(Directory.GetCurrentDirectory() + @"\files",
                            formFile.FileName.Split(".")[0] + Path.GetRandomFileName() + "." + formFile.FileName.Split(".")[1]);

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
            catch (Exception exp)
            {
                return new JsonResult(exp.Message);
            }
        }
        #endregion
    }
}
