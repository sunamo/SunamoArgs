namespace SunamoArgs;

/// <summary>
///     Mus� b�t v SunamoArgs proto�e je sd�lena ve SunamoReflection i SunamoCollectionWithoutDuplicates
/// </summary>
public class DumpAsStringHeaderArgs
{
    public static DumpAsStringHeaderArgs Default { get; set; } = new();

    public DateTime Test_ToDelete()
    {
        return Test_ToDelete_Inner();
    }

    private DateTime Test_ToDelete_Inner()
    {

        return DateTime.Today;
    }

    /// <summary>
    ///     Only names of properties to get
    ///     If starting with ! => surely delete
    /// </summary>
    public List<string> OnlyNames { get; set; } = new();
}