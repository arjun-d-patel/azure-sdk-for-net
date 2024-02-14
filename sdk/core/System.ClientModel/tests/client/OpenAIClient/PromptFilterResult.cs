// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace OpenAI;

/// <summary> Content filtering results for a single prompt in the request. </summary>
public partial class PromptFilterResult
{
    /// <summary> Initializes a new instance of PromptFilterResult. </summary>
    /// <param name="promptIndex"> The index of this prompt in the set of prompt results. </param>
    internal PromptFilterResult(int promptIndex)
    {
        PromptIndex = promptIndex;
    }

    /// <summary> Initializes a new instance of PromptFilterResult. </summary>
    /// <param name="promptIndex"> The index of this prompt in the set of prompt results. </param>
    /// <param name="contentFilterResults"> Content filtering results for this prompt. </param>
    internal PromptFilterResult(int promptIndex, ContentFilterResults? contentFilterResults)
    {
        PromptIndex = promptIndex;
        ContentFilterResults = contentFilterResults;
    }

    /// <summary> The index of this prompt in the set of prompt results. </summary>
    public int PromptIndex { get; }
    /// <summary> Content filtering results for this prompt. </summary>
    public ContentFilterResults? ContentFilterResults { get; }
}
