// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> AuthenticationPolicy of type Open. </summary>
    internal partial class OpenAuthenticationAccessPolicies
    {
        /// <summary> Initializes a new instance of <see cref="OpenAuthenticationAccessPolicies"/>. </summary>
        public OpenAuthenticationAccessPolicies()
        {
            AccessPolicies = new ChangeTrackingDictionary<string, OpenAuthenticationAccessPolicy>();
        }

        /// <summary> Initializes a new instance of <see cref="OpenAuthenticationAccessPolicies"/>. </summary>
        /// <param name="accessPolicies"> Open authentication policies. </param>
        internal OpenAuthenticationAccessPolicies(IDictionary<string, OpenAuthenticationAccessPolicy> accessPolicies)
        {
            AccessPolicies = accessPolicies;
        }

        /// <summary> Open authentication policies. </summary>
        public IDictionary<string, OpenAuthenticationAccessPolicy> AccessPolicies { get; }
    }
}
