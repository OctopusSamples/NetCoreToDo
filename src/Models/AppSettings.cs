using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OctopusSamples.CosmosDB.QuickStart.Web.Models
{
    public class AppSettings
    {
        public string AppVersion { get; set; }
        public string EnvironmentName { get; set; }
        public string AccountEndpoint { get; set; }
        public string AccountKeys { get; set; }
        public string Database { get; set; }
        public string Collection { get; set; }
        public string S3BucketPath { get; set; }
        public string S3VersionBucketPath => $"{S3BucketPath}/{AppVersion}/{EnvironmentName}";
    }
}
