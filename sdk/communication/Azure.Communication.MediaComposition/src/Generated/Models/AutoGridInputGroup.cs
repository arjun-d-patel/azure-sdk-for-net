// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Communication.MediaComposition.Models;
using Azure.Core;

namespace Azure.Communication.MediaComposition
{
    /// <summary> The AutoGridInputGroup. </summary>
    public partial class AutoGridInputGroup : InputGroup
    {
        /// <summary> Initializes a new instance of <see cref="AutoGridInputGroup"/>. </summary>
        /// <param name="inputIds"> Input and input group ids to be included in this input group. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inputIds"/> is null. </exception>
        public AutoGridInputGroup(IEnumerable<string> inputIds)
        {
            Argument.AssertNotNull(inputIds, nameof(inputIds));

            InputIds = inputIds.ToList();
            Kind = InputGroupType.AutoGridBased;
        }

        /// <summary> Initializes a new instance of <see cref="AutoGridInputGroup"/>. </summary>
        /// <param name="kind"> Kind of input group. </param>
        /// <param name="position"> The (x,y) position on scene or input group. </param>
        /// <param name="width"> The width of the input group container. Can be defined as pixels or percentage. </param>
        /// <param name="height"> The height of the input group container. Can be defined as pixels or percentage. </param>
        /// <param name="layer"> The layer this input group should appear on. </param>
        /// <param name="scalingMode"> The scaling mode for the view of a video stream in a cell. </param>
        /// <param name="inputIds"> Input and input group ids to be included in this input group. </param>
        internal AutoGridInputGroup(InputGroupType kind, InputPosition position, string width, string height, string layer, ScalingMode? scalingMode, IList<string> inputIds) : base(kind, position, width, height, layer, scalingMode)
        {
            InputIds = inputIds;
            Kind = kind;
        }

        /// <summary> Input and input group ids to be included in this input group. </summary>
        public IList<string> InputIds { get; }
    }
}
