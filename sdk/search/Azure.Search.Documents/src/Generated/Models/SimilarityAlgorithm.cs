// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary>
    /// Base type for similarity algorithms. Similarity algorithms are used to calculate scores that tie queries to documents. The higher the score, the more relevant the document is to that specific query. Those scores are used to rank the search results.
    /// Please note <see cref="SimilarityAlgorithm"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="BM25Similarity"/> and <see cref="ClassicSimilarity"/>.
    /// </summary>
    public partial class SimilarityAlgorithm
    {
        /// <summary> Initializes a new instance of <see cref="SimilarityAlgorithm"/>. </summary>
        /// <param name="oDataType"></param>
        internal SimilarityAlgorithm(string oDataType)
        {
            ODataType = oDataType;
        }

        /// <summary> Gets or sets the o data type. </summary>
        internal string ODataType { get; set; }
    }
}
