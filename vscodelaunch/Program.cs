using System;
using System.Diagnostics;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        // Specify the path to Visual Studio Code executable
        string vsCodePath = @"C:\Users\user\AppData\Local\Programs\Microsoft VS Code\code.exe";
        //"C:\Users\user\AppData\Local\Programs\Microsoft VS Code\Code.exe"

        if (File.Exists(vsCodePath))
        {
            // Start the process
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = vsCodePath,
                UseShellExecute = true
            };

            Process.Start(startInfo);
        }
        else
        {
            Console.WriteLine("Visual Studio Code not found at the specified path.");
        }
    }
}
