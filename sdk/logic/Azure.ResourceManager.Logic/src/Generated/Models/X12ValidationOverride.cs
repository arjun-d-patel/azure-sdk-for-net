// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The X12 validation override settings. </summary>
    public partial class X12ValidationOverride
    {
        /// <summary> Initializes a new instance of <see cref="X12ValidationOverride"/>. </summary>
        /// <param name="messageId"> The message id on which the validation settings has to be applied. </param>
        /// <param name="validateEdiTypes"> The value indicating whether to validate EDI types. </param>
        /// <param name="validateXsdTypes"> The value indicating whether to validate XSD types. </param>
        /// <param name="allowLeadingAndTrailingSpacesAndZeroes"> The value indicating whether to allow leading and trailing spaces and zeroes. </param>
        /// <param name="validateCharacterSet"> The value indicating whether to validate character Set. </param>
        /// <param name="trimLeadingAndTrailingSpacesAndZeroes"> The value indicating whether to trim leading and trailing spaces and zeroes. </param>
        /// <param name="trailingSeparatorPolicy"> The trailing separator policy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="messageId"/> is null. </exception>
        public X12ValidationOverride(string messageId, bool validateEdiTypes, bool validateXsdTypes, bool allowLeadingAndTrailingSpacesAndZeroes, bool validateCharacterSet, bool trimLeadingAndTrailingSpacesAndZeroes, TrailingSeparatorPolicy trailingSeparatorPolicy)
        {
            Argument.AssertNotNull(messageId, nameof(messageId));

            MessageId = messageId;
            ValidateEdiTypes = validateEdiTypes;
            ValidateXsdTypes = validateXsdTypes;
            AllowLeadingAndTrailingSpacesAndZeroes = allowLeadingAndTrailingSpacesAndZeroes;
            ValidateCharacterSet = validateCharacterSet;
            TrimLeadingAndTrailingSpacesAndZeroes = trimLeadingAndTrailingSpacesAndZeroes;
            TrailingSeparatorPolicy = trailingSeparatorPolicy;
        }

        /// <summary> The message id on which the validation settings has to be applied. </summary>
        public string MessageId { get; set; }
        /// <summary> The value indicating whether to validate EDI types. </summary>
        public bool ValidateEdiTypes { get; set; }
        /// <summary> The value indicating whether to validate XSD types. </summary>
        public bool ValidateXsdTypes { get; set; }
        /// <summary> The value indicating whether to allow leading and trailing spaces and zeroes. </summary>
        public bool AllowLeadingAndTrailingSpacesAndZeroes { get; set; }
        /// <summary> The value indicating whether to validate character Set. </summary>
        public bool ValidateCharacterSet { get; set; }
        /// <summary> The value indicating whether to trim leading and trailing spaces and zeroes. </summary>
        public bool TrimLeadingAndTrailingSpacesAndZeroes { get; set; }
        /// <summary> The trailing separator policy. </summary>
        public TrailingSeparatorPolicy TrailingSeparatorPolicy { get; set; }
    }
}
