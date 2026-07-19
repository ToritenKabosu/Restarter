namespace Restarter;

public static class Logger
{
    public static void Ask(string msg)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("[ASK]");
        Console.ResetColor();
        Console.Write(" " + msg);
    }
    public static void Info(string msg)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("[INFO]");
        Console.ResetColor();
        Console.Write(" " + msg);
    }
    public static void Run(string msg)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("[RUN]");
        Console.ResetColor();
        Console.Write(" " + msg);
    }
    public static void RunInline(string msg)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("\r[RUN]");
        Console.ResetColor();
        Console.Write(" " + msg + "   ");
    }
    public static void Ok(string msg)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("[OK]");
        Console.ResetColor();
        Console.WriteLine("  " + msg);
    }
    public static void Err(string msg)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("[ERR]");
        Console.ResetColor();
        Console.WriteLine(" " + msg);
    }
}
