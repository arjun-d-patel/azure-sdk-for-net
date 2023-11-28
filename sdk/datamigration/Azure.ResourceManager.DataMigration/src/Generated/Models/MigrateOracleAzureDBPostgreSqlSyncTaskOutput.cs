// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary>
    /// Output for the task that migrates Oracle databases to Azure Database for PostgreSQL for online migrations
    /// Please note <see cref="MigrateOracleAzureDBPostgreSqlSyncTaskOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError"/>, <see cref="MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel"/>, <see cref="MigrateOracleAzureDBPostgreSqlSyncTaskOutputError"/>, <see cref="MigrateOracleAzureDBPostgreSqlSyncTaskOutputMigrationLevel"/> and <see cref="MigrateOracleAzureDBPostgreSqlSyncTaskOutputTableLevel"/>.
    /// </summary>
    public abstract partial class MigrateOracleAzureDBPostgreSqlSyncTaskOutput
    {
        /// <summary> Initializes a new instance of <see cref="MigrateOracleAzureDBPostgreSqlSyncTaskOutput"/>. </summary>
        protected MigrateOracleAzureDBPostgreSqlSyncTaskOutput()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MigrateOracleAzureDBPostgreSqlSyncTaskOutput"/>. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Result type. </param>
        internal MigrateOracleAzureDBPostgreSqlSyncTaskOutput(string id, string resultType)
        {
            Id = id;
            ResultType = resultType;
        }

        /// <summary> Result identifier. </summary>
        public string Id { get; }
        /// <summary> Result type. </summary>
        internal string ResultType { get; set; }
    }
}
