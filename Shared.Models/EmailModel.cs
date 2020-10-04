using System;

namespace Shared.Models
{
    public class EmailModel
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string MessageBody { get; set; }
        public DateTime SendDate { get; set; }
    }
}
