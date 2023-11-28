// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core.Tests.Common;

namespace Azure.Core.Tests.Models.ResourceManager.Resources
{
    public partial class ResourceTypeAliasPath : IUtf8JsonSerializable, IJsonModel<ResourceTypeAliasPath>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceTypeAliasPath>)this).Write(writer, ModelReaderWriterHelper.WireOptions);

        internal static ResourceTypeAliasPath DeserializeResourceTypeAliasPath(JsonElement element, ModelReaderWriterOptions options = default)
        {
            options ??= ModelReaderWriterHelper.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> path = default;
            Optional<IReadOnlyList<string>> apiVersions = default;
            Optional<ResourceTypeAliasPattern> pattern = default;
            Optional<ResourceTypeAliasPathMetadata> metadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    apiVersions = array;
                    continue;
                }
                if (property.NameEquals("pattern"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pattern = ResourceTypeAliasPattern.DeserializeResourceTypeAliasPattern(property.Value, options);
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = ResourceTypeAliasPathMetadata.DeserializeResourceTypeAliasPathMetadata(property.Value, options);
                    continue;
                }
            }
            return new ResourceTypeAliasPath(path.Value, Optional.ToList(apiVersions), pattern.Value, metadata.Value);
        }

        void IJsonModel<ResourceTypeAliasPath>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => Serialize(writer, options);

        private void Serialize(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsCollectionDefined(ApiVersions))
            {
                writer.WritePropertyName("apiVersions"u8);
                writer.WriteStartArray();
                foreach (var item in ApiVersions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Pattern))
            {
                writer.WritePropertyName("pattern"u8);
                writer.WriteObjectValue(Pattern);
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteObjectValue(Metadata);
            }
            writer.WriteEndObject();
        }

        private struct ResourceTypeAliasPathProperties
        {
            public Optional<string> Path { get; set; }
            public Optional<IReadOnlyList<string>> ApiVersions { get; set; }
            public Optional<ResourceTypeAliasPattern> Pattern { get; set; }
            public Optional<ResourceTypeAliasPathMetadata> Metadata { get; set; }
        }

        ResourceTypeAliasPath IJsonModel<ResourceTypeAliasPath>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceTypeAliasPath(doc.RootElement, options);
        }

        ResourceTypeAliasPath IPersistableModel<ResourceTypeAliasPath>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            using var doc = JsonDocument.Parse(data);
            return DeserializeResourceTypeAliasPath(doc.RootElement, options);
        }

        BinaryData IPersistableModel<ResourceTypeAliasPath>.Write(ModelReaderWriterOptions options)
        {
            ModelReaderWriterHelper.ValidateFormat(this, options.Format);

            return ModelReaderWriter.Write(this, options);
        }

        string IPersistableModel<ResourceTypeAliasPath>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
