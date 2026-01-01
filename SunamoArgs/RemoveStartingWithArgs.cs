namespace SunamoArgs;

/// <summary>
/// Arguments for remove starting with operations.
/// </summary>
public class RemoveStartingWithArgs
{
    /// <summary>
    /// Gets or sets a value indicating whether to trim whitespace before finding the starting pattern.
    /// </summary>
    public bool TrimBeforeFinding { get; set; } = false;

    /// <summary>
    /// Gets or sets a value indicating whether the search is case sensitive.
    /// </summary>
    public bool CaseSensitive { get; set; } = true;
}