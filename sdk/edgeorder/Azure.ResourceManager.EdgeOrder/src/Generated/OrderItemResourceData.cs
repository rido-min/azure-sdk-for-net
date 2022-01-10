// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EdgeOrder.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EdgeOrder
{
    /// <summary> A class representing the OrderItemResource data model. </summary>
    public partial class OrderItemResourceData : TrackedResource
    {
        /// <summary> Initializes a new instance of OrderItemResourceData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="orderItemDetails"> Represents order item details. </param>
        /// <param name="addressDetails"> Represents shipping and return address for order item. </param>
        /// <param name="orderId"> Id of the order to which order item belongs to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="orderItemDetails"/>, <paramref name="addressDetails"/>, or <paramref name="orderId"/> is null. </exception>
        public OrderItemResourceData(AzureLocation location, OrderItemDetails orderItemDetails, AddressDetails addressDetails, string orderId) : base(location)
        {
            if (orderItemDetails == null)
            {
                throw new ArgumentNullException(nameof(orderItemDetails));
            }
            if (addressDetails == null)
            {
                throw new ArgumentNullException(nameof(addressDetails));
            }
            if (orderId == null)
            {
                throw new ArgumentNullException(nameof(orderId));
            }

            OrderItemDetails = orderItemDetails;
            AddressDetails = addressDetails;
            OrderId = orderId;
        }

        /// <summary> Initializes a new instance of OrderItemResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="systemData"> Represents resource creation and update time. </param>
        /// <param name="orderItemDetails"> Represents order item details. </param>
        /// <param name="addressDetails"> Represents shipping and return address for order item. </param>
        /// <param name="startTime"> Start time of order item. </param>
        /// <param name="orderId"> Id of the order to which order item belongs to. </param>
        internal OrderItemResourceData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, AzureLocation location, SystemData systemData, OrderItemDetails orderItemDetails, AddressDetails addressDetails, DateTimeOffset? startTime, string orderId) : base(id, name, type, tags, location)
        {
            SystemData = systemData;
            OrderItemDetails = orderItemDetails;
            AddressDetails = addressDetails;
            StartTime = startTime;
            OrderId = orderId;
        }

        /// <summary> Represents resource creation and update time. </summary>
        public SystemData SystemData { get; }
        /// <summary> Represents order item details. </summary>
        public OrderItemDetails OrderItemDetails { get; set; }
        /// <summary> Represents shipping and return address for order item. </summary>
        public AddressDetails AddressDetails { get; set; }
        /// <summary> Start time of order item. </summary>
        public DateTimeOffset? StartTime { get; }
        /// <summary> Id of the order to which order item belongs to. </summary>
        public string OrderId { get; set; }
    }
}
