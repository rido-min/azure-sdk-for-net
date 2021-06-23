﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.AI.Personalizer;
using Azure.AI.Personalizer.Models;
using NUnit.Framework;

namespace Microsoft.Azure.AI.Personalizer.Tests
{
    public class MultiSlotRewardTests: PersonalizerTestBase
    {
        public MultiSlotRewardTests(bool isAsync) : base(isAsync)
        {
        }

        [Test]
        public async Task Reward()
        {
            PersonalizerClient client = GetPersonalizerClient();
            SlotReward slotReward = new SlotReward("testSlot", 1);
            MultiSlotRewardRequest rewardRequest = new MultiSlotRewardRequest(new List<SlotReward> { slotReward });
            await client.MultiSlotEvents.RewardAsync("123456789", rewardRequest);
        }
    }
}
