
namespace SunamoArgs;

namespace
#if SunamoCollectionsValuesTableGrid
SunamoCollectionsValuesTableGrid
#else
    SunamoArgs
#endif
;


public class RemoveStartingWithArgs
{
    /// <summary>
    /// Original
    /// </summary>
    public bool _trimBeforeFinding = false;
    public bool caseSensitive = true;
}