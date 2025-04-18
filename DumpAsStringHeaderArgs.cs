namespace SunamoArgs;

/// <summary>
///     Mus� b�t v SunamoArgs proto�e je sd�lena ve SunamoReflection i SunamoCollectionWithoutDuplicates
/// </summary>
public class DumpAsStringHeaderArgs
{
    public static DumpAsStringHeaderArgs Default { get; set; } = new();

    /// <summary>
    ///     Only names of properties to get
    ///     If starting with ! => surely delete
    /// </summary>
    public List<string> OnlyNames { get; set; } = new();
}