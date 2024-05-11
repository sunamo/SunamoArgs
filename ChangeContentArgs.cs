

namespace
#if SunamoDevCode
SunamoDevCode
#elif SunamoCollectionsChangeContent
    SunamoCollectionsChangeContent
#else
SunamoArgs
#endif
;

public class ChangeContentArgs
{
    public bool removeNull = false;
    public bool removeEmpty = false;
    public bool switchFirstAndSecondArg = false;
}
