using System;
using System.Collections.Generic;
using System.Text;
using XMLParserService.DbEntities;
using XMLParserService.Model;

namespace XMLParserService.Interfaces
{
    public interface IXmlParserService
    {
        List<FileInfoRecord> GetXMLFiles();
        ParserResponse ParseXML(ParserRequest request);
    }
}
