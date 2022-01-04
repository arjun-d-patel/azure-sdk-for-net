// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary> A class representing the VMwareHost data model. </summary>
    public partial class VMwareHostData : TrackedResource
    {
        /// <summary> Initializes a new instance of VMwareHostData. </summary>
        /// <param name="location"> The location. </param>
        public VMwareHostData(AzureLocation location) : base(location)
        {
            Statuses = new ChangeTrackingList<ResourceStatus>();
        }

        /// <summary> Initializes a new instance of VMwareHostData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> Gets or sets the extended location. </param>
        /// <param name="systemData"> The system data. </param>
        /// <param name="kind"> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </param>
        /// <param name="uuid"> Gets or sets a unique identifier for this resource. </param>
        /// <param name="vCenterId"> Gets or sets the ARM Id of the vCenter resource in which this host resides. </param>
        /// <param name="moRefId"> Gets or sets the vCenter MoRef (Managed Object Reference) ID for the host. </param>
        /// <param name="inventoryItemId"> Gets or sets the inventory Item ID for the host. </param>
        /// <param name="moName"> Gets or sets the vCenter Managed Object name for the host. </param>
        /// <param name="statuses"> The resource status information. </param>
        /// <param name="customResourceName"> Gets the name of the corresponding resource in Kubernetes. </param>
        /// <param name="provisioningState"> Gets or sets the provisioning state. </param>
        internal VMwareHostData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, AzureLocation location, CheckNameAvailabilityRequest extendedLocation, SystemData systemData, string kind, string uuid, string vCenterId, string moRefId, string inventoryItemId, string moName, IReadOnlyList<ResourceStatus> statuses, string customResourceName, string provisioningState) : base(id, name, type, tags, location)
        {
            ExtendedLocation = extendedLocation;
            SystemData = systemData;
            Kind = kind;
            Uuid = uuid;
            VCenterId = vCenterId;
            MoRefId = moRefId;
            InventoryItemId = inventoryItemId;
            MoName = moName;
            Statuses = statuses;
            CustomResourceName = customResourceName;
            ProvisioningState = provisioningState;
        }

        /// <summary> Gets or sets the extended location. </summary>
        public CheckNameAvailabilityRequest ExtendedLocation { get; set; }
        /// <summary> The system data. </summary>
        public SystemData SystemData { get; }
        /// <summary> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </summary>
        public string Kind { get; set; }
        /// <summary> Gets or sets a unique identifier for this resource. </summary>
        public string Uuid { get; }
        /// <summary> Gets or sets the ARM Id of the vCenter resource in which this host resides. </summary>
        public string VCenterId { get; set; }
        /// <summary> Gets or sets the vCenter MoRef (Managed Object Reference) ID for the host. </summary>
        public string MoRefId { get; set; }
        /// <summary> Gets or sets the inventory Item ID for the host. </summary>
        public string InventoryItemId { get; set; }
        /// <summary> Gets or sets the vCenter Managed Object name for the host. </summary>
        public string MoName { get; }
        /// <summary> The resource status information. </summary>
        public IReadOnlyList<ResourceStatus> Statuses { get; }
        /// <summary> Gets the name of the corresponding resource in Kubernetes. </summary>
        public string CustomResourceName { get; }
        /// <summary> Gets or sets the provisioning state. </summary>
        public string ProvisioningState { get; }
    }
}
