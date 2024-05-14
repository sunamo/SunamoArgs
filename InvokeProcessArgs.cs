namespace
#if SunamoShared
SunamoShared
#elif SunamoPS
SunamoPS
#elif SunamoInterfaces
SunamoInterfaces
#else
SunamoArgs
#endif
;

public class InvokeProcessArgs
{
    public string workingDir = null;
}
