using UnityEngine;

public class _0x75fcf5ad : MonoBehaviour
{
    public bool IsCheckScoreEnabled;
    public bool IsSkipSplashEnabled;
    public static _0x75fcf5ad Instance;
    public bool IsLevelSelectorEnabled;
    public bool IsStoryEnabled;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0x75fcf5ad>();
            DontDestroyOnLoad(this.gameObject);
            this._0x0562d914();
        }
        else
        {
            this._0xeb6a18ab();
            Destroy(this.gameObject);
        }
    }

    private void _0xeb6a18ab()
    {
    }

    public bool IsOnlyWinGameEndEnabled;
    public bool IsBestScoreEnabled;
    public bool IsLevelIncrementOnWin;
    private void _0x0562d914()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public bool IsTutorialEnabled;
    public bool IsTimerEnabled;
}