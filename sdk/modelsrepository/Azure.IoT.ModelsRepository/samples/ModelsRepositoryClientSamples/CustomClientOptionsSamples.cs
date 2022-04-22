using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.IoT.ModelsRepository.Samples
{
    internal class CustomClientOptionsSamples
    {
        public static async Task ConfigureCustomUserAgent()
        {
            var client = new ModelsRepositoryClient(
                new ModelsRepositoryClientOptions(userAgent: "SampleUA/1.1"));
            
            var dtmi = "dtmi:via:Driverecorder;2";
            ModelResult result =  await client.GetModelAsync(dtmi);
            Console.WriteLine($"{dtmi} resolved in {result.Content.Count} interfaces.");
        }
    }
}
