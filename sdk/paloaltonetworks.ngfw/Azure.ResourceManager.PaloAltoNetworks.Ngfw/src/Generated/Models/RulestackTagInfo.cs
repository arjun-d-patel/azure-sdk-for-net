// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> Tag. </summary>
    public partial class RulestackTagInfo
    {
        /// <summary> Initializes a new instance of <see cref="RulestackTagInfo"/>. </summary>
        /// <param name="key"> tag name. </param>
        /// <param name="value"> tag value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public RulestackTagInfo(string key, string value)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            Key = key;
            Value = value;
        }

        /// <summary> tag name. </summary>
        public string Key { get; set; }
        /// <summary> tag value. </summary>
        public string Value { get; set; }
    }
}
