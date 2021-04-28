﻿using System;
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
                int recordId = 0;
                var schemaName = Path.Combine(Directory.GetCurrentDirectory()) + "\\XSDFiles\\ILR-2021.xsd";
                if (ValidateXmlWithXsd(request.FileName, schemaName))
                {
                    recordId = RecordValidation(new FileInfoRecord
                    {
                        CreatedTime = DateTime.Now,
                        FileName = Path.GetFileName(request.FileName),
                        Status = true
                    });
                    parserResponse = new ParserResponse
                    {
                        Message = string.Format("XML file is validated."),
                        RecordID = recordId,
                        RequestFileName = Path.GetFileName(request.FileName),
                        Status = true,
                    };
                }
                else
                {
                    recordId = RecordValidation(new FileInfoRecord
                    {
                        CreatedTime = DateTime.Now,
                        FileName = request.FileName,
                        Status = false
                    });
                    parserResponse = new ParserResponse
                    {
                        Message = string.Format("Error validating file."),
                        RecordID = recordId,
                        RequestFileName = request.FileName,
                        Status = false,
                    };
                }

            }
            catch (Exception exp)
            {
                parserResponse.RecordID = 0;
                parserResponse.Status = false;
                parserResponse.Message = "Error validating file.";
                parserResponse.RequestFileName = request.FileName;
            }
            return parserResponse;
        }
        private static bool ValidateXmlWithXsd(string xmlUri, string xsdUri)
        {
            try
            {
                XmlReaderSettings xmlSettings = new XmlReaderSettings();
                xmlSettings.Schemas = new System.Xml.Schema.XmlSchemaSet();
                xmlSettings.ValidationType = ValidationType.Schema;
                XmlReader reader = XmlReader.Create(xmlUri, xmlSettings);

                // Parse the file.
                while (reader.Read()) ;

                return true;
            }
            catch (System.Xml.XmlException ex)
            {
                return false;
            }
        }

        private static int RecordValidation(FileInfoRecord fileInfoRecord)
        {
            return fileInfoRecord.AddToDatabase();
        }

        public List<FileInfoRecord> GetXMLFiles()
        {
            return FileInfoRecord.GetFileInfoRecords();
        }
    }
}
