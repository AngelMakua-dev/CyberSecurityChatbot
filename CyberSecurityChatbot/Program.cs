using System;

class Program
{
    static void Main()
    {
        Console.Title = "Cybersecurity Awareness Bot";
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Play voice greeting
        AudioPlayer.PlayGreeting();

        // Show ASCII logo
        UIHelper.ShowLogo();

        // Start chatbot
        Chatbot bot = new Chatbot();
        bot.Start();

       
    }
}