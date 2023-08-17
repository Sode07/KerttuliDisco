using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Define the path to the startup script
        string startupScript = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                                           @"Microsoft\Windows\Start Menu\Programs\Startup\startup_script.bat");

        // Generate the startup script and the VBScript
        using (StreamWriter writer = new StreamWriter(startupScript))
        {
            writer.WriteLine("@echo off");
            writer.WriteLine(":: Define the path to the VBScript file");
            writer.WriteLine("set \"vbs_script=%%temp%%\\fullscreen.vbs\"");
            writer.WriteLine(":: Generate and execute the VBScript");
            writer.WriteLine("(echo Set objShell = CreateObject^(\"WScript.Shell\"^)");
            writer.WriteLine("echo objShell.AppActivate \"Command Prompt\"");
            writer.WriteLine("echo WScript.Sleep 500");
            writer.WriteLine("echo objShell.SendKeys \"^%%^{F11}^%%\"");
            writer.WriteLine(") > \"%%vbs_script%%\"");
            writer.WriteLine(":: Run the VBScript");
            writer.WriteLine("wscript \"%%vbs_script%%\"");
            writer.WriteLine(":: Clean up the temporary VBScript");
            writer.WriteLine("del \"%%vbs_script%%\"");
            writer.WriteLine(":A");
            writer.WriteLine("color f1");
            writer.WriteLine("color 12");
            writer.WriteLine("color 23");
            writer.WriteLine("color 34");
            writer.WriteLine("color 45");
            writer.WriteLine("color 56");
            writer.WriteLine("color 67");
            writer.WriteLine("color 78");
            writer.WriteLine("color 89");
            writer.WriteLine("color 9a");
            writer.WriteLine("color ab");
            writer.WriteLine("color bc");
            writer.WriteLine("color cd");
            writer.WriteLine("color de");
            writer.WriteLine("color ef");
            writer.WriteLine("goto :A");
        }

        // Display a message
        Console.WriteLine("Startup script has been generated in the startup folder.");
        Console.WriteLine("Press any key to exit...");
    }
}
