using System;
using System.Collections.Generic;
using System.Text;

namespace XMLParserService.Model
{
    public class ParserResponse
    {
        public string RequestFileName { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
        public int RecordID { get; set; }
    }
}
