using System;
using System.Threading;

public static class UIHelper
{
    public static void ShowLogo()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=====================================");
        Console.WriteLine("  CYBERSECURITY AWARENESS CHATBOT");
        Console.WriteLine("=====================================");
        Console.WriteLine("   Your guide to staying safe");
        Console.WriteLine("      in the digital world");
        Console.ResetColor();
        Console.WriteLine();
    }

    public static void TypeText(string message)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(20); // typing effect - adjust speed here (lower = faster, higher = slower)
        }
        Console.WriteLine();
    }

    public static void TypeTextSlow(string message)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(50); // slower typing effect for emphasis
        }
        Console.WriteLine();
    }

    public static void TypeTextFast(string message)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(10); // faster typing effect
        }
        Console.WriteLine();
    }

    public static void ShowError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        TypeText($"⚠️ {message}");
        Console.ResetColor();
    }

    public static void ShowSuccess(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        TypeText($"✓ {message}");
        Console.ResetColor();
    }

    public static void ShowTip(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        TypeText($"🔒 {message}");
        Console.ResetColor();
    }

    public static void ClearScreen()
    {
        Console.Clear();
        ShowLogo();
    }
}