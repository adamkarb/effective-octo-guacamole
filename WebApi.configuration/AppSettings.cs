using System;
namespace WebApi.configuration
{
    public class AppSettings
    {
        public ConnectionStringsSettings ConnectionStrings { get; set; }

        public string ApiUrl { get; set; }
    }
}
