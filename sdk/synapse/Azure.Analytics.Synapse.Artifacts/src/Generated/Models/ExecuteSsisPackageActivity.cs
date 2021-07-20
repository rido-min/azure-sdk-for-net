// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Execute SSIS package activity. </summary>
    public partial class ExecuteSsisPackageActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of ExecuteSsisPackageActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="packageLocation"> SSIS package location. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="packageLocation"/>, or <paramref name="connectVia"/> is null. </exception>
        public ExecuteSsisPackageActivity(string name, SsisPackageLocation packageLocation, IntegrationRuntimeReference connectVia) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (packageLocation == null)
            {
                throw new ArgumentNullException(nameof(packageLocation));
            }
            if (connectVia == null)
            {
                throw new ArgumentNullException(nameof(connectVia));
            }

            PackageLocation = packageLocation;
            ConnectVia = connectVia;
            ProjectParameters = new ChangeTrackingDictionary<string, SsisExecutionParameter>();
            PackageParameters = new ChangeTrackingDictionary<string, SsisExecutionParameter>();
            ProjectConnectionManagers = new ChangeTrackingDictionary<string, IDictionary<string, SsisExecutionParameter>>();
            PackageConnectionManagers = new ChangeTrackingDictionary<string, IDictionary<string, SsisExecutionParameter>>();
            PropertyOverrides = new ChangeTrackingDictionary<string, SsisPropertyOverride>();
            Type = "ExecuteSSISPackage";
        }

        /// <summary> Initializes a new instance of ExecuteSsisPackageActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="packageLocation"> SSIS package location. </param>
        /// <param name="runtime"> Specifies the runtime to execute SSIS package. The value should be &quot;x86&quot; or &quot;x64&quot;. Type: string (or Expression with resultType string). </param>
        /// <param name="loggingLevel"> The logging level of SSIS package execution. Type: string (or Expression with resultType string). </param>
        /// <param name="environmentPath"> The environment path to execute the SSIS package. Type: string (or Expression with resultType string). </param>
        /// <param name="executionCredential"> The package execution credential. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="projectParameters"> The project level parameters to execute the SSIS package. </param>
        /// <param name="packageParameters"> The package level parameters to execute the SSIS package. </param>
        /// <param name="projectConnectionManagers"> The project level connection managers to execute the SSIS package. </param>
        /// <param name="packageConnectionManagers"> The package level connection managers to execute the SSIS package. </param>
        /// <param name="propertyOverrides"> The property overrides to execute the SSIS package. </param>
        /// <param name="logLocation"> SSIS package execution log location. </param>
        internal ExecuteSsisPackageActivity(string name, string type, string description, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, LinkedServiceReference linkedServiceName, ActivityPolicy policy, SsisPackageLocation packageLocation, object runtime, object loggingLevel, object environmentPath, SsisExecutionCredential executionCredential, IntegrationRuntimeReference connectVia, IDictionary<string, SsisExecutionParameter> projectParameters, IDictionary<string, SsisExecutionParameter> packageParameters, IDictionary<string, IDictionary<string, SsisExecutionParameter>> projectConnectionManagers, IDictionary<string, IDictionary<string, SsisExecutionParameter>> packageConnectionManagers, IDictionary<string, SsisPropertyOverride> propertyOverrides, SsisLogLocation logLocation) : base(name, type, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            PackageLocation = packageLocation;
            Runtime = runtime;
            LoggingLevel = loggingLevel;
            EnvironmentPath = environmentPath;
            ExecutionCredential = executionCredential;
            ConnectVia = connectVia;
            ProjectParameters = projectParameters;
            PackageParameters = packageParameters;
            ProjectConnectionManagers = projectConnectionManagers;
            PackageConnectionManagers = packageConnectionManagers;
            PropertyOverrides = propertyOverrides;
            LogLocation = logLocation;
            Type = type ?? "ExecuteSSISPackage";
        }

        /// <summary> SSIS package location. </summary>
        public SsisPackageLocation PackageLocation { get; set; }
        /// <summary> Specifies the runtime to execute SSIS package. The value should be &quot;x86&quot; or &quot;x64&quot;. Type: string (or Expression with resultType string). </summary>
        public object Runtime { get; set; }
        /// <summary> The logging level of SSIS package execution. Type: string (or Expression with resultType string). </summary>
        public object LoggingLevel { get; set; }
        /// <summary> The environment path to execute the SSIS package. Type: string (or Expression with resultType string). </summary>
        public object EnvironmentPath { get; set; }
        /// <summary> The package execution credential. </summary>
        public SsisExecutionCredential ExecutionCredential { get; set; }
        /// <summary> The integration runtime reference. </summary>
        public IntegrationRuntimeReference ConnectVia { get; set; }
        /// <summary> The project level parameters to execute the SSIS package. </summary>
        public IDictionary<string, SsisExecutionParameter> ProjectParameters { get; }
        /// <summary> The package level parameters to execute the SSIS package. </summary>
        public IDictionary<string, SsisExecutionParameter> PackageParameters { get; }
        /// <summary> The project level connection managers to execute the SSIS package. </summary>
        public IDictionary<string, IDictionary<string, SsisExecutionParameter>> ProjectConnectionManagers { get; }
        /// <summary> The package level connection managers to execute the SSIS package. </summary>
        public IDictionary<string, IDictionary<string, SsisExecutionParameter>> PackageConnectionManagers { get; }
        /// <summary> The property overrides to execute the SSIS package. </summary>
        public IDictionary<string, SsisPropertyOverride> PropertyOverrides { get; }
        /// <summary> SSIS package execution log location. </summary>
        public SsisLogLocation LogLocation { get; set; }
    }
}
