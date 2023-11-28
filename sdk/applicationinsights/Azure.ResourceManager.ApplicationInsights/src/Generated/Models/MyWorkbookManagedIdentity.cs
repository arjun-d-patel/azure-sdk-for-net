// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> Customer Managed Identity. </summary>
    public partial class MyWorkbookManagedIdentity
    {
        /// <summary> Initializes a new instance of <see cref="MyWorkbookManagedIdentity"/>. </summary>
        public MyWorkbookManagedIdentity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MyWorkbookManagedIdentity"/>. </summary>
        /// <param name="userAssignedIdentities"> Customer Managed Identity. </param>
        /// <param name="identityType"> The identity type. </param>
        internal MyWorkbookManagedIdentity(MyWorkbookUserAssignedIdentities userAssignedIdentities, MyWorkbookManagedIdentityType? identityType)
        {
            UserAssignedIdentities = userAssignedIdentities;
            IdentityType = identityType;
        }

        /// <summary> Customer Managed Identity. </summary>
        public MyWorkbookUserAssignedIdentities UserAssignedIdentities { get; set; }
        /// <summary> The identity type. </summary>
        public MyWorkbookManagedIdentityType? IdentityType { get; set; }
    }
}
