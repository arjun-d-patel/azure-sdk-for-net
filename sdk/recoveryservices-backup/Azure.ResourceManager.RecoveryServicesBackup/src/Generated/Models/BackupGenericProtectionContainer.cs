// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary>
    /// Base class for container with backup items. Containers with specific workloads are derived from this class.
    /// Please note <see cref="BackupGenericProtectionContainer"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="BackupServerContainer"/>, <see cref="SqlContainer"/>, <see cref="WorkloadContainer"/>, <see cref="DpmContainer"/>, <see cref="GenericContainer"/>, <see cref="IaasVmContainer"/>, <see cref="IaasClassicComputeVmContainer"/>, <see cref="IaasComputeVmContainer"/>, <see cref="SqlAvailabilityGroupWorkloadProtectionContainer"/>, <see cref="StorageContainer"/>, <see cref="VmAppContainerProtectionContainer"/> and <see cref="MabContainer"/>.
    /// </summary>
    public abstract partial class BackupGenericProtectionContainer
    {
        /// <summary> Initializes a new instance of <see cref="BackupGenericProtectionContainer"/>. </summary>
        protected BackupGenericProtectionContainer()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BackupGenericProtectionContainer"/>. </summary>
        /// <param name="friendlyName"> Friendly name of the container. </param>
        /// <param name="backupManagementType"> Type of backup management for the container. </param>
        /// <param name="registrationStatus"> Status of registration of the container with the Recovery Services Vault. </param>
        /// <param name="healthStatus"> Status of health of the container. </param>
        /// <param name="containerType">
        /// Type of the container. The value of this property for: 1. Compute Azure VM is Microsoft.Compute/virtualMachines 2.
        /// Classic Compute Azure VM is Microsoft.ClassicCompute/virtualMachines 3. Windows machines (like MAB, DPM etc) is
        /// Windows 4. Azure SQL instance is AzureSqlContainer. 5. Storage containers is StorageContainer. 6. Azure workload
        /// Backup is VMAppContainer
        /// </param>
        /// <param name="protectableObjectType"> Type of the protectable object associated with this container. </param>
        internal BackupGenericProtectionContainer(string friendlyName, BackupManagementType? backupManagementType, string registrationStatus, string healthStatus, ProtectableContainerType containerType, string protectableObjectType)
        {
            FriendlyName = friendlyName;
            BackupManagementType = backupManagementType;
            RegistrationStatus = registrationStatus;
            HealthStatus = healthStatus;
            ContainerType = containerType;
            ProtectableObjectType = protectableObjectType;
        }

        /// <summary> Friendly name of the container. </summary>
        public string FriendlyName { get; set; }
        /// <summary> Type of backup management for the container. </summary>
        public BackupManagementType? BackupManagementType { get; set; }
        /// <summary> Status of registration of the container with the Recovery Services Vault. </summary>
        public string RegistrationStatus { get; set; }
        /// <summary> Status of health of the container. </summary>
        public string HealthStatus { get; set; }
        /// <summary>
        /// Type of the container. The value of this property for: 1. Compute Azure VM is Microsoft.Compute/virtualMachines 2.
        /// Classic Compute Azure VM is Microsoft.ClassicCompute/virtualMachines 3. Windows machines (like MAB, DPM etc) is
        /// Windows 4. Azure SQL instance is AzureSqlContainer. 5. Storage containers is StorageContainer. 6. Azure workload
        /// Backup is VMAppContainer
        /// </summary>
        internal ProtectableContainerType ContainerType { get; set; }
        /// <summary> Type of the protectable object associated with this container. </summary>
        public string ProtectableObjectType { get; set; }
    }
}
