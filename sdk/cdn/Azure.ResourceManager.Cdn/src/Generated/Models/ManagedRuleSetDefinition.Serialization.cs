// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class ManagedRuleSetDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ManagedRuleSetDefinition DeserializeManagedRuleSetDefinition(JsonElement element)
        {
            Optional<Sku> sku = default;
            Optional<SystemData> systemData = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> provisioningState = default;
            Optional<string> ruleSetType = default;
            Optional<string> ruleSetVersion = default;
            Optional<IReadOnlyList<ManagedRuleGroupDefinition>> ruleGroups = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = Sku.DeserializeSku(property.Value);
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = SystemData.DeserializeSystemData(property.Value);
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
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ruleSetType"))
                        {
                            ruleSetType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ruleSetVersion"))
                        {
                            ruleSetVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ruleGroups"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ManagedRuleGroupDefinition> array = new List<ManagedRuleGroupDefinition>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ManagedRuleGroupDefinition.DeserializeManagedRuleGroupDefinition(item));
                            }
                            ruleGroups = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ManagedRuleSetDefinition(id, name, type, systemData.Value, sku.Value, provisioningState.Value, ruleSetType.Value, ruleSetVersion.Value, Optional.ToList(ruleGroups));
        }
    }
}
