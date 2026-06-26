using System;

public class QuizManager
{
    // Handles cybersecurity quiz logic
    public class QuizManager
    {
        public string[] Questions { get; } =
        {
            "What is phishing?",
            "What makes a strong password?",
            "What should you do with suspicious emails?",
            "What is 2FA?",
            "What is a firewall?",
            "What is malware?",
            "What is social engineering?",
            "What does HTTPS mean?",
            "Why update software?",
            "What is a VPN?"
        };

        public string[][] Options { get; } =
        {
            new string[] { "Fishing online", "Fake messages to steal data", "Virus", "Hacking tool" },
            new string[] { "123456", "Your name", "Mix of letters, numbers, symbols", "Birth year" },
            new string[] { "Open them", "Ignore them", "Report/delete them", "Forward them" },
            new string[] { "Two fake accounts", "Two-factor authentication", "Firewall", "Password type" },
            new string[] { "Wall fire", "Network protection system", "Antivirus", "Browser" },
            new string[] { "Safe software", "Malicious software", "Game", "Update" },
            new string[] { "Hardware attack", "Tricking people", "WiFi issue", "Email type" },
            new string[] { "Secure website connection", "Hacking tool", "Browser", "Password system" },
            new string[] { "Faster internet", "Security fixes", "More storage", "New design" },
            new string[] { "Virtual Private Network", "Virus Protection Node", "Very Private Network", "Visual Program Network" }
        };

        public int[] Answers { get; } =
        {
            1, 2, 2, 1, 1, 1, 1, 0, 1, 0
        };
    }
}
