// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.IoT.ModelsRepository
{
    internal class CustomUserAgentHttpPolicy : HttpPipelinePolicy
    {
        private string userAgent;
        public CustomUserAgentHttpPolicy(string userAgent)
        {
            this.userAgent = userAgent;
        }
        public override void Process(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline)
        {
            message.Request.Headers.Add(new HttpHeader("User-Agent", userAgent));
            ProcessNext(message, pipeline);
        }

        public async override ValueTask ProcessAsync(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline)
        {
            message.Request.Headers.Add(new HttpHeader("User-Agent", userAgent));
            await ProcessNextAsync(message, pipeline).ConfigureAwait(false);
        }
    }
}
