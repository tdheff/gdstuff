using System;
using Godot;

public sealed class Logger
{
    [Flags]
    public enum LogLevel { NONE = 0, ERROR = 1, WARN = 2, INFO = 4, DEBUG = 8, ALL = 16 };

    private LogLevel logLevel = LogLevel.ALL;

    private static readonly Lazy<Logger> logger =
        new Lazy<Logger>(() => new Logger());

    public static Logger Instance { get { return logger.Value; } }

    private bool IsLevelActive(LogLevel level)
    {
        if ((logLevel & LogLevel.ALL) != LogLevel.NONE)
        {
            return true;
        }
        else if ((logLevel & level) != LogLevel.NONE)
        {
            return true;
        }
        return false;
    }

    private Logger()
    {
    }

    private static string LevelToString(LogLevel level)
    {
        switch (level)
        {
            case LogLevel.ERROR:
                return "ERR";
            case LogLevel.INFO:
                return "INF";
            case LogLevel.WARN:
                return "WRN";
            case LogLevel.DEBUG:
                return "DBG";
            default:
                return "LOG";
        }
    }

    public static void Log(LogLevel level, object what)
    {
        if (Instance.IsLevelActive(level))
        {
            string levelString = LevelToString(level);
            string timeStamp = string.Format("{0:HH:mm:ss:fff}", DateTime.Now);
            string output = $"[{timeStamp} {levelString}] {what}";
            GD.Print(output);
        }
    }

    public static void Error(object what)
    {
        Log(LogLevel.ERROR, what);
    }

    public static void Info(object what)
    {
        Log(LogLevel.INFO, what);
    }

    public static void Warn(object what)
    {
        Log(LogLevel.WARN, what);
    }

    public static void Debug(object what)
    {
        Log(LogLevel.DEBUG, what);
    }
}