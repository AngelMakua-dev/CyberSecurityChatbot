using System;

public class Chatbot
{
    private string userName;
    private bool isRunning = true;

    public void Start()
    {
        Console.Write("Hello! I'm your Cybersecurity Awareness Assistant.\nPlease enter your name: ");
        userName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(userName))
        {
            userName = "User";
        }

        UIHelper.TypeText($"Nice to meet you, {userName}!");
        UIHelper.ShowSuccess("Welcome to cybersecurity awareness training!");
        ShowMainMenu();
    }

    private void ShowMainMenu()
    {
        while (isRunning)
        {
            Console.WriteLine($"\nWelcome back, {userName}!");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Ask about Phishing");
            Console.WriteLine("2. Ask about Password Safety");
            Console.WriteLine("3. Ask about Safe Browsing");
            Console.WriteLine("4. General Questions (How are you? etc.)");
            Console.WriteLine("5. Exit");
            Console.Write("\nYour choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AskAboutPhishing();
                    break;
                case "2":
                    AskAboutPasswordSafety();
                    break;
                case "3":
                    AskAboutSafeBrowsing();
                    break;
                case "4":
                    GeneralQuestions();
                    break;
                case "5":
                    UIHelper.TypeText("Goodbye! Stay safe online! 👋");
                    isRunning = false;
                    return;
                default:
                    UIHelper.ShowError("Invalid choice. Please enter 1-5.");
                    break;
            }
        }
    }

    private void AskAboutPhishing()
    {
        UIHelper.ClearScreen();
        Console.WriteLine("\n--- PHISHING INFORMATION ---");
        UIHelper.TypeText("Phishing is when scammers trick you into giving personal info.");
        UIHelper.TypeText("Signs of phishing:");
        UIHelper.TypeText("- Suspicious email addresses");
        UIHelper.TypeText("- Urgent or threatening language");
        UIHelper.TypeText("- Spelling and grammar mistakes");
        UIHelper.TypeText("- Suspicious links or attachments");
        UIHelper.ShowTip("Never click suspicious links! Always verify the sender.");
        UIHelper.TypeText("\nType 'back' to return to main menu.");

        while (true)
        {
            string input = Console.ReadLine()?.ToLower();
            if (input == "back")
                break;
            UIHelper.TypeText("Type 'back' to return to the main menu.");
        }
    }

    private void AskAboutPasswordSafety()
    {
        UIHelper.ClearScreen();
        Console.WriteLine("\n--- PASSWORD SAFETY ---");
        UIHelper.TypeText("Password safety is safety practices of creating and managing passwords in a secure way to prevent unauthorized access to personal accounts and information.");
        UIHelper.TypeText("Strong passwords should have:");
        UIHelper.TypeText("- At least 12 characters");
        UIHelper.TypeText("- Uppercase and lowercase letters");
        UIHelper.TypeText("- Numbers");
        UIHelper.TypeText("- Special symbols (!@#$%^&*)");
        UIHelper.ShowTip("Never share your passwords! Use a password manager.");
        UIHelper.TypeText("\nType 'back' to return to main menu.");

        while (true)
        {
            string input = Console.ReadLine()?.ToLower();
            if (input == "back")
                break;
            UIHelper.TypeText("Type 'back' to return to the main menu.");
        }
    }

    private void AskAboutSafeBrowsing()
    {
        UIHelper.ClearScreen();
        Console.WriteLine("\n--- SAFE BROWSING ---");
        UIHelper.TypeText("Safe browsing is the practice of using the internet in a secure manner to protect personal information and prevent exposure to online threats.");
        UIHelper.TypeText("Tips for safe browsing:");
        UIHelper.TypeText("- Always check URLs before clicking");
        UIHelper.TypeText("- Look for 'https://' and padlock icon");
        UIHelper.TypeText("- Avoid downloading from untrusted sites");
        UIHelper.TypeText("- Don't enter personal info on suspicious websites");
        UIHelper.ShowTip("Keep your browser updated!");
        UIHelper.TypeText("\nType 'back' to return to main menu.");

        while (true)
        {
            string input = Console.ReadLine()?.ToLower();
            if (input == "back")
                break;
            UIHelper.TypeText("Type 'back' to return to the main menu.");
        }
    }

    private void GeneralQuestions()
    {
        UIHelper.ClearScreen();
        Console.WriteLine("\n--- GENERAL QUESTIONS ---");
        UIHelper.TypeText("You can ask me things like:");
        UIHelper.TypeText("- How are you?");
        UIHelper.TypeText("- What is your purpose?");
        UIHelper.TypeText("- What can I ask you about?");
        UIHelper.TypeText("- Who created you?");
        UIHelper.TypeText("- Why is cybersecurity important?");
        UIHelper.TypeText("- Hello");
        UIHelper.TypeText("- Help");
        UIHelper.TypeText("\n(Type 'back' at any time to return to the main menu)");

        while (true)
        {
            Console.Write($"\n{userName}, what would you like to ask? ");
            string question = Console.ReadLine()?.ToLower();

            if (question == "back")
                break;

            RespondToGeneralQuestion(question);
        }
    }

    private void RespondToGeneralQuestion(string question)
    {
        if (string.IsNullOrWhiteSpace(question))
        {
            UIHelper.ShowError("Please type a question.");
        }
        else if (question.Contains("how are you"))
        {
            UIHelper.TypeText($"I'm just a program, {userName}, but I'm here to help you stay safe online! 😊");
        }
        else if (question.Contains("purpose"))
        {
            UIHelper.TypeText("My purpose is to help you understand cybersecurity and stay safe online.");
        }
        else if (question.Contains("what can i ask"))
        {
            UIHelper.TypeText("You can ask me about phishing, password safety, safe browsing, or general questions like 'How are you?' or 'What is your purpose?'");
        }
        else if (question.Contains("who created you"))
        {
            UIHelper.TypeText("I was created as a cybersecurity awareness assistant to help educate people about online safety.");
        }
        else if (question.Contains("why is cybersecurity important"))
        {
            UIHelper.TypeText("Cybersecurity is important because it protects our personal information, financial data, and privacy from hackers and scammers.");
        }
        else if (question.Contains("hello") || question.Contains("hi"))
        {
            UIHelper.TypeText($"Hello {userName}! 👋 How can I help you today?");
        }
        else if (question.Contains("help"))
        {
            UIHelper.TypeText("You can ask me about:\n- Phishing\n- Password Safety\n- Safe Browsing\n- General questions like 'How are you?' or 'What is your purpose?'");
        }
        else
        {
            UIHelper.TypeText("I didn't quite understand that. Try asking me something like 'How are you?' or 'What is your purpose?'");
        }
    }
}