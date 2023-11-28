// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The LinkTableRequestSource. </summary>
    public partial class LinkTableRequestSource
    {
        /// <summary> Initializes a new instance of <see cref="LinkTableRequestSource"/>. </summary>
        public LinkTableRequestSource()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LinkTableRequestSource"/>. </summary>
        /// <param name="tableName"> Source table table name. </param>
        /// <param name="schemaName"> Source table schema name. </param>
        internal LinkTableRequestSource(string tableName, string schemaName)
        {
            TableName = tableName;
            SchemaName = schemaName;
        }

        /// <summary> Source table table name. </summary>
        public string TableName { get; set; }
        /// <summary> Source table schema name. </summary>
        public string SchemaName { get; set; }
    }
}
