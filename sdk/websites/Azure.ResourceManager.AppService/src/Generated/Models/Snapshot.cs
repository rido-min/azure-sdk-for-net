// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> A snapshot of an app. </summary>
    public partial class Snapshot : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of Snapshot. </summary>
        public Snapshot()
        {
        }

        /// <summary> Initializes a new instance of Snapshot. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="time"> The time the snapshot was taken. </param>
        internal Snapshot(ResourceIdentifier id, string name, ResourceType type, string kind, string time) : base(id, name, type, kind)
        {
            Time = time;
        }

        /// <summary> The time the snapshot was taken. </summary>
        public string Time { get; }
    }
}
