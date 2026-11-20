namespace SunamoArgs;

public class MSColumnDBArgs
{
    public string name = null!;
    public bool canBeNull;
    public bool identityIncrementBy1;
    public bool mustBeUnique;
    public bool primaryKey;
    public string? referencesColumn;
    public string? referencesTable;
    public Signed signed;
}
