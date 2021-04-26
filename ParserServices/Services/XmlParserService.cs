using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using XMLParserService.DbEntities;
using XMLParserService.Interfaces;
using XMLParserService.Model;

namespace XMLParserService.Services
{
    public class XmlParserService : IXmlParserService
    {
        public XmlParserService()
        {

        }

        public ParserResponse ParseXML(ParserRequest request)
        {
            ParserResponse parserResponse = new ParserResponse();
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory());
                XmlSchemaSet schema = new XmlSchemaSet();
                schema.Add("", path + "\\XSDFiles\\ILR-2021.xsd");
                XmlReader rd = XmlReader.Create(request.FileName);
                XDocument doc = XDocument.Load(rd);
                doc.Validate(schema, ValidationEventHandler);
            }
            catch (Exception exp)
            {
                parserResponse.RecordID = int.Parse(exp.Message.Split('-')[0]);
                parserResponse.Status = bool.Parse(exp.Message.Split('-')[1]);
                parserResponse.Message = exp.Message.Split('-')[2];
                parserResponse.RequestFileName = request.FileName;
            }
            return parserResponse;
        }

        static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            XmlSeverityType type = XmlSeverityType.Warning;
            if (Enum.TryParse<XmlSeverityType>("Error", out type))
            {
                if (type == XmlSeverityType.Error)
                {
                    int recordId = RecordValidation(new FileInfoRecord
                    {
                        CreatedTime = DateTime.Now,
                        FileName = sender.ToString(),
                        Status = false
                    });
                    throw new Exception(string.Format("{0}-{1}-{2}", recordId,false,e.Message));
                }
            }
            else
            {
                int recordId = RecordValidation(new FileInfoRecord
                {
                    CreatedTime = DateTime.Now,
                    FileName = sender.ToString(),
                    Status = true
                });
                throw new Exception(string.Format("{0}-{1}-File is Validated.", recordId,true));
            }
        }

        private static int RecordValidation(FileInfoRecord fileInfoRecord) 
        {
            return fileInfoRecord.AddToDatabase();
        }
    }
}
