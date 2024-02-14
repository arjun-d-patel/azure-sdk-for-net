// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;

namespace OpenAI;

/// <summary> Ratings for the intensity and risk level of harmful content. </summary>
public readonly partial struct ContentFilterSeverity : IEquatable<ContentFilterSeverity>
{
    private readonly string _value;

    /// <summary> Initializes a new instance of <see cref="ContentFilterSeverity"/>. </summary>
    /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
    public ContentFilterSeverity(string value)
    {
        _value = value ?? throw new ArgumentNullException(nameof(value));
    }

    private const string SafeValue = "safe";
    private const string LowValue = "low";
    private const string MediumValue = "medium";
    private const string HighValue = "high";

    /// <summary>
    /// Content may be related to violence, self-harm, sexual, or hate categories but the terms
    /// are used in general, journalistic, scientific, medical, and similar professional contexts,
    /// which are appropriate for most audiences.
    /// </summary>
    public static ContentFilterSeverity Safe { get; } = new ContentFilterSeverity(SafeValue);
    /// <summary>
    /// Content that expresses prejudiced, judgmental, or opinionated views, includes offensive
    /// use of language, stereotyping, use cases exploring a fictional world (for example, gaming,
    /// literature) and depictions at low intensity.
    /// </summary>
    public static ContentFilterSeverity Low { get; } = new ContentFilterSeverity(LowValue);
    /// <summary>
    /// Content that uses offensive, insulting, mocking, intimidating, or demeaning language
    /// towards specific identity groups, includes depictions of seeking and executing harmful
    /// instructions, fantasies, glorification, promotion of harm at medium intensity.
    /// </summary>
    public static ContentFilterSeverity Medium { get; } = new ContentFilterSeverity(MediumValue);
    /// <summary>
    /// Content that displays explicit and severe harmful instructions, actions,
    /// damage, or abuse; includes endorsement, glorification, or promotion of severe
    /// harmful acts, extreme or illegal forms of harm, radicalization, or non-consensual
    /// power exchange or abuse.
    /// </summary>
    public static ContentFilterSeverity High { get; } = new ContentFilterSeverity(HighValue);
    /// <summary> Determines if two <see cref="ContentFilterSeverity"/> values are the same. </summary>
    public static bool operator ==(ContentFilterSeverity left, ContentFilterSeverity right) => left.Equals(right);
    /// <summary> Determines if two <see cref="ContentFilterSeverity"/> values are not the same. </summary>
    public static bool operator !=(ContentFilterSeverity left, ContentFilterSeverity right) => !left.Equals(right);
    /// <summary> Converts a string to a <see cref="ContentFilterSeverity"/>. </summary>
    public static implicit operator ContentFilterSeverity(string value) => new ContentFilterSeverity(value);

    /// <inheritdoc />
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object? obj) => obj is ContentFilterSeverity other && Equals(other);
    /// <inheritdoc />
    public bool Equals(ContentFilterSeverity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

    /// <inheritdoc />
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => _value?.GetHashCode() ?? 0;
    /// <inheritdoc />
    public override string ToString() => _value;
}
