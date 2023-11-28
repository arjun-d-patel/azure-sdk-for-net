// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.DataMigration.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataMigration
{
    /// <summary>
    /// A class representing the ProjectTask data model.
    /// A task resource
    /// </summary>
    public partial class ProjectTaskData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ProjectTaskData"/>. </summary>
        public ProjectTaskData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProjectTaskData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> HTTP strong entity tag value. This is ignored if submitted. </param>
        /// <param name="properties">
        /// Custom task properties
        /// Please note <see cref="ProjectTaskProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ConnectToMongoDBTaskProperties"/>, <see cref="ConnectToSourceMySqlTaskProperties"/>, <see cref="ConnectToSourceOracleSyncTaskProperties"/>, <see cref="ConnectToSourcePostgreSqlSyncTaskProperties"/>, <see cref="ConnectToSourceSqlServerTaskProperties"/>, <see cref="ConnectToSourceSqlServerSyncTaskProperties"/>, <see cref="ConnectToTargetAzureDBForMySqlTaskProperties"/>, <see cref="ConnectToTargetAzureDBForPostgreSqlSyncTaskProperties"/>, <see cref="ConnectToTargetSqlMITaskProperties"/>, <see cref="ConnectToTargetSqlMISyncTaskProperties"/>, <see cref="ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskProperties"/>, <see cref="ConnectToTargetSqlDBTaskProperties"/>, <see cref="ConnectToTargetSqlDBSyncTaskProperties"/>, <see cref="GetTdeCertificatesSqlTaskProperties"/>, <see cref="GetUserTablesSqlSyncTaskProperties"/>, <see cref="GetUserTablesSqlTaskProperties"/>, <see cref="GetUserTablesMySqlTaskProperties"/>, <see cref="GetUserTablesOracleTaskProperties"/>, <see cref="GetUserTablesPostgreSqlTaskProperties"/>, <see cref="MigrateMongoDBTaskProperties"/>, <see cref="MigrateMySqlAzureDBForMySqlOfflineTaskProperties"/>, <see cref="MigrateMySqlAzureDBForMySqlSyncTaskProperties"/>, <see cref="MigrateOracleAzureDBForPostgreSqlSyncTaskProperties"/>, <see cref="MigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties"/>, <see cref="MigrateSqlServerSqlDBSyncTaskProperties"/>, <see cref="MigrateSqlServerSqlMITaskProperties"/>, <see cref="MigrateSqlServerSqlMISyncTaskProperties"/>, <see cref="MigrateSqlServerSqlDBTaskProperties"/>, <see cref="MigrateSsisTaskProperties"/>, <see cref="MigrateSchemaSqlServerSqlDBTaskProperties"/>, <see cref="CheckOciDriverTaskProperties"/>, <see cref="InstallOciDriverTaskProperties"/>, <see cref="UploadOciDriverTaskProperties"/>, <see cref="ValidateMongoDBTaskProperties"/>, <see cref="ValidateOracleAzureDBForPostgreSqlSyncTaskProperties"/>, <see cref="ValidateMigrationInputSqlServerSqlMITaskProperties"/>, <see cref="ValidateMigrationInputSqlServerSqlMISyncTaskProperties"/> and <see cref="ValidateMigrationInputSqlServerSqlDBSyncTaskProperties"/>.
        /// </param>
        internal ProjectTaskData(ResourceIdentifier id, string name, Core.ResourceType resourceType, SystemData systemData, ETag? etag, ProjectTaskProperties properties) : base(id, name, resourceType, systemData)
        {
            ETag = etag;
            Properties = properties;
        }

        /// <summary> HTTP strong entity tag value. This is ignored if submitted. </summary>
        public ETag? ETag { get; set; }
        /// <summary>
        /// Custom task properties
        /// Please note <see cref="ProjectTaskProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ConnectToMongoDBTaskProperties"/>, <see cref="ConnectToSourceMySqlTaskProperties"/>, <see cref="ConnectToSourceOracleSyncTaskProperties"/>, <see cref="ConnectToSourcePostgreSqlSyncTaskProperties"/>, <see cref="ConnectToSourceSqlServerTaskProperties"/>, <see cref="ConnectToSourceSqlServerSyncTaskProperties"/>, <see cref="ConnectToTargetAzureDBForMySqlTaskProperties"/>, <see cref="ConnectToTargetAzureDBForPostgreSqlSyncTaskProperties"/>, <see cref="ConnectToTargetSqlMITaskProperties"/>, <see cref="ConnectToTargetSqlMISyncTaskProperties"/>, <see cref="ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskProperties"/>, <see cref="ConnectToTargetSqlDBTaskProperties"/>, <see cref="ConnectToTargetSqlDBSyncTaskProperties"/>, <see cref="GetTdeCertificatesSqlTaskProperties"/>, <see cref="GetUserTablesSqlSyncTaskProperties"/>, <see cref="GetUserTablesSqlTaskProperties"/>, <see cref="GetUserTablesMySqlTaskProperties"/>, <see cref="GetUserTablesOracleTaskProperties"/>, <see cref="GetUserTablesPostgreSqlTaskProperties"/>, <see cref="MigrateMongoDBTaskProperties"/>, <see cref="MigrateMySqlAzureDBForMySqlOfflineTaskProperties"/>, <see cref="MigrateMySqlAzureDBForMySqlSyncTaskProperties"/>, <see cref="MigrateOracleAzureDBForPostgreSqlSyncTaskProperties"/>, <see cref="MigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties"/>, <see cref="MigrateSqlServerSqlDBSyncTaskProperties"/>, <see cref="MigrateSqlServerSqlMITaskProperties"/>, <see cref="MigrateSqlServerSqlMISyncTaskProperties"/>, <see cref="MigrateSqlServerSqlDBTaskProperties"/>, <see cref="MigrateSsisTaskProperties"/>, <see cref="MigrateSchemaSqlServerSqlDBTaskProperties"/>, <see cref="CheckOciDriverTaskProperties"/>, <see cref="InstallOciDriverTaskProperties"/>, <see cref="UploadOciDriverTaskProperties"/>, <see cref="ValidateMongoDBTaskProperties"/>, <see cref="ValidateOracleAzureDBForPostgreSqlSyncTaskProperties"/>, <see cref="ValidateMigrationInputSqlServerSqlMITaskProperties"/>, <see cref="ValidateMigrationInputSqlServerSqlMISyncTaskProperties"/> and <see cref="ValidateMigrationInputSqlServerSqlDBSyncTaskProperties"/>.
        /// </summary>
        public ProjectTaskProperties Properties { get; set; }
    }
}
