static class LogLine
{
    public static string Message(string logLine)
    {
        int endIndex = logLine.IndexOf(":");
        string finalMessage = logLine.Remove(0, endIndex+1).Trim();
        return finalMessage;
    }

    public static string LogLevel(string logLine)
    {
        string currentWord = logLine.Trim();

        switch (currentWord[1])
        {
            case 'I':
                return "info";
            case 'E':
                return "error";
            case 'W':
                return "warning";
            default:
                return "";
        }
    }

    public static string Reformat(string logLine)
    {
        string message = Message(logLine);
        string level = LogLevel(logLine);

        return $"{message} ({level})";

    }
}


