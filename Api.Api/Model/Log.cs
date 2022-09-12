using System;

namespace ERP.Api.Model
{
    public class Log
    {
        public string Url { get; set; }
        public string Method { get; set; }
        public int HttpStatusCode { get; set; }
        public string HttpStatusCodeDescription { get; set; }
        public string Body { get; set; }
        public string Ip { get; set; }
        public DateTime CreationDate { get; set; }
        public string ClientId { get; set; }
    }
}
