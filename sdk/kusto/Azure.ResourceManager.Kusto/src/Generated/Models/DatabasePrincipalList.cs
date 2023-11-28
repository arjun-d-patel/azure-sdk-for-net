// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The list Kusto database principals operation request. </summary>
    public partial class DatabasePrincipalList
    {
        /// <summary> Initializes a new instance of <see cref="DatabasePrincipalList"/>. </summary>
        public DatabasePrincipalList()
        {
            Value = new ChangeTrackingList<KustoDatabasePrincipal>();
        }

        /// <summary> The list of Kusto database principals. </summary>
        public IList<KustoDatabasePrincipal> Value { get; }
    }
}
