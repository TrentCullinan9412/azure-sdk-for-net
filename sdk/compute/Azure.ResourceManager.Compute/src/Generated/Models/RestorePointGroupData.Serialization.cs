// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class RestorePointGroupData : IUtf8JsonSerializable
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
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source");
                writer.WriteObjectValue(Source);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RestorePointGroupData DeserializeRestorePointGroupData(JsonElement element)
        {
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<RestorePointCollectionSourceProperties> source = default;
            Optional<string> provisioningState = default;
            Optional<string> restorePointCollectionId = default;
            Optional<IReadOnlyList<RestorePointData>> restorePoints = default;
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
                        if (property0.NameEquals("source"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            source = RestorePointCollectionSourceProperties.DeserializeRestorePointCollectionSourceProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("restorePointCollectionId"))
                        {
                            restorePointCollectionId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("restorePoints"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<RestorePointData> array = new List<RestorePointData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RestorePointData.DeserializeRestorePointData(item));
                            }
                            restorePoints = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RestorePointGroupData(id, name, type, tags, location, source.Value, provisioningState.Value, restorePointCollectionId.Value, Optional.ToList(restorePoints));
        }
    }
}
