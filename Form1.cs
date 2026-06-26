using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CyberSafetyBot
{
    public partial class Form1 : Form
    {

        // Logs in the user and remembers them for this session
        private void LoginUser()
        {
            string name = txtInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter your name.");
                return;
            }

            currentUser = name;

            if (users.ContainsKey(name))
            {
                rtbOutput.AppendText($"Bot: Welcome back, {name}!" + Environment.NewLine + Environment.NewLine);
            }
            else
            {
                users.Add(name, true);
                rtbOutput.AppendText($"Bot: Welcome, {name}! Nice to meet you." + Environment.NewLine + Environment.NewLine);
            }

            ActivityLog.Items.Add($"{DateTime.Now:HH:mm} - {name} logged in.");

            txtInput.Clear();
        }


        // Chatbot
        private ChatbotEngine bot;

        // Quiz state
        private int score = 0;
        private int questionIndex = 0;

       
        // Stores users in memory for this session only
        private Dictionary<string, bool> users = new Dictionary<string, bool>();

        private string currentUser = "";

        // Quiz data (ONLY ONCE — do not duplicate elsewhere)
        private string[] questions =
        {
           "What is phishing?",
           "What makes a strong password?",
           "What should you do with suspicious emails?",
           "What is 2FA?",
           "What is malware?",
           "What does HTTPS mean?",
           "What is social engineering?",
           "Why should you update software?"
        };

        private string[][] options =
        {
           new string[] { "Fishing technique", "Fake messages to steal info", "Virus", "Firewall" },
           new string[] { "123456", "Your name", "Letters, numbers, symbols", "Birth year" },
           new string[] { "Open them", "Ignore security", "Report/delete them", "Forward them" },
           new string[] { "2 accounts", "Two-factor authentication", "Password type", "Firewall" },
           new string[] { "Hardware", "Malicious software", "Browser", "Email tool" },
           new string[] { "Secure website connection", "Hyper Text Transfer Protocol Secure", "Hack tool", "Login system" },
           new string[] { "Physical attack", "Tricking people into giving info", "Virus scan", "Firewall" },
           new string[] { "For fun", "Fix bugs and security issues", "Slow computer", "Delete files" }
        };

        private int[] correctAnswers = { 1, 2, 2, 1, 1, 1, 1, 1 };

        // Tasks
        private List<string> tasks = new List<string>();
        private List<bool> completed = new List<bool>();

        public Form1()
        {
            InitializeComponent();

            bot = new ChatbotEngine();

            lblQuestion.Text = "Click Start Quiz to begin";
            lblScore.Text = "Score: 0";
        }

        // ================= CHATBOT =================
        private void sendBtn_Click(object sender, EventArgs e)
{
    string input = txtInput.Text;

    if (string.IsNullOrWhiteSpace(input))
        return;

    string response = bot.GetResponse(input);

    rtbOutput.AppendText("You: " + input + Environment.NewLine);
    rtbOutput.AppendText("Bot: " + response + Environment.NewLine + Environment.NewLine);

    txtInput.Clear();
}

        private void cmbTone_SelectedIndexChanged(object sender, EventArgs e)
        {
            bot.Tone = cmbTone.Text;
        }

        // ================= QUIZ =================
        private void button1_Click(object sender, EventArgs e)
        {
            score = 0;
            questionIndex = 0;

            LoadQuestion();
        }

        private void LoadQuestion()
        {
            if (questionIndex >= questions.Length)
            {
                MessageBox.Show("Quiz finished! Final score: " + score);
                lblQuestion.Text = "Quiz complete";
                return;
            }

            lblQuestion.Text = questions[questionIndex];

            rdoA.Text = options[questionIndex][0];
            rdoB.Text = options[questionIndex][1];
            rdoC.Text = options[questionIndex][2];
            rdoD.Text = options[questionIndex][3];

            lblScore.Text = "Score: " + score;
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            int selected = -1;

            if (rdoA.Checked) selected = 0;
            else if (rdoB.Checked) selected = 1;
            else if (rdoC.Checked) selected = 2;
            else if (rdoD.Checked) selected = 3;

            if (selected == -1)
            {
                MessageBox.Show("Select an answer.");
                return;
            }

            
            if (selected == correctAnswers[questionIndex])
            {
                score++;
                MessageBox.Show("Correct!");
            }
            else
            {
                MessageBox.Show("Wrong answer.");
            }

            questionIndex++;
            LoadQuestion();
        }

        // ================= TASK SYSTEM =================
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string title = txtTaskTitle.Text;
            string desc = txtTaskDescription.Text;

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Enter a task title.");
                return;
            }

            string task = title + " - " + desc;

            tasks.Add(task);
            completed.Add(false);

            lstTasks.Items.Add(task);

            txtTaskTitle.Clear();
            txtTaskDescription.Clear();

            AddLog("Task added");
        }

        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex == -1)
            {
                MessageBox.Show("Select a task first.");
                return;
            }

            int index = lstTasks.SelectedIndex;

            completed[index] = true;
            lstTasks.Items[index] = "[DONE] " + tasks[index];

            AddLog("Task completed");
        }

        // ================= ACTIVITY LOG =================
        private void AddLog(string action)
        {
            ActivityLog.Items.Add($"{DateTime.Now:HH:mm}: {action}");
        }

        // ================= USER LOGIN =================
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginUser();
        }
    }
}