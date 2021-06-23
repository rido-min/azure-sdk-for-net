﻿using Microsoft.Azure.Test.HttpRecorder;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System.IO;
using System.Threading.Tasks;
using Azure.AI.Personalizer;
using Azure.AI.Personalizer.Models;
using NUnit.Framework;

namespace Microsoft.Azure.AI.Personalizer.Tests
{
    public class ModelTests : PersonalizerTestBase
    {
        public ModelTests(bool isAsync) : base(isAsync)
        {
        }

        [Test]
        public async Task GetModel()
        {
            PersonalizerClient client = GetPersonalizerClient();
            Stream stream = await client.Model.GetAsync();
            Assert.AreNotEqual(-1 , stream.ReadByte());
        }

        [Test]
        public async Task ResetModel()
        {
            PersonalizerClient client = GetPersonalizerClient();
            await client.Model.ResetAsync();
        }

        [Test]
        public async Task GetModelProperties()
        {
            PersonalizerClient client = GetPersonalizerClient();
            ModelProperties modelProperties = await client.Model.GetPropertiesAsync();
            Assert.True(modelProperties.CreationTime != null);
            Assert.True(modelProperties.LastModifiedTime != null);
        }
    }
}
