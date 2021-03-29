// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    public partial class RegistryArtifactProperties
    {
        internal static RegistryArtifactProperties DeserializeRegistryArtifactProperties(JsonElement element)
        {
            Optional<string> imageName = default;
            Optional<string> digest = default;
            Optional<long> imageSize = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<DateTimeOffset> lastUpdateTime = default;
            Optional<string> architecture = default;
            Optional<string> os = default;
            Optional<IReadOnlyList<RegistryArtifactProperties>> references = default;
            Optional<IReadOnlyList<string>> tags = default;
            Optional<ContentProperties> changeableAttributes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageName"))
                {
                    imageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("manifest"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("digest"))
                        {
                            digest = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("imageSize"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            imageSize = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("createdTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastUpdateTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastUpdateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("architecture"))
                        {
                            architecture = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("os"))
                        {
                            os = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("references"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<RegistryArtifactProperties> array = new List<RegistryArtifactProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeserializeRegistryArtifactProperties(item));
                            }
                            references = array;
                            continue;
                        }
                        if (property0.NameEquals("tags"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            tags = array;
                            continue;
                        }
                        if (property0.NameEquals("changeableAttributes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            changeableAttributes = ContentProperties.DeserializeContentProperties(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RegistryArtifactProperties(imageName.Value, digest.Value, Optional.ToNullable(imageSize), Optional.ToNullable(createdTime), Optional.ToNullable(lastUpdateTime), architecture.Value, os.Value, Optional.ToList(references), Optional.ToList(tags), changeableAttributes.Value);
        }
    }
}
