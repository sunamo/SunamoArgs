namespace
#if SunamoDevCode
SunamoDevCode
#elif SunamoCollectionsChangeContent
SunamoCollectionsChangeContent
#elif SunamoGetFiles
SunamoGetFiles
#elif SunamoGitBashBuilder
SunamoGitBashBuilder
#elif SunamoWikipedia
SunamoWikipedia
#elif SunamoGetFolders
SunamoGetFolders
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