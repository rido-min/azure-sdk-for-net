// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.Messages
{
    /// <summary> Unknown version of NotificationContent. </summary>
    internal partial class UnknownNotificationContent : NotificationContent
    {
        /// <summary> Initializes a new instance of <see cref="UnknownNotificationContent"/>. </summary>
        /// <param name="channelRegistrationId"> The Channel Registration ID for the Business Identifier. </param>
        /// <param name="to"> The native external platform user identifiers of the recipient. </param>
        /// <param name="kind"> The type discriminator describing a notification type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownNotificationContent(Guid channelRegistrationId, IList<string> to, CommunicationMessageKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(channelRegistrationId, to, kind, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="UnknownNotificationContent"/> for deserialization. </summary>
        internal UnknownNotificationContent()
        {
        }
    }
}
