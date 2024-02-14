// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace OpenAI;

/// <summary>
/// The representation of a single prompt completion as part of an overall completions request.
/// Generally, `n` choices are generated per provided prompt with a default value of 1.
/// Token limits and other settings may limit the number of choices generated.
/// </summary>
public partial class Choice
{
    /// <summary> Initializes a new instance of Choice. </summary>
    /// <param name="text"> The generated text for a given completions prompt. </param>
    /// <param name="index"> The ordered index associated with this completions choice. </param>
    /// <param name="logProbabilityModel"> The log probabilities model for tokens associated with this completions choice. </param>
    /// <param name="finishReason"> Reason for finishing. </param>
    /// <exception cref="ArgumentNullException"> <paramref name="text"/> is null. </exception>
    internal Choice(string text, int index, CompletionsLogProbabilityModel? logProbabilityModel, CompletionsFinishReason? finishReason)
    {
        if (text is null) throw new ArgumentNullException(nameof(text));

        Text = text;
        Index = index;
        LogProbabilityModel = logProbabilityModel;
        FinishReason = finishReason;
    }

    /// <summary> Initializes a new instance of Choice. </summary>
    /// <param name="text"> The generated text for a given completions prompt. </param>
    /// <param name="index"> The ordered index associated with this completions choice. </param>
    /// <param name="contentFilterResults">
    /// Information about the content filtering category (hate, sexual, violence, self_harm), if it
    /// has been detected, as well as the severity level (very_low, low, medium, high-scale that
    /// determines the intensity and risk level of harmful content) and if it has been filtered or not.
    /// </param>
    /// <param name="logProbabilityModel"> The log probabilities model for tokens associated with this completions choice. </param>
    /// <param name="finishReason"> Reason for finishing. </param>
    internal Choice(string text, int index, ContentFilterResults? contentFilterResults, CompletionsLogProbabilityModel? logProbabilityModel, CompletionsFinishReason? finishReason)
    {
        Text = text;
        Index = index;
        ContentFilterResults = contentFilterResults;
        LogProbabilityModel = logProbabilityModel;
        FinishReason = finishReason;
    }

    /// <summary> The generated text for a given completions prompt. </summary>
    public string Text { get; }
    /// <summary> The ordered index associated with this completions choice. </summary>
    public int Index { get; }
    /// <summary>
    /// Information about the content filtering category (hate, sexual, violence, self_harm), if it
    /// has been detected, as well as the severity level (very_low, low, medium, high-scale that
    /// determines the intensity and risk level of harmful content) and if it has been filtered or not.
    /// </summary>
    public ContentFilterResults? ContentFilterResults { get; }
    /// <summary> The log probabilities model for tokens associated with this completions choice. </summary>
    public CompletionsLogProbabilityModel? LogProbabilityModel { get; }
    /// <summary> Reason for finishing. </summary>
    public CompletionsFinishReason? FinishReason { get; }
}
