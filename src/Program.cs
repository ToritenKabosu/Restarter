/*
 * Copyright (C) 2026 ToritenKabosu
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 * See the GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.
 * If not, see <https://www.gnu.org/licenses/>.
 */

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
