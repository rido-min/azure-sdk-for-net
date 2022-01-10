// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute
{
    public partial class VirtualMachineExtensionImageData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(OperatingSystem))
            {
                writer.WritePropertyName("operatingSystem");
                writer.WriteStringValue(OperatingSystem);
            }
            if (Optional.IsDefined(ComputeRole))
            {
                writer.WritePropertyName("computeRole");
                writer.WriteStringValue(ComputeRole);
            }
            if (Optional.IsDefined(HandlerSchema))
            {
                writer.WritePropertyName("handlerSchema");
                writer.WriteStringValue(HandlerSchema);
            }
            if (Optional.IsDefined(VmScaleSetEnabled))
            {
                writer.WritePropertyName("vmScaleSetEnabled");
                writer.WriteBooleanValue(VmScaleSetEnabled.Value);
            }
            if (Optional.IsDefined(SupportsMultipleExtensions))
            {
                writer.WritePropertyName("supportsMultipleExtensions");
                writer.WriteBooleanValue(SupportsMultipleExtensions.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VirtualMachineExtensionImageData DeserializeVirtualMachineExtensionImageData(JsonElement element)
        {
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> operatingSystem = default;
            Optional<string> computeRole = default;
            Optional<string> handlerSchema = default;
            Optional<bool> vmScaleSetEnabled = default;
            Optional<bool> supportsMultipleExtensions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("operatingSystem"))
                        {
                            operatingSystem = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("computeRole"))
                        {
                            computeRole = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("handlerSchema"))
                        {
                            handlerSchema = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vmScaleSetEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            vmScaleSetEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("supportsMultipleExtensions"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            supportsMultipleExtensions = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VirtualMachineExtensionImageData(id, name, type, tags, location, operatingSystem.Value, computeRole.Value, handlerSchema.Value, Optional.ToNullable(vmScaleSetEnabled), Optional.ToNullable(supportsMultipleExtensions));
        }
    }
}
