using System;
using System.Collections.Generic;
using System.Text;
using XMLParserService.Model;

namespace XMLParserService.Interfaces
{
    public interface IXmlParserService
    {
        ParserResponse ParseXML(ParserRequest request);
    }
}
