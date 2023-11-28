// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The TypedErrorInfo. </summary>
    public partial class TypedErrorInfo
    {
        /// <summary> Initializes a new instance of <see cref="TypedErrorInfo"/>. </summary>
        /// <param name="typedErrorInfoType"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="typedErrorInfoType"/> is null. </exception>
        public TypedErrorInfo(string typedErrorInfoType)
        {
            Argument.AssertNotNull(typedErrorInfoType, nameof(typedErrorInfoType));

            TypedErrorInfoType = typedErrorInfoType;
        }

        /// <summary> Initializes a new instance of <see cref="TypedErrorInfo"/>. </summary>
        /// <param name="typedErrorInfoType"></param>
        /// <param name="info"> Any object. </param>
        internal TypedErrorInfo(string typedErrorInfoType, BinaryData info)
        {
            TypedErrorInfoType = typedErrorInfoType;
            Info = info;
        }

        /// <summary> Gets or sets the typed error info type. </summary>
        public string TypedErrorInfoType { get; set; }
        /// <summary>
        /// Any object
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Info { get; }
    }
}
