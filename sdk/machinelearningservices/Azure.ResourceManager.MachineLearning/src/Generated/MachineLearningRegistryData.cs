// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearning.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary> A class representing the MachineLearningRegistry data model. </summary>
    public partial class MachineLearningRegistryData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningRegistryData"/>. </summary>
        /// <param name="location"> The location. </param>
        public MachineLearningRegistryData(AzureLocation location) : base(location)
        {
            PrivateEndpointConnections = new ChangeTrackingList<RegistryPrivateEndpointConnection>();
            RegionDetails = new ChangeTrackingList<RegistryRegionArmDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningRegistryData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Managed service identity (system assigned and/or user assigned identities). </param>
        /// <param name="kind"> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type. </param>
        /// <param name="sku"> Sku details required for ARM contract for Autoscaling. </param>
        /// <param name="discoveryUri"> Discovery URL for the Registry. </param>
        /// <param name="intellectualPropertyPublisher"> IntellectualPropertyPublisher for the registry. </param>
        /// <param name="managedResourceGroup"> ResourceId of the managed RG if the registry has system created resources. </param>
        /// <param name="mlFlowRegistryUri"> MLFlow Registry URI for the Registry. </param>
        /// <param name="privateEndpointConnections"> Private endpoint connections info used for pending connections in private link portal. </param>
        /// <param name="publicNetworkAccess">
        /// Is the Registry accessible from the internet?
        /// Possible values: "Enabled" or "Disabled"
        /// </param>
        /// <param name="regionDetails"> Details of each region the registry is in. </param>
        internal MachineLearningRegistryData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, string kind, MachineLearningSku sku, Uri discoveryUri, string intellectualPropertyPublisher, ArmResourceId managedResourceGroup, Uri mlFlowRegistryUri, IList<RegistryPrivateEndpointConnection> privateEndpointConnections, string publicNetworkAccess, IList<RegistryRegionArmDetails> regionDetails) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            Kind = kind;
            Sku = sku;
            DiscoveryUri = discoveryUri;
            IntellectualPropertyPublisher = intellectualPropertyPublisher;
            ManagedResourceGroup = managedResourceGroup;
            MlFlowRegistryUri = mlFlowRegistryUri;
            PrivateEndpointConnections = privateEndpointConnections;
            PublicNetworkAccess = publicNetworkAccess;
            RegionDetails = regionDetails;
        }

        /// <summary> Managed service identity (system assigned and/or user assigned identities). </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type. </summary>
        public string Kind { get; set; }
        /// <summary> Sku details required for ARM contract for Autoscaling. </summary>
        public MachineLearningSku Sku { get; set; }
        /// <summary> Discovery URL for the Registry. </summary>
        public Uri DiscoveryUri { get; set; }
        /// <summary> IntellectualPropertyPublisher for the registry. </summary>
        public string IntellectualPropertyPublisher { get; set; }
        /// <summary> ResourceId of the managed RG if the registry has system created resources. </summary>
        internal ArmResourceId ManagedResourceGroup { get; set; }
        /// <summary>
        /// Arm ResourceId is in the format "/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Storage/storageAccounts/{StorageAccountName}"
        /// or "/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{AcrName}"
        /// </summary>
        public ResourceIdentifier ManagedResourceId
        {
            get => ManagedResourceGroup is null ? default : ManagedResourceGroup.ResourceId;
            set
            {
                if (ManagedResourceGroup is null)
                    ManagedResourceGroup = new ArmResourceId();
                ManagedResourceGroup.ResourceId = value;
            }
        }

        /// <summary> MLFlow Registry URI for the Registry. </summary>
        public Uri MlFlowRegistryUri { get; set; }
        /// <summary> Private endpoint connections info used for pending connections in private link portal. </summary>
        public IList<RegistryPrivateEndpointConnection> PrivateEndpointConnections { get; set; }
        /// <summary>
        /// Is the Registry accessible from the internet?
        /// Possible values: "Enabled" or "Disabled"
        /// </summary>
        public string PublicNetworkAccess { get; set; }
        /// <summary> Details of each region the registry is in. </summary>
        public IList<RegistryRegionArmDetails> RegionDetails { get; set; }
    }
}
