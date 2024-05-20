namespace
#if SunamoShared
SunamoShared
#elif SunamoFileSystem
SunamoFileSystem
#elif SunamoGetFiles
SunamoGetFiles
#else
SunamoArgs
#endif
;
public class GetFilesMoreMascArgs : GetFilesBaseArgs
{
    public bool LoadFromFileWhenDebug = false;
    public string path;
    public string masc = "*";
    public SearchOption searchOption = SearchOption.TopDirectoryOnly;
    public bool deleteFromDriveWhenCannotBeResolved = false;
}