// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The CustomContext. </summary>
    internal partial class CustomContextInternal
    {
        /// <summary> Initializes a new instance of <see cref="CustomContextInternal"/>. </summary>
        public CustomContextInternal()
        {
            VoipHeaders = new ChangeTrackingDictionary<string, string>();
            SipHeaders = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> VoipHeaders { get; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> SipHeaders { get; }
    }
}
