using System.Diagnostics;

namespace Restarter;

public static class Program
{
    public static void Main(string[] args)
    {
        if (args.Contains("--townofhost_fun"))
        {
            Logger.Run("Searching Among Us.exe...");
            var directoryPath = AppContext.BaseDirectory;
            DirectoryInfo dir = new DirectoryInfo(directoryPath);
            string gameDir = dir.Parent?.Parent?.Parent?.FullName ?? "";
            if (string.IsNullOrEmpty(gameDir))
            {
                Logger.Err("Among Us.exe not found.");
                WaitAndExit();
                return;
            }
            string amongUsExePath = Path.Combine(gameDir, "Among Us.exe");
            if (!File.Exists(amongUsExePath))
            {
                Logger.Err("Among Us.exe not found.");
                WaitAndExit();
                return;
            }
            Logger.Ok("Done!");

            Logger.Run("Waiting for old process to exit...");
            Thread.Sleep(2000);
            Logger.Ok("Done!");

            Logger.Run("Among Us.exe starting...");
            Process.Start(amongUsExePath);
            Logger.Ok("Done!");

        }
        else
        {
            Logger.Info("このプログラムは手動で起動するものではありません。");
            Console.WriteLine();
            Logger.Info("This program should not be launched manually.");
            WaitAndExit();
        }

    }

    private static void WaitAndExit()
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Press any key to exit...");
        Console.ForegroundColor = ConsoleColor.White;
        Console.ReadKey();
    }
}