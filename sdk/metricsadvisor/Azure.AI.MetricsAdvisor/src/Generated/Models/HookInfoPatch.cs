// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary>
    /// The HookInfoPatch.
    /// Please note <see cref="HookInfoPatch"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="EmailHookInfoPatch"/> and <see cref="WebhookHookInfoPatch"/>.
    /// </summary>
    internal partial class HookInfoPatch
    {
        /// <summary> Initializes a new instance of <see cref="HookInfoPatch"/>. </summary>
        public HookInfoPatch()
        {
            Admins = new ChangeTrackingList<string>();
        }

        /// <summary> hook type. </summary>
        internal NotificationHookKind HookType { get; set; }
        /// <summary> hook unique name. </summary>
        public string HookName { get; set; }
        /// <summary> hook description. </summary>
        public string Description { get; set; }
        /// <summary> hook external link. </summary>
        public string ExternalLink { get; set; }
    }
}
