namespace SunamoArgs;

public class DumpAsStringHeaderArgs
{
    public static DumpAsStringHeaderArgs Default { get; set; } = new();

    public List<string> OnlyNames { get; set; } = new();
}
