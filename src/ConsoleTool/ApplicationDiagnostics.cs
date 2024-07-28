using System.Diagnostics;

public class ApplicationDiagnostics
{
    public const string ActivitySourceName = "Console.Tool.Diagnosticts";

    public static readonly ActivitySource ActivitySource = new(ActivitySourceName);
}
