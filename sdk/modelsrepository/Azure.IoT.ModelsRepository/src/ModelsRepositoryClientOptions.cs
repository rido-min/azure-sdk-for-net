// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Diagnostics.CodeAnalysis;
using Azure.Core;

namespace Azure.IoT.ModelsRepository
{
    /// <summary>
    /// Options that allow configuration of requests sent to the ModelsRepositoryService.
    /// </summary>
    public class ModelsRepositoryClientOptions : ClientOptions
    {
        internal const ServiceVersion LatestVersion = ServiceVersion.V2021_02_11;

        /// <summary>
        /// The versions of Azure IoT Models Repository service supported by this client.
        /// library.
        /// </summary>
        public enum ServiceVersion
        {
            /// <summary>
            /// 2021_02_11
            /// </summary>
            [SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "<Pending>")]
            V2021_02_11 = 1
        }

        /// <summary>
        /// Gets the <see cref="ServiceVersion"/> of the service API used when making requests.
        /// </summary>
        public ServiceVersion Version { get; }

        /// <summary>
        /// Gets the <see cref="ModelsRepositoryClientMetadataOptions"/> configuring interaction with models repository metadata.
        /// </summary>
        public ModelsRepositoryClientMetadataOptions RepositoryMetadata { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsRepositoryClientOptions"/> class with default options.
        /// </summary>
        /// <param name="version">
        /// The <see cref="ServiceVersion"/> of the service API used when making requests.
        /// </param>
        public ModelsRepositoryClientOptions(
            ServiceVersion version = LatestVersion)
        {
            Version = version;
            RepositoryMetadata = new ModelsRepositoryClientMetadataOptions();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsRepositoryClientOptions"/> class with user agent.
        /// </summary>
        /// <param name="userAgent">Custom User Agent </param>
#pragma warning disable AZC0009 // ClientOptions constructors should take a ServiceVersion as their first parameter
        public ModelsRepositoryClientOptions(string userAgent)
#pragma warning restore AZC0009 // ClientOptions constructors should take a ServiceVersion as their first parameter
        {
            Version = LatestVersion;
            RepositoryMetadata = new ModelsRepositoryClientMetadataOptions();
            this.AddPolicy(new CustomUserAgentHttpPolicy(userAgent), HttpPipelinePosition.PerCall);
        }
    }
}
