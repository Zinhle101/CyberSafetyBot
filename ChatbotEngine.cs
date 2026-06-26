using System;
using System.Collections.Generic;

namespace CyberSafetyBot
{
    // Handles all chatbot responses, memory and tone
    public class ChatbotEngine
    {
        // Stores topics discussed during the session
        private List<string> memory = new List<string>();

        // Used to randomise responses
        private Random random = new Random();

        // Stores the logged in user's name
        public string UserName { get; set; } = "";

        // Stores the selected chatbot tone
        public string Tone { get; set; } = "Friendly";

        // Main chatbot method
        public string GetResponse(string input)
        {
            input = input.ToLower().Trim();

            // Greetings
            if (input.Contains("hello") || input.Contains("hi") || input.Contains("hey"))
            {
                return RandomResponse(new string[]
                {
                    $"Hello {UserName}! I'm Chatty. How can I help you today?",
                    $"Hi {UserName}! I'm Chatty. Ask me anything about cybersecurity.",
                    $"Hey {UserName}! How can I help you stay safe online today?"
                });
            }

            // Passwords
            if (input.Contains("password"))
            {
                Remember("Passwords");

                return RandomResponse(new string[]
                {
                    "Use a strong password with uppercase letters, lowercase letters, numbers and symbols.",
                    "Avoid using your birthday or name in your password.",
                    "Use a different password for every account."
                });
            }

            // Phishing
            if (input.Contains("phishing"))
            {
                Remember("Phishing");

                return RandomResponse(new string[]
                {
                    "Phishing is a scam where criminals pretend to be trusted organisations to steal your information.",
                    "Never click suspicious email links or attachments.",
                    "Always verify who sent an email before entering personal information."
                });
            }

            // Malware
            if (input.Contains("malware") || input.Contains("virus"))
            {
                Remember("Malware");

                return RandomResponse(new string[]
                {
                    "Malware is software designed to damage or steal information.",
                    "Install antivirus software and keep it updated.",
                    "Avoid downloading files from unknown websites."
                });
            }

            // Ransomware
            if (input.Contains("ransomware"))
            {
                Remember("Ransomware");

                return RandomResponse(new string[]
                {
                    "Ransomware locks or encrypts your files until money is paid.",
                    "Regular backups help protect you from ransomware.",
                    "Never open suspicious attachments."
                });
            }

            // VPN
            if (input.Contains("vpn"))
            {
                Remember("VPN");

                return RandomResponse(new string[]
                {
                    "A VPN encrypts your internet connection.",
                    "VPN stands for Virtual Private Network.",
                    "A VPN is useful when using public Wi-Fi."
                });
            }

            // Firewall
            if (input.Contains("firewall"))
            {
                Remember("Firewall");

                return RandomResponse(new string[]
                {
                    "A firewall blocks unwanted network traffic.",
                    "Always leave your firewall enabled.",
                    "Firewalls help protect your device from hackers."
                });
            }

            // Antivirus
            if (input.Contains("antivirus"))
            {
                Remember("Antivirus");

                return RandomResponse(new string[]
                {
                    "Antivirus software detects and removes malware.",
                    "Keep your antivirus software updated.",
                    "Run regular antivirus scans."
                });
            }

            // Hacker
            if (input.Contains("hacker"))
            {
                Remember("Hackers");

                return RandomResponse(new string[]
                {
                    "Hackers attempt to gain unauthorized access to systems.",
                    "Strong passwords help prevent hacking.",
                    "Keep your software updated to reduce vulnerabilities."
                });
            }

            // Scam
            if (input.Contains("scam"))
            {
                Remember("Scams");

                return RandomResponse(new string[]
                {
                    "Never send money to someone you do not know.",
                    "Verify messages before responding.",
                    "Scammers often create a false sense of urgency."
                });
            }

            // Privacy
            if (input.Contains("privacy") || input.Contains("personal information"))
            {
                Remember("Privacy");

                return RandomResponse(new string[]
                {
                    "Only share personal information on trusted websites.",
                    "Review your privacy settings regularly.",
                    "Think carefully before posting personal information online."
                });
            }

            // Social engineering
            if (input.Contains("social engineering"))
            {
                Remember("Social Engineering");

                return RandomResponse(new string[]
                {
                    "Social engineering tricks people into revealing confidential information.",
                    "Never share passwords over email or messaging apps.",
                    "Always verify someone's identity before sharing sensitive information."
                });
            }

            // Public Wi-Fi
            if (input.Contains("wifi") || input.Contains("wi-fi"))
            {
                Remember("Wi-Fi");

                return RandomResponse(new string[]
                {
                    "Avoid online banking on public Wi-Fi.",
                    "Use a VPN when connected to public Wi-Fi.",
                    "Public Wi-Fi is convenient but can be risky."
                });
            }

            // 2FA
            if (input.Contains("2fa") ||
                input.Contains("two factor") ||
                input.Contains("authentication"))
            {
                Remember("2FA");

                return RandomResponse(new string[]
                {
                    "Two-factor authentication adds an extra layer of security.",
                    "Enable 2FA whenever it is available.",
                    "2FA makes it harder for attackers to access your accounts."
                });
            }

            // Encryption
            if (input.Contains("encryption"))
            {
                Remember("Encryption");

                return RandomResponse(new string[]
                {
                    "Encryption converts information into unreadable data to keep it secure.",
                    "Encryption helps protect sensitive information.",
                    "Many secure websites use encryption to protect users."
                });
            }

            // Cyberbullying
            if (input.Contains("cyberbullying"))
            {
                Remember("Cyberbullying");

                return RandomResponse(new string[]
                {
                    "Do not respond to cyberbullies.",
                    "Block and report abusive users.",
                    "Tell a trusted adult or teacher if cyberbullying occurs."
                });
            }

            // Online safety
            if (input.Contains("online safety") || input.Contains("internet"))
            {
                return RandomResponse(new string[]
                {
                    "Always think before you click.",
                    "Only visit trusted websites.",
                    "Keep your software updated."
                });
            }

            // Thanks
            if (input.Contains("thank"))
            {
                return ApplyTone("You're welcome! I'm always happy to help.");
            }

            // Goodbye
            if (input.Contains("bye"))
            {
                return ApplyTone($"Goodbye {UserName}! Stay cyber safe.");
            }

            // Unknown question
            return ApplyTone(
                "I'm not sure about that. Try asking me about passwords, phishing, malware, ransomware, VPNs, firewalls, hackers, scams, privacy, encryption or online safety.");
        }

        // Chooses a random response
        private string RandomResponse(string[] responses)
        {
            int index = random.Next(responses.Length);
            return ApplyTone(responses[index]);
        }

        // Applies the selected tone
        private string ApplyTone(string response)
        {
            switch (Tone.ToLower())
            {
                case "professional":
                    return "Professional Advice: " + response;

                case "serious":
                    return response + " Please take this advice seriously.";

                default:
                    return response;
            }
        }

        // Stores a topic in memory
        public void Remember(string topic)
        {
            if (!memory.Contains(topic))
            {
                memory.Add(topic);
            }
        }

        // Returns remembered topics
        public List<string> GetMemory()
        {
            return memory;
        }
    }
}