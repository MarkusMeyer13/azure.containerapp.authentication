using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class CopyBlob
    {
        [FunctionName("CopyBlob")]
        public void Run(
            [BlobTrigger("samples-workitems/{name}", Connection = "strsample_STORAGE")] byte[] inputBlob,
            [Blob("output/{name}.copy", Connection = "strsample_STORAGE")] byte[] outputBlob,
            string name,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            outputBlob = inputBlob;
        }
    }
}
