// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication
{
    internal partial class CommunicationIdentifierModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RawId))
            {
                writer.WritePropertyName("rawId"u8);
                writer.WriteStringValue(RawId);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind.Value.ToString());
            }
            if (Optional.IsDefined(CommunicationUser))
            {
                writer.WritePropertyName("communicationUser"u8);
                writer.WriteObjectValue(CommunicationUser);
            }
            if (Optional.IsDefined(PhoneNumber))
            {
                writer.WritePropertyName("phoneNumber"u8);
                writer.WriteObjectValue(PhoneNumber);
            }
            if (Optional.IsDefined(MicrosoftTeamsUser))
            {
                writer.WritePropertyName("microsoftTeamsUser"u8);
                writer.WriteObjectValue(MicrosoftTeamsUser);
            }
            if (Optional.IsDefined(MicrosoftTeamsApp))
            {
                writer.WritePropertyName("microsoftTeamsApp"u8);
                writer.WriteObjectValue(MicrosoftTeamsApp);
            }
            writer.WriteEndObject();
        }

        internal static CommunicationIdentifierModel DeserializeCommunicationIdentifierModel(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> rawId = default;
            Optional<CommunicationIdentifierModelKind> kind = default;
            Optional<CommunicationUserIdentifierModel> communicationUser = default;
            Optional<PhoneNumberIdentifierModel> phoneNumber = default;
            Optional<MicrosoftTeamsUserIdentifierModel> microsoftTeamsUser = default;
            Optional<MicrosoftTeamsAppIdentifierModel> microsoftTeamsApp = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rawId"u8))
                {
                    rawId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new CommunicationIdentifierModelKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("communicationUser"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    communicationUser = CommunicationUserIdentifierModel.DeserializeCommunicationUserIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("phoneNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    phoneNumber = PhoneNumberIdentifierModel.DeserializePhoneNumberIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("microsoftTeamsUser"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    microsoftTeamsUser = MicrosoftTeamsUserIdentifierModel.DeserializeMicrosoftTeamsUserIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("microsoftTeamsApp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    microsoftTeamsApp = MicrosoftTeamsAppIdentifierModel.DeserializeMicrosoftTeamsAppIdentifierModel(property.Value);
                    continue;
                }
            }
            return new CommunicationIdentifierModel(rawId.Value, Optional.ToNullable(kind), communicationUser.Value, phoneNumber.Value, microsoftTeamsUser.Value, microsoftTeamsApp.Value);
        }
    }
}
