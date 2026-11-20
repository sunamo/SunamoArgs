namespace SunamoArgs;

/// <summary>
/// Represents the MS column DB args type.
/// </summary>
public class MSColumnDBArgs
{
    /// <summary>
    /// The name.
    /// </summary>
    public string name = null!;
    /// <summary>
    /// The can be null.
    /// </summary>
    public bool canBeNull;
    /// <summary>
    /// The identity increment by 1.
    /// </summary>
    public bool identityIncrementBy1;
    /// <summary>
    /// The must be unique.
    /// </summary>
    public bool mustBeUnique;
    /// <summary>
    /// The primary key.
    /// </summary>
    public bool primaryKey;
    /// <summary>
    /// The references column.
    /// </summary>
    public string? referencesColumn;
    /// <summary>
    /// The references table.
    /// </summary>
    public string? referencesTable;
    /// <summary>
    /// The signed.
    /// </summary>
    public Signed signed;
}
