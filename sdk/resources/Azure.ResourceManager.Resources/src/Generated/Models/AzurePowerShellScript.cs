// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Object model for the Azure PowerShell script. </summary>
    public partial class AzurePowerShellScript : DeploymentScriptData
    {
        /// <summary> Initializes a new instance of AzurePowerShellScript. </summary>
        /// <param name="location"> The location of the ACI and the storage account for the deployment script. </param>
        /// <param name="retentionInterval"> Interval for which the service retains the script resource after it reaches a terminal state. Resource will be deleted when this duration expires. Duration is based on ISO 8601 pattern (for example P1D means one day). </param>
        /// <param name="azPowerShellVersion"> Azure PowerShell module version to be used. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="azPowerShellVersion"/> is null. </exception>
        public AzurePowerShellScript(string location, TimeSpan retentionInterval, string azPowerShellVersion) : base(location)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (azPowerShellVersion == null)
            {
                throw new ArgumentNullException(nameof(azPowerShellVersion));
            }

            Outputs = new ChangeTrackingDictionary<string, object>();
            SupportingScriptUris = new ChangeTrackingList<string>();
            EnvironmentVariables = new ChangeTrackingList<EnvironmentVariable>();
            RetentionInterval = retentionInterval;
            AzPowerShellVersion = azPowerShellVersion;
            Kind = ScriptType.AzurePowerShell;
        }

        /// <summary> Initializes a new instance of AzurePowerShellScript. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="identity"> Optional property. Managed identity to be used for this deployment script. Currently, only user-assigned MSI is supported. </param>
        /// <param name="location"> The location of the ACI and the storage account for the deployment script. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="kind"> Type of the script. </param>
        /// <param name="systemData"> The system metadata related to this resource. </param>
        /// <param name="containerSettings"> Container settings. </param>
        /// <param name="storageAccountSettings"> Storage Account settings. </param>
        /// <param name="cleanupPreference"> The clean up preference when the script execution gets in a terminal state. Default setting is &apos;Always&apos;. </param>
        /// <param name="provisioningState"> State of the script execution. This only appears in the response. </param>
        /// <param name="status"> Contains the results of script execution. </param>
        /// <param name="outputs"> List of script outputs. </param>
        /// <param name="primaryScriptUri"> Uri for the script. This is the entry point for the external script. </param>
        /// <param name="supportingScriptUris"> Supporting files for the external script. </param>
        /// <param name="scriptContent"> Script body. </param>
        /// <param name="arguments"> Command line arguments to pass to the script. Arguments are separated by spaces. ex: -Name blue* -Location &apos;West US 2&apos;. </param>
        /// <param name="environmentVariables"> The environment variables to pass over to the script. </param>
        /// <param name="forceUpdateTag"> Gets or sets how the deployment script should be forced to execute even if the script resource has not changed. Can be current time stamp or a GUID. </param>
        /// <param name="retentionInterval"> Interval for which the service retains the script resource after it reaches a terminal state. Resource will be deleted when this duration expires. Duration is based on ISO 8601 pattern (for example P1D means one day). </param>
        /// <param name="timeout"> Maximum allowed script execution time specified in ISO 8601 format. Default value is P1D. </param>
        /// <param name="azPowerShellVersion"> Azure PowerShell module version to be used. </param>
        internal AzurePowerShellScript(ResourceIdentifier id, string name, ResourceType type, ManagedServiceIdentity identity, string location, IDictionary<string, string> tags, ScriptType kind, SystemData systemData, ContainerConfiguration containerSettings, StorageAccountConfiguration storageAccountSettings, CleanupOptions? cleanupPreference, ScriptProvisioningState? provisioningState, ScriptStatus status, IReadOnlyDictionary<string, object> outputs, string primaryScriptUri, IList<string> supportingScriptUris, string scriptContent, string arguments, IList<EnvironmentVariable> environmentVariables, string forceUpdateTag, TimeSpan retentionInterval, TimeSpan? timeout, string azPowerShellVersion) : base(id, name, type, identity, location, tags, kind, systemData)
        {
            ContainerSettings = containerSettings;
            StorageAccountSettings = storageAccountSettings;
            CleanupPreference = cleanupPreference;
            ProvisioningState = provisioningState;
            Status = status;
            Outputs = outputs;
            PrimaryScriptUri = primaryScriptUri;
            SupportingScriptUris = supportingScriptUris;
            ScriptContent = scriptContent;
            Arguments = arguments;
            EnvironmentVariables = environmentVariables;
            ForceUpdateTag = forceUpdateTag;
            RetentionInterval = retentionInterval;
            Timeout = timeout;
            AzPowerShellVersion = azPowerShellVersion;
            Kind = kind;
        }

        /// <summary> Container settings. </summary>
        public ContainerConfiguration ContainerSettings { get; set; }
        /// <summary> Storage Account settings. </summary>
        public StorageAccountConfiguration StorageAccountSettings { get; set; }
        /// <summary> The clean up preference when the script execution gets in a terminal state. Default setting is &apos;Always&apos;. </summary>
        public CleanupOptions? CleanupPreference { get; set; }
        /// <summary> State of the script execution. This only appears in the response. </summary>
        public ScriptProvisioningState? ProvisioningState { get; }
        /// <summary> Contains the results of script execution. </summary>
        public ScriptStatus Status { get; }
        /// <summary> List of script outputs. </summary>
        public IReadOnlyDictionary<string, object> Outputs { get; }
        /// <summary> Uri for the script. This is the entry point for the external script. </summary>
        public string PrimaryScriptUri { get; set; }
        /// <summary> Supporting files for the external script. </summary>
        public IList<string> SupportingScriptUris { get; }
        /// <summary> Script body. </summary>
        public string ScriptContent { get; set; }
        /// <summary> Command line arguments to pass to the script. Arguments are separated by spaces. ex: -Name blue* -Location &apos;West US 2&apos;. </summary>
        public string Arguments { get; set; }
        /// <summary> The environment variables to pass over to the script. </summary>
        public IList<EnvironmentVariable> EnvironmentVariables { get; }
        /// <summary> Gets or sets how the deployment script should be forced to execute even if the script resource has not changed. Can be current time stamp or a GUID. </summary>
        public string ForceUpdateTag { get; set; }
        /// <summary> Interval for which the service retains the script resource after it reaches a terminal state. Resource will be deleted when this duration expires. Duration is based on ISO 8601 pattern (for example P1D means one day). </summary>
        public TimeSpan RetentionInterval { get; set; }
        /// <summary> Maximum allowed script execution time specified in ISO 8601 format. Default value is P1D. </summary>
        public TimeSpan? Timeout { get; set; }
        /// <summary> Azure PowerShell module version to be used. </summary>
        public string AzPowerShellVersion { get; set; }
    }
}
