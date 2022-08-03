// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    public partial class SqlElasticPoolResourceSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ZoneRedundant))
            {
                writer.WritePropertyName("zoneRedundant");
                writer.WriteStringValue(ZoneRedundant.Value.ToString());
            }
            writer.WritePropertyName("resourceType");
            writer.WriteStringValue(ResourceType);
            writer.WritePropertyName("targetResourceName");
            writer.WriteStringValue(TargetResourceName);
            writer.WriteEndObject();
        }

        internal static SqlElasticPoolResourceSettings DeserializeSqlElasticPoolResourceSettings(JsonElement element)
        {
            Optional<IDictionary<string, string>> tags = default;
            Optional<ResourceZoneRedundantSetting> zoneRedundant = default;
            string resourceType = default;
            string targetResourceName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("zoneRedundant"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    zoneRedundant = new ResourceZoneRedundantSetting(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceType"))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceName"))
                {
                    targetResourceName = property.Value.GetString();
                    continue;
                }
            }
            return new SqlElasticPoolResourceSettings(resourceType, targetResourceName, Optional.ToDictionary(tags), Optional.ToNullable(zoneRedundant));
        }
    }
}
