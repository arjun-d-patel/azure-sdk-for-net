// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> The parameters that can be provided when updating workbook properties properties. </summary>
    public partial class WorkbookPatch
    {
        /// <summary> Initializes a new instance of <see cref="WorkbookPatch"/>. </summary>
        public WorkbookPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            TagsPropertiesTags = new ChangeTrackingList<string>();
        }

        /// <summary> The kind of workbook. Only valid value is shared. </summary>
        public WorkbookUpdateSharedTypeKind? Kind { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The user-defined name (display name) of the workbook. </summary>
        public string DisplayName { get; set; }
        /// <summary> Configuration of this particular workbook. Configuration data is a string containing valid JSON. </summary>
        public string SerializedData { get; set; }
        /// <summary> Workbook category, as defined by the user at creation time. </summary>
        public string Category { get; set; }
        /// <summary> A list of 0 or more tags that are associated with this workbook definition. </summary>
        public IList<string> TagsPropertiesTags { get; }
        /// <summary> The description of the workbook. </summary>
        public string Description { get; set; }
        /// <summary> The unique revision id for this workbook definition. </summary>
        public string Revision { get; set; }
    }
}
