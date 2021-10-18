// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GalleryArtifactVersionSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("uri");
                writer.WriteStringValue(Uri);
            }
            writer.WriteEndObject();
        }

        internal static GalleryArtifactVersionSource DeserializeGalleryArtifactVersionSource(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> uri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("uri"))
                {
                    uri = property.Value.GetString();
                    continue;
                }
            }
            return new GalleryArtifactVersionSource(id.Value, uri.Value);
        }
    }
}
