// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> Unknown version of ExtendedUeInfoProperties. </summary>
    internal partial class UnknownExtendedUEInfoProperties : ExtendedUEInfoProperties
    {
        /// <summary> Initializes a new instance of <see cref="UnknownExtendedUEInfoProperties"/>. </summary>
        /// <param name="ratType"> RAT Type. </param>
        /// <param name="lastReadOn"> The timestamp of last UE info read from the packet core (UTC). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownExtendedUEInfoProperties(RatType ratType, DateTimeOffset? lastReadOn, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(ratType, lastReadOn, serializedAdditionalRawData)
        {
            RatType = ratType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownExtendedUEInfoProperties"/> for deserialization. </summary>
        internal UnknownExtendedUEInfoProperties()
        {
        }
    }
}
