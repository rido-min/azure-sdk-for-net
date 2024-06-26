// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    /// <summary> Commitment towards the benefit. </summary>
    public partial class BillingBenefitsCommitment : BillingBenefitsPrice
    {
        /// <summary> Initializes a new instance of <see cref="BillingBenefitsCommitment"/>. </summary>
        public BillingBenefitsCommitment()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BillingBenefitsCommitment"/>. </summary>
        /// <param name="currencyCode"> The ISO 4217 3-letter currency code for the currency used by this purchase record. </param>
        /// <param name="amount"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="grain"> Commitment grain. </param>
        internal BillingBenefitsCommitment(string currencyCode, double? amount, IDictionary<string, BinaryData> serializedAdditionalRawData, BillingBenefitsCommitmentGrain? grain) : base(currencyCode, amount, serializedAdditionalRawData)
        {
            Grain = grain;
        }

        /// <summary> Commitment grain. </summary>
        public BillingBenefitsCommitmentGrain? Grain { get; set; }
    }
}
