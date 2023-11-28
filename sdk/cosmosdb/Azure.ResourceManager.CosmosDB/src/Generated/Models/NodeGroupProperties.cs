// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The properties of the node group on a cluster. </summary>
    public partial class NodeGroupProperties
    {
        /// <summary> Initializes a new instance of <see cref="NodeGroupProperties"/>. </summary>
        public NodeGroupProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NodeGroupProperties"/>. </summary>
        /// <param name="sku"> The resource sku for the node group. This defines the size of CPU and memory that is provisioned for each node. Example values: 'M30', 'M40'. </param>
        /// <param name="diskSizeInGB"> The disk storage size for the node group in GB. Example values: 128, 256, 512, 1024. </param>
        /// <param name="enableHa"> Whether high availability is enabled on the node group. </param>
        internal NodeGroupProperties(string sku, long? diskSizeInGB, bool? enableHa)
        {
            Sku = sku;
            DiskSizeInGB = diskSizeInGB;
            EnableHa = enableHa;
        }

        /// <summary> The resource sku for the node group. This defines the size of CPU and memory that is provisioned for each node. Example values: 'M30', 'M40'. </summary>
        public string Sku { get; set; }
        /// <summary> The disk storage size for the node group in GB. Example values: 128, 256, 512, 1024. </summary>
        public long? DiskSizeInGB { get; set; }
        /// <summary> Whether high availability is enabled on the node group. </summary>
        public bool? EnableHa { get; set; }
    }
}
