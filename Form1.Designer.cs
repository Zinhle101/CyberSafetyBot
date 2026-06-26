using System;
using System.Windows.Forms;

namespace CyberSafetyBot
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtInput = new TextBox();
            rtbOutput = new RichTextBox();
            sendBtn = new Button();
            cmbTone = new ComboBox();
            lblQuestion = new Label();
            lblScore = new Label();
            grpOptions = new GroupBox();
            rdoA = new RadioButton();
            rdoB = new RadioButton();
            rdoC = new RadioButton();
            rdoD = new RadioButton();
            btnStartQuiz = new Button();
            btnsubmitAnswer = new Button();
            txtTaskTitle = new TextBox();
            txtTaskDescription = new TextBox();
            lstTasks = new ListBox();
            btnAddTask = new Button();
            button1btnCompleteTask = new Button();
            ActivityLog = new ListBox();
            btnLogin = new Button();
            grpOptions.SuspendLayout();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(20, 160);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(200, 23);
            txtInput.TabIndex = 0;
            // 
            // rtbOutput
            // 
            rtbOutput.Location = new Point(20, 20);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.Size = new Size(250, 120);
            rtbOutput.TabIndex = 1;
            rtbOutput.Text = "";
            // 
            // sendBtn
            // 
            sendBtn.Location = new Point(230, 160);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(75, 23);
            sendBtn.TabIndex = 2;
            sendBtn.Text = "Send";
            sendBtn.UseVisualStyleBackColor = true;
            sendBtn.Click += sendBtn_Click;
            // 
            // cmbTone
            // 
            cmbTone.Items.AddRange(new object[] { "Friendly", "Serious", "Professional" });
            cmbTone.Location = new Point(20, 190);
            cmbTone.Name = "cmbTone";
            cmbTone.Size = new Size(150, 23);
            cmbTone.TabIndex = 3;
            cmbTone.SelectedIndexChanged += cmbTone_SelectedIndexChanged;
            // 
            // lblQuestion
            // 
            lblQuestion.Location = new Point(20, 230);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(300, 20);
            lblQuestion.TabIndex = 4;
            lblQuestion.Text = "Question will appear here";
            // 
            // lblScore
            // 
            lblScore.Location = new Point(350, 230);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(100, 20);
            lblScore.TabIndex = 5;
            lblScore.Text = "Score: 0";
            // 
            // grpOptions
            // 
            grpOptions.Controls.Add(rdoA);
            grpOptions.Controls.Add(rdoB);
            grpOptions.Controls.Add(rdoC);
            grpOptions.Controls.Add(rdoD);
            grpOptions.Location = new Point(20, 260);
            grpOptions.Name = "grpOptions";
            grpOptions.Size = new Size(250, 120);
            grpOptions.TabIndex = 6;
            grpOptions.TabStop = false;
            grpOptions.Text = "Options";
            // 
            // rdoA
            // 
            rdoA.Location = new Point(10, 20);
            rdoA.Name = "rdoA";
            rdoA.Size = new Size(104, 24);
            rdoA.TabIndex = 0;
            rdoA.Text = "Option A";
            // 
            // rdoB
            // 
            rdoB.Location = new Point(10, 45);
            rdoB.Name = "rdoB";
            rdoB.Size = new Size(104, 24);
            rdoB.TabIndex = 1;
            rdoB.Text = "Option B";
            // 
            // rdoC
            // 
            rdoC.Location = new Point(10, 70);
            rdoC.Name = "rdoC";
            rdoC.Size = new Size(104, 24);
            rdoC.TabIndex = 2;
            rdoC.Text = "Option C";
            // 
            // rdoD
            // 
            rdoD.Location = new Point(10, 95);
            rdoD.Name = "rdoD";
            rdoD.Size = new Size(104, 24);
            rdoD.TabIndex = 3;
            rdoD.Text = "Option D";
            // 
            // btnStartQuiz
            // 
            btnStartQuiz.Location = new Point(300, 260);
            btnStartQuiz.Name = "btnStartQuiz";
            btnStartQuiz.Size = new Size(100, 25);
            btnStartQuiz.TabIndex = 7;
            btnStartQuiz.Text = "Start Quiz";
            btnStartQuiz.Click += button1_Click;
            // 
            // btnsubmitAnswer
            // 
            btnsubmitAnswer.Location = new Point(300, 290);
            btnsubmitAnswer.Name = "btnsubmitAnswer";
            btnsubmitAnswer.Size = new Size(100, 25);
            btnsubmitAnswer.TabIndex = 8;
            btnsubmitAnswer.Text = "Submit";
            btnsubmitAnswer.Click += btnSubmitAnswer_Click;
            // 
            // txtTaskTitle
            // 
            txtTaskTitle.Location = new Point(450, 20);
            txtTaskTitle.Name = "txtTaskTitle";
            txtTaskTitle.Size = new Size(150, 23);
            txtTaskTitle.TabIndex = 9;
            // 
            // txtTaskDescription
            // 
            txtTaskDescription.Location = new Point(450, 50);
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.Size = new Size(150, 23);
            txtTaskDescription.TabIndex = 10;
            // 
            // lstTasks
            // 
            lstTasks.ItemHeight = 15;
            lstTasks.Location = new Point(450, 140);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(200, 94);
            lstTasks.TabIndex = 13;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(450, 80);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(100, 25);
            btnAddTask.TabIndex = 11;
            btnAddTask.Text = "Add Task";
            btnAddTask.Click += btnAddTask_Click;
            // 
            // button1btnCompleteTask
            // 
            button1btnCompleteTask.Location = new Point(450, 110);
            button1btnCompleteTask.Name = "button1btnCompleteTask";
            button1btnCompleteTask.Size = new Size(120, 25);
            button1btnCompleteTask.TabIndex = 12;
            button1btnCompleteTask.Text = "Mark Complete";
            button1btnCompleteTask.Click += btnCompleteTask_Click;
            // 
            // ActivityLog
            // 
            ActivityLog.ItemHeight = 15;
            ActivityLog.Location = new Point(450, 260);
            ActivityLog.Name = "ActivityLog";
            ActivityLog.Size = new Size(200, 109);
            ActivityLog.TabIndex = 14;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(230, 190);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 15;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(700, 420);
            Controls.Add(btnLogin);
            Controls.Add(txtInput);
            Controls.Add(rtbOutput);
            Controls.Add(sendBtn);
            Controls.Add(cmbTone);
            Controls.Add(lblQuestion);
            Controls.Add(lblScore);
            Controls.Add(grpOptions);
            Controls.Add(btnStartQuiz);
            Controls.Add(btnsubmitAnswer);
            Controls.Add(txtTaskTitle);
            Controls.Add(txtTaskDescription);
            Controls.Add(btnAddTask);
            Controls.Add(button1btnCompleteTask);
            Controls.Add(lstTasks);
            Controls.Add(ActivityLog);
            Name = "Form1";
            Text = "CyberSafetyBot";
            grpOptions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private RichTextBox rtbOutput;
        private Button sendBtn;
        private ComboBox cmbTone;

        private Label lblQuestion;
        private Label lblScore;

        private GroupBox grpOptions;
        private RadioButton rdoA;
        private RadioButton rdoB;
        private RadioButton rdoC;
        private RadioButton rdoD;

        private Button btnStartQuiz;
        private Button btnsubmitAnswer;

        private TextBox txtTaskTitle;
        private TextBox txtTaskDescription;

        private ListBox lstTasks;
        private Button btnAddTask;
        private Button button1btnCompleteTask;

        private ListBox ActivityLog;
        private Button btnLogin;
    }
}