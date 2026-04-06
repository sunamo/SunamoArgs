namespace SunamoArgs;

/// <summary>
/// Arguments for dumping objects as string with header formatting.
/// Shared across SunamoReflection and SunamoCollectionWithoutDuplicates.
/// </summary>
public class DumpAsStringHeaderArgs
{
    /// <summary>
    /// Gets or sets the default instance of <see cref="DumpAsStringHeaderArgs"/>.
    /// </summary>
    public static DumpAsStringHeaderArgs Default { get; set; } = new();

    /// <summary>
    /// Gets or sets the list of property names to include in the output.
    /// If a name starts with '!' it will be excluded.
    /// </summary>
    public List<string> OnlyNames { get; set; } = new();
}