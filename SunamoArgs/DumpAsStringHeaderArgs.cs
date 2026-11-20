namespace SunamoArgs;

/// <summary>
/// Represents the dump as string header args type.
/// </summary>
public class DumpAsStringHeaderArgs
{
    /// <summary>
    /// Gets or sets the default.
    /// </summary>
    public static DumpAsStringHeaderArgs Default { get; set; } = new();

    /// <summary>
    /// Gets or sets the only names.
    /// </summary>
    public List<string> OnlyNames { get; set; } = new();
}
