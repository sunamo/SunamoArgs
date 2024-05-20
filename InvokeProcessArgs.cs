namespace
#if SunamoShared
SunamoShared
#elif SunamoPS
SunamoPS
#elif SunamoInterfaces
SunamoInterfaces
#elif SunamoWinStd
SunamoWinStd
#else
SunamoArgs
#endif
;
public class InvokeProcessArgs
{
    public string workingDir = null;
}